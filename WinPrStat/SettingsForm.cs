using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PrStat.Core;

namespace WinPrStat
{
    public partial class SettingsForm : Form
    {
        private readonly Config config;
        private readonly AzureDevOpsApi api;

        public SettingsForm(Config _config, AzureDevOpsApi adoApi)
        {
            config = new()
            {
                Project = _config.Project,
                Organization = _config.Organization,
                Username = _config.Username,
                AccessToken = _config.AccessToken,
            };
            config.ReviewerIds.AddRange(_config.ReviewerIds);
            api = adoApi;
            InitializeComponent();
            UpdateUiFromConfig(config);
        }

        private void UpdateUiFromConfig(Config c)
        {
            txtAccessToken.Text = c.AccessToken;
            txtUsername.Text = c.Username;
            txtOrganization.Text = c.Organization;
            txtProject.Text = c.Project;
            FetchReviewersFromPrs(c);
        }

        private async void FetchReviewersFromPrs(Config c)
        {
            var prs = await api.GetPullRequests(c);
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

            InternalOnSettingsSaved(config);
            Close();
        }
        internal void InternalOnSettingsSaved(Config config)
        {
            SettingsSaved[] array;
            lock (_onSettingsSaved)
            {
                array = _onSettingsSaved.ToArray();
            }

            SettingsSaved[] array2 = array;
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i](config);
            }
        }
        
        public delegate void SettingsSaved(Config cfg);
        private readonly List<SettingsSaved> _onSettingsSaved = new();
        public event SettingsSaved OnSettingsSaved
        {
            add
            {
                lock (_onSettingsSaved)
                {
                    _onSettingsSaved.Add(value);
                }
            }

            remove
            {
                lock (_onSettingsSaved)
                {
                    _onSettingsSaved.Remove(value);
                }
            }
        }

        private void btnFetchReviewers_Click(object sender, EventArgs e)
        {
            FetchReviewersFromPrs(config);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
