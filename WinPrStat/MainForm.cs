using Microsoft.Toolkit.Uwp.Notifications;
using PrStat.Core;
using PrStat.Toaster;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Windows.Foundation.Collections;

namespace WinPrStatForm
{
    public partial class MainForm : Form
    {
        readonly private string version = "1.0.0";
        readonly private string ConfigPath = Path.Join(AppContext.BaseDirectory, "config.json");
        readonly private string StatePath = Path.Join(AppContext.BaseDirectory, "state.json");
        private readonly Config config;
        private readonly ProgramState state;
        private readonly AzureDevOpsApi adoApi = new();
        private readonly Timer fetchTimer;
        private readonly NotifyIcon notifyIcon;

        public MainForm()
        {
            InitializeComponent();

            lblVersion.Text = version;

            // Listen to notification activation
            ToastNotificationManagerCompat.OnActivated += HandleToastActivated;

            config = Config.LoadConfig(ConfigPath);
            state = ProgramState.LoadState(StatePath);

            UpdateUiFromConfig(config);

            fetchTimer = CreateTimerForPrRefresh();
            notifyIcon = CreateNotifyIcon();

            FetchReviewersFromPrs();
            FetchPullRequests();
        }

        private Timer CreateTimerForPrRefresh()
        {
            const int fiveMinutes = 5 * 60 * 1000;

            var timer = new Timer
            {
                Interval = fiveMinutes,

            };
            timer.Tick += FetchTimer_Tick;
            timer.Start();
            return timer;
        }

        private NotifyIcon CreateNotifyIcon() 
        {

            components = new System.ComponentModel.Container();
            var icon = new NotifyIcon(components)
            {

                // The Icon property sets the icon that will appear
                // in the systray for this application.
                Icon = new Icon("PrStat.ico"),

                // The Text property sets the text that will be displayed,
                // in a tooltip, when the mouse hovers over the systray icon.
                Text = "PrStat",
                Visible = true,
                
            };

            // Handle the DoubleClick event to activate the form.
            icon.Click += new EventHandler(NotifyIcon_Click);
            return icon;
        }

        private void NotifyIcon_Click(object? sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                // Activate the form.
                Show();
                WindowState = FormWindowState.Normal;
                Activate();
            }
            else
            {
                WindowState = FormWindowState.Minimized;
                Hide();
            }

        }

        private void FetchTimer_Tick(object? sender, EventArgs e)
        {
            FetchPullRequests();
        }

        private void UpdateUiFromConfig(Config config)
        {
            txtAccessToken.Text = config.AccessToken;
            txtUsername.Text = config.Username;
            txtOrganization.Text = config.Organization;
            txtProject.Text = config.Project;
        }

        public void HandleToastActivated(ToastNotificationActivatedEventArgsCompat toastArgs)
        {
            if (InvokeRequired)
            {
                // Call this same method but append THREAD2 to the text
                Action safeWrite = delegate { HandleToastActivated(toastArgs); };
                Invoke(safeWrite);
                return;
            }

            // Obtain the arguments from the notification
            ToastArguments args = ToastArguments.Parse(toastArgs.Argument);
            var prId = args.GetInt(Toaster.PrIdArg);
            var action = args.Get(Toaster.ActionArg);
            var url = args.Get(Toaster.PrUrlArg);
            // Obtain any user input (text boxes, menu selections) from the notification
            ValueSet userInput = toastArgs.UserInput;

            //logger.Log($"For PR: {prId} doing Action: {action}");

            Log($"Toast Action {action} for pr {prId}");
            if (action == Toaster.Action_View)
            {
                WebLauncher.OpenUrl(url);
            }
            else if (action == Toaster.Action_MarkRead)
            {
                MarkPrAsReviewed(prId);
            }
        }

        internal void Log(string msg)
        {
            txtLogBox.Text += $"{DateTime.Now}: {msg}\r\n";
        }


        internal void MarkPrAsReviewed(int prId)
        {
            state.Reviewed.Add(prId);
            Log($"{prId} - Marked as Reviewed");
        }


