using Microsoft.Toolkit.Uwp.Notifications;
using PrStat.Core;
using PrStat.Toaster;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Windows.Foundation.Collections;
using WinPrStat;

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

            fetchTimer = CreateTimerForPrRefresh();
            notifyIcon = CreateNotifyIcon();

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
            txtLogBox.Text = $"{DateTime.Now}: {msg}\r\n" + txtLogBox.Text;
        }

        internal void MarkPrAsReviewed(int prId)
        {
            state.Reviewed.Add(prId);
            Log($"{prId} - Marked as Reviewed");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                ProgramState.SaveState(state, StatePath);
            }
        }

        private void btnFetchPrs_Click(object sender, EventArgs e)
        {
            FetchPullRequests();
        }

        private async void FetchPullRequests()
        {
            IList<PullRequest> prs;

            try
            {

                Log("fetching pull requests");
                prs = (await adoApi.GetPullRequestListForReviewers(config));

            }
            catch (Exception ex)
            {
                Log("An error occurred while fetching pull requests");
                Log(ex.Message);
                return;
            }
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
                if (config.ShowNotifications)
                {
                    Toaster.GenerateToastForPr(pr);
                }
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
            if (FormWindowState.Minimized == this.WindowState && config.MinimizeToTray)
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

        private void mnuSettings_Click(object sender, EventArgs e)
        {
            var form = new SettingsForm(config, adoApi);
            form.OnSettingsSaved += cfg =>
            {
                config.Organization = cfg.Organization;
                config.AccessToken = cfg.AccessToken;
                config.Username = cfg.Username;
                config.Project = cfg.Project;
                config.ReviewerIds.Clear();
                config.ReviewerIds.AddRange(cfg.ReviewerIds);

                Config.SaveConfig(config, ConfigPath);
                Log("Saved config.");
            };
            form.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstActivePrs_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnMarkReviewed.Enabled = lstActivePrs.SelectedIndex != -1;
        }
    }
}
