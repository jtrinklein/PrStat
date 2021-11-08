namespace WinPrStat
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnShowToken = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrganization = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccessToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddReviewer = new System.Windows.Forms.Button();
            this.lstActiveReviewers = new System.Windows.Forms.ListBox();
            this.btnFetchReviewers = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnRemoveReviewer = new System.Windows.Forms.Button();
            this.lstAvailableReviewers = new System.Windows.Forms.ListBox();
            this.grpReviewers = new System.Windows.Forms.GroupBox();
            this.pnlLoading = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pbFetchReviewers = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAutostart = new System.Windows.Forms.CheckBox();
            this.chkShowNotifications = new System.Windows.Forms.CheckBox();
            this.chkMinimizeToTray = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            this.grpReviewers.SuspendLayout();
            this.pnlLoading.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnShowToken);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtProject);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtOrganization);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtAccessToken);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtUsername);
            this.groupBox3.Location = new System.Drawing.Point(14, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(729, 119);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Auth";
            // 
            // btnShowToken
            // 
            this.btnShowToken.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowToken.BackgroundImage")));
            this.btnShowToken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowToken.Location = new System.Drawing.Point(678, 28);
            this.btnShowToken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowToken.Name = "btnShowToken";
            this.btnShowToken.Size = new System.Drawing.Size(41, 31);
            this.btnShowToken.TabIndex = 16;
            this.btnShowToken.UseVisualStyleBackColor = true;
            this.btnShowToken.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowToken_MouseDown);
            this.btnShowToken.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShowToken_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Project";
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(480, 69);
            this.txtProject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(241, 27);
            this.txtProject.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Organization";
            // 
            // txtOrganization
            // 
            this.txtOrganization.Location = new System.Drawing.Point(120, 69);
            this.txtOrganization.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrganization.Name = "txtOrganization";
            this.txtOrganization.Size = new System.Drawing.Size(241, 27);
            this.txtOrganization.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Access Token";
            // 
            // txtAccessToken
            // 
            this.txtAccessToken.Location = new System.Drawing.Point(480, 30);
            this.txtAccessToken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.PasswordChar = '*';
            this.txtAccessToken.Size = new System.Drawing.Size(192, 27);
            this.txtAccessToken.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(120, 30);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(241, 27);
            this.txtUsername.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Watching";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Available";
            // 
            // btnAddReviewer
            // 
            this.btnAddReviewer.Location = new System.Drawing.Point(314, 105);
            this.btnAddReviewer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddReviewer.Name = "btnAddReviewer";
            this.btnAddReviewer.Size = new System.Drawing.Size(87, 31);
            this.btnAddReviewer.TabIndex = 18;
            this.btnAddReviewer.Text = "-->";
            this.btnAddReviewer.UseVisualStyleBackColor = true;
            this.btnAddReviewer.Click += new System.EventHandler(this.btnAddReviewer_Click);
            // 
            // lstActiveReviewers
            // 
            this.lstActiveReviewers.FormattingEnabled = true;
            this.lstActiveReviewers.ItemHeight = 20;
            this.lstActiveReviewers.Location = new System.Drawing.Point(408, 49);
            this.lstActiveReviewers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstActiveReviewers.Name = "lstActiveReviewers";
            this.lstActiveReviewers.Size = new System.Drawing.Size(311, 204);
            this.lstActiveReviewers.Sorted = true;
            this.lstActiveReviewers.TabIndex = 17;
            // 
            // btnFetchReviewers
            // 
            this.btnFetchReviewers.Location = new System.Drawing.Point(7, 267);
            this.btnFetchReviewers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFetchReviewers.Name = "btnFetchReviewers";
            this.btnFetchReviewers.Size = new System.Drawing.Size(301, 31);
            this.btnFetchReviewers.TabIndex = 16;
            this.btnFetchReviewers.Text = "Refresh Available";
            this.btnFetchReviewers.UseVisualStyleBackColor = true;
            this.btnFetchReviewers.Click += new System.EventHandler(this.btnFetchReviewers_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(573, 588);
            this.btnSaveSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(170, 31);
            this.btnSaveSettings.TabIndex = 14;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnRemoveReviewer
            // 
            this.btnRemoveReviewer.Location = new System.Drawing.Point(314, 169);
            this.btnRemoveReviewer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveReviewer.Name = "btnRemoveReviewer";
            this.btnRemoveReviewer.Size = new System.Drawing.Size(87, 31);
            this.btnRemoveReviewer.TabIndex = 13;
            this.btnRemoveReviewer.Text = "<--";
            this.btnRemoveReviewer.UseVisualStyleBackColor = true;
            this.btnRemoveReviewer.Click += new System.EventHandler(this.btnRemoveReviewer_Click);
            // 
            // lstAvailableReviewers
            // 
            this.lstAvailableReviewers.FormattingEnabled = true;
            this.lstAvailableReviewers.ItemHeight = 20;
            this.lstAvailableReviewers.Location = new System.Drawing.Point(7, 49);
            this.lstAvailableReviewers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstAvailableReviewers.Name = "lstAvailableReviewers";
            this.lstAvailableReviewers.Size = new System.Drawing.Size(300, 204);
            this.lstAvailableReviewers.Sorted = true;
            this.lstAvailableReviewers.TabIndex = 1;
            // 
            // grpReviewers
            // 
            this.grpReviewers.Controls.Add(this.pnlLoading);
            this.grpReviewers.Controls.Add(this.label7);
            this.grpReviewers.Controls.Add(this.label6);
            this.grpReviewers.Controls.Add(this.lstAvailableReviewers);
            this.grpReviewers.Controls.Add(this.btnAddReviewer);
            this.grpReviewers.Controls.Add(this.btnRemoveReviewer);
            this.grpReviewers.Controls.Add(this.lstActiveReviewers);
            this.grpReviewers.Controls.Add(this.btnFetchReviewers);
            this.grpReviewers.Enabled = false;
            this.grpReviewers.Location = new System.Drawing.Point(14, 143);
            this.grpReviewers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpReviewers.Name = "grpReviewers";
            this.grpReviewers.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpReviewers.Size = new System.Drawing.Size(729, 319);
            this.grpReviewers.TabIndex = 3;
            this.grpReviewers.TabStop = false;
            this.grpReviewers.Text = "Reviewers";
            // 
            // pnlLoading
            // 
            this.pnlLoading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLoading.Controls.Add(this.label5);
            this.pnlLoading.Controls.Add(this.pbFetchReviewers);
            this.pnlLoading.Location = new System.Drawing.Point(98, 32);
            this.pnlLoading.Name = "pnlLoading";
            this.pnlLoading.Size = new System.Drawing.Size(541, 266);
            this.pnlLoading.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fetching Reviewers... Please wait.";
            // 
            // pbFetchReviewers
            // 
            this.pbFetchReviewers.Location = new System.Drawing.Point(22, 137);
            this.pbFetchReviewers.Maximum = 3;
            this.pbFetchReviewers.Name = "pbFetchReviewers";
            this.pbFetchReviewers.Size = new System.Drawing.Size(491, 29);
            this.pbFetchReviewers.Step = 1;
            this.pbFetchReviewers.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbFetchReviewers.TabIndex = 0;
            this.pbFetchReviewers.Value = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(395, 588);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(170, 31);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkAutostart);
            this.groupBox2.Controls.Add(this.chkShowNotifications);
            this.groupBox2.Controls.Add(this.chkMinimizeToTray);
            this.groupBox2.Location = new System.Drawing.Point(14, 469);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 112);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General";
            // 
            // chkAutostart
            // 
            this.chkAutostart.AutoSize = true;
            this.chkAutostart.Enabled = false;
            this.chkAutostart.Location = new System.Drawing.Point(7, 26);
            this.chkAutostart.Name = "chkAutostart";
            this.chkAutostart.Size = new System.Drawing.Size(275, 24);
            this.chkAutostart.TabIndex = 2;
            this.chkAutostart.Text = "Start application at Windows Startup";
            this.chkAutostart.UseVisualStyleBackColor = true;
            // 
            // chkShowNotifications
            // 
            this.chkShowNotifications.AutoSize = true;
            this.chkShowNotifications.Checked = true;
            this.chkShowNotifications.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowNotifications.Location = new System.Drawing.Point(7, 86);
            this.chkShowNotifications.Name = "chkShowNotifications";
            this.chkShowNotifications.Size = new System.Drawing.Size(364, 24);
            this.chkShowNotifications.TabIndex = 1;
            this.chkShowNotifications.Text = "Show Notification on New Pull Request for Review";
            this.chkShowNotifications.UseVisualStyleBackColor = true;
            // 
            // chkMinimizeToTray
            // 
            this.chkMinimizeToTray.AutoSize = true;
            this.chkMinimizeToTray.Checked = true;
            this.chkMinimizeToTray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMinimizeToTray.Location = new System.Drawing.Point(7, 56);
            this.chkMinimizeToTray.Name = "chkMinimizeToTray";
            this.chkMinimizeToTray.Size = new System.Drawing.Size(254, 24);
            this.chkMinimizeToTray.TabIndex = 0;
            this.chkMinimizeToTray.Text = "Minimize app to Notification Tray";
            this.chkMinimizeToTray.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 625);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.grpReviewers);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpReviewers.ResumeLayout(false);
            this.grpReviewers.PerformLayout();
            this.pnlLoading.ResumeLayout(false);
            this.pnlLoading.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddReviewer;
        private System.Windows.Forms.ListBox lstActiveReviewers;
        private System.Windows.Forms.Button btnFetchReviewers;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnRemoveReviewer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrganization;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccessToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ListBox lstAvailableReviewers;
        private System.Windows.Forms.GroupBox grpReviewers;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnShowToken;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkAutostart;
        private System.Windows.Forms.CheckBox chkShowNotifications;
        private System.Windows.Forms.CheckBox chkMinimizeToTray;
        private System.Windows.Forms.Panel pnlLoading;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbFetchReviewers;
    }
}