        private async void FetchReviewersFromPrs()
        {
            Log("Fetching reviewers from recent Pull Requests");
            var prs = await adoApi.GetPullRequests(config);
            var reviewersById = prs.SelectMany(pr => pr.Reviewers).GroupBy(r => r.Id).Select(g => g.First()).ToList().OrderBy(r => r.Name);
            lstAvailableReviewers.Items.Clear();
            lstActiveReviewers.Items.Clear();
            foreach (var reviewer in reviewersById)
            {
                if (config.ReviewerIds.Contains(reviewer.Id))
                {
                    lstActiveReviewers.Items.Add(reviewer);
                }
                else
                {
                    lstAvailableReviewers.Items.Add(reviewer);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                ProgramState.SaveState(state, StatePath);
                //Config.SaveConfig(config, ConfigPath);
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            config.Project = txtProject.Text;
            config.Organization = txtOrganization.Text;
            config.AccessToken = txtAccessToken.Text;
            config.Username = txtUsername.Text;
            config.ReviewerIds.Clear();
            foreach (Reviewer reviewer in lstActiveReviewers.Items)
            {
                config.ReviewerIds.Add(reviewer.Id);
            }
        }

        private void btnFetchReviewers_Click(object sender, EventArgs e)
        {
            FetchReviewersFromPrs();
        }

        private void btnAddReviewer_Click(object sender, EventArgs e)
        {
            AddReviewer();
        }

        private void AddReviewer()
        {
            var index = lstAvailableReviewers.SelectedIndex;
            if (index == -1)
            {
                return;
            }

            lstActiveReviewers.Items.Add(lstAvailableReviewers.SelectedItem);

            lstAvailableReviewers.Items.RemoveAt(index);
            lstAvailableReviewers.SelectedIndex = Math.Min(index, lstAvailableReviewers.Items.Count - 1);
        }

        private void btnRemoveReviewer_Click(object sender, System.EventArgs e)
        {
            RemoveReviewer();
        }
        private void RemoveReviewer() 
        {
            var index = lstActiveReviewers.SelectedIndex;
            if (index == -1)
            {
                return;
            }

            lstAvailableReviewers.Items.Add(lstActiveReviewers.SelectedItem);

            lstActiveReviewers.Items.RemoveAt(index);
            lstActiveReviewers.SelectedIndex = Math.Min(index, lstActiveReviewers.Items.Count - 1);
        }

        private void lstAvailableReviewers_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddReviewer();
            }
        }

        private void lstActiveReviewers_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveReviewer();
            }

        }

        private void btnFetchPrs_Click(object sender, EventArgs e)
        {
            FetchPullRequests();
        }

        private async void FetchPullRequests()
        {
            Log("fetching pull requests");
            var prs = (await adoApi.GetPullRequestListForReviewers(config));
            var prsNeedReview = prs.Where(pr => pr.NeedsReview && !state.Reviewed.Contains(pr.Id));
            var prsReviewed = prs.Where(pr => !pr.NeedsReview || state.Reviewed.Contains(pr.Id));
            var prsNeedToast = prsNeedReview.Where(pr => !state.ToastedIds.Contains(pr.Id));

            lstActivePrs.Items.Clear();
            lstReviewedPrs.Items.Clear();

            foreach (var pr in prsNeedReview)
            {
                lstActivePrs.Items.Add(pr);
            }
            foreach (var pr in prsReviewed)
            {
                lstReviewedPrs.Items.Add(pr);
            }

            foreach (var pr in prsNeedToast)
            {
                Toaster.GenerateToastForPr(pr);
                state.ToastedIds.Add(pr.Id);
            }
        }

        private void lstActivePrs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lstActivePrs.IndexFromPoint(e.Location);
            if (index == ListBox.NoMatches)
            {
                return;
            }
            var pr = (PullRequest)lstActivePrs.Items[index];
            if (pr == null)
            {
                return;
            }
            WebLauncher.OpenUrl(pr.Url);
            Log($"Open review page for {pr.Id}");
        }

        private void btnMarkReviewed_Click(object sender, EventArgs e)
        {
            var index = lstActivePrs.SelectedIndex;
            if (index == ListBox.NoMatches)
            {
                return;
            }
            state.Reviewed.Add(((PullRequest)lstActivePrs.SelectedItem).Id);
            lstReviewedPrs.Items.Add(lstActivePrs.SelectedItem);
            lstActivePrs.Items.RemoveAt(index);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                Hide();
            }
        }

        private void lstReviewedPrs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lstReviewedPrs.IndexFromPoint(e.Location);
            if (index == ListBox.NoMatches)
            {
                return;
            }
            var pr = (PullRequest)lstReviewedPrs.Items[index];
            if (pr == null)
            {
                return;
            }
            WebLauncher.OpenUrl(pr.Url);
            Log($"Open review page for {pr.Id}");
        }

        private void btnClearLogs_Click(object sender, EventArgs e)
        {
            txtLogBox.Text = string.Empty;
        }
    }
}
