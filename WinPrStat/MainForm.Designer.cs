namespace WinPrStatForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstActivePrs = new System.Windows.Forms.ListBox();
            this.btnMarkReviewed = new System.Windows.Forms.Button();
            this.btnFetchPrs = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstReviewedPrs = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddReviewer = new System.Windows.Forms.Button();
            this.lstActiveReviewers = new System.Windows.Forms.ListBox();
            this.btnFetchReviewers = new System.Windows.Forms.Button();
            this.txtLogBox = new System.Windows.Forms.TextBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnRemoveReviewer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrganization = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccessToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lstAvailableReviewers = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClearLogs = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstActivePrs);
            this.groupBox1.Controls.Add(this.btnMarkReviewed);
            this.groupBox1.Controls.Add(this.btnFetchPrs);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Need Review";
            // 
            // lstActivePrs
            // 
            this.lstActivePrs.FormattingEnabled = true;
            this.lstActivePrs.ItemHeight = 15;
            this.lstActivePrs.Location = new System.Drawing.Point(6, 22);
            this.lstActivePrs.Name = "lstActivePrs";
            this.lstActivePrs.Size = new System.Drawing.Size(441, 274);
            this.lstActivePrs.Sorted = true;
            this.lstActivePrs.TabIndex = 22;
            this.lstActivePrs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstActivePrs_MouseDoubleClick);
            // 
            // btnMarkReviewed
            // 
            this.btnMarkReviewed.Location = new System.Drawing.Point(6, 302);
            this.btnMarkReviewed.Name = "btnMarkReviewed";
            this.btnMarkReviewed.Size = new System.Drawing.Size(119, 23);
            this.btnMarkReviewed.TabIndex = 17;
            this.btnMarkReviewed.Text = "Mark As Reviewed";
            this.btnMarkReviewed.UseVisualStyleBackColor = true;
            this.btnMarkReviewed.Click += new System.EventHandler(this.btnMarkReviewed_Click);
            // 
            // btnFetchPrs
            // 
            this.btnFetchPrs.Location = new System.Drawing.Point(131, 302);
            this.btnFetchPrs.Name = "btnFetchPrs";
            this.btnFetchPrs.Size = new System.Drawing.Size(316, 23);
            this.btnFetchPrs.TabIndex = 0;
            this.btnFetchPrs.Text = "Refresh PR List";
            this.btnFetchPrs.UseVisualStyleBackColor = true;
            this.btnFetchPrs.Click += new System.EventHandler(this.btnFetchPrs_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstReviewedPrs);
            this.groupBox2.Location = new System.Drawing.Point(12, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 141);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reviewed";
            // 
            // lstReviewedPrs
            // 
            this.lstReviewedPrs.FormattingEnabled = true;
            this.lstReviewedPrs.ItemHeight = 15;
            this.lstReviewedPrs.Location = new System.Drawing.Point(6, 22);
            this.lstReviewedPrs.Name = "lstReviewedPrs";
            this.lstReviewedPrs.Size = new System.Drawing.Size(441, 109);
            this.lstReviewedPrs.Sorted = true;
            this.lstReviewedPrs.TabIndex = 23;
            this.lstReviewedPrs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstReviewedPrs_MouseDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnAddReviewer);
            this.groupBox3.Controls.Add(this.lstActiveReviewers);
            this.groupBox3.Controls.Add(this.btnFetchReviewers);
            this.groupBox3.Controls.Add(this.btnSaveSettings);
            this.groupBox3.Controls.Add(this.btnRemoveReviewer);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtProject);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtOrganization);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtAccessToken);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtUsername);
            this.groupBox3.Controls.Add(this.lstAvailableReviewers);
            this.groupBox3.Location = new System.Drawing.Point(471, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(638, 335);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Watching";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Available";
            // 
            // btnAddReviewer
            // 
            this.btnAddReviewer.Location = new System.Drawing.Point(321, 151);
            this.btnAddReviewer.Name = "btnAddReviewer";
            this.btnAddReviewer.Size = new System.Drawing.Size(76, 23);
            this.btnAddReviewer.TabIndex = 18;
            this.btnAddReviewer.Text = "-->";
            this.btnAddReviewer.UseVisualStyleBackColor = true;
            this.btnAddReviewer.Click += new System.EventHandler(this.btnAddReviewer_Click);
            // 
            // lstActiveReviewers
            // 
            this.lstActiveReviewers.FormattingEnabled = true;
            this.lstActiveReviewers.ItemHeight = 15;
            this.lstActiveReviewers.Location = new System.Drawing.Point(403, 110);
            this.lstActiveReviewers.Name = "lstActiveReviewers";
            this.lstActiveReviewers.Size = new System.Drawing.Size(227, 154);
            this.lstActiveReviewers.Sorted = true;
            this.lstActiveReviewers.TabIndex = 17;
            this.lstActiveReviewers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstActiveReviewers_KeyUp);
            // 
            // btnFetchReviewers
            // 
            this.btnFetchReviewers.Location = new System.Drawing.Point(88, 273);
            this.btnFetchReviewers.Name = "btnFetchReviewers";
            this.btnFetchReviewers.Size = new System.Drawing.Size(229, 23);
            this.btnFetchReviewers.TabIndex = 16;
            this.btnFetchReviewers.Text = "Fetch Reviewers";
            this.btnFetchReviewers.UseVisualStyleBackColor = true;
            this.btnFetchReviewers.Click += new System.EventHandler(this.btnFetchReviewers_Click);
            // 
            // txtLogBox
            // 
            this.txtLogBox.Location = new System.Drawing.Point(88, 22);
            this.txtLogBox.Multiline = true;
            this.txtLogBox.Name = "txtLogBox";
            this.txtLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogBox.Size = new System.Drawing.Size(542, 98);
            this.txtLogBox.TabIndex = 15;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(89, 302);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(542, 23);
            this.btnSaveSettings.TabIndex = 14;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnRemoveReviewer
            // 
            this.btnRemoveReviewer.Location = new System.Drawing.Point(321, 196);
            this.btnRemoveReviewer.Name = "btnRemoveReviewer";
            this.btnRemoveReviewer.Size = new System.Drawing.Size(76, 23);
            this.btnRemoveReviewer.TabIndex = 13;
            this.btnRemoveReviewer.Text = "<--";
            this.btnRemoveReviewer.UseVisualStyleBackColor = true;
            this.btnRemoveReviewer.Click += new System.EventHandler(this.btnRemoveReviewer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Reviewers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Project";
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(403, 51);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(227, 23);
            this.txtProject.TabIndex = 8;
            this.txtProject.Text = "valant.io";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Organization";
            // 
            // txtOrganization
            // 
            this.txtOrganization.Location = new System.Drawing.Point(88, 51);
            this.txtOrganization.Name = "txtOrganization";
            this.txtOrganization.Size = new System.Drawing.Size(227, 23);
            this.txtOrganization.TabIndex = 6;
            this.txtOrganization.Text = "privatepracticesuite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Access Token";
            // 
            // txtAccessToken
            // 
            this.txtAccessToken.Location = new System.Drawing.Point(403, 22);
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.Size = new System.Drawing.Size(227, 23);
            this.txtAccessToken.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(88, 22);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(227, 23);
            this.txtUsername.TabIndex = 2;
            // 
            // lstAvailableReviewers
            // 
            this.lstAvailableReviewers.FormattingEnabled = true;
            this.lstAvailableReviewers.ItemHeight = 15;
            this.lstAvailableReviewers.Location = new System.Drawing.Point(88, 110);
            this.lstAvailableReviewers.Name = "lstAvailableReviewers";
            this.lstAvailableReviewers.Size = new System.Drawing.Size(227, 154);
            this.lstAvailableReviewers.Sorted = true;
            this.lstAvailableReviewers.TabIndex = 1;
            this.lstAvailableReviewers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstAvailableReviewers_KeyUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1114, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel1.Text = "PrStat Version";
            // 
            // lblVersion
            // 
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(37, 17);
            this.lblVersion.Text = "v1.0.0";
            // 
            // btnClearLogs
            // 
            this.btnClearLogs.Location = new System.Drawing.Point(6, 22);
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new System.Drawing.Size(75, 95);
            this.btnClearLogs.TabIndex = 23;
            this.btnClearLogs.Text = "Clear Logs";
            this.btnClearLogs.UseVisualStyleBackColor = true;
            this.btnClearLogs.Click += new System.EventHandler(this.btnClearLogs_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClearLogs);
            this.groupBox4.Controls.Add(this.txtLogBox);
            this.groupBox4.Location = new System.Drawing.Point(471, 353);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(638, 141);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Logs";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 519);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "PrStat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMarkReviewed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFetchReviewers;
        private System.Windows.Forms.TextBox txtLogBox;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnRemoveReviewer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrganization;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccessToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ListBox lstAvailableReviewers;
        private System.Windows.Forms.Button btnFetchPrs;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddReviewer;
        private System.Windows.Forms.ListBox lstActiveReviewers;
        private System.Windows.Forms.ListBox lstActivePrs;
        private System.Windows.Forms.ListBox lstReviewedPrs;
        private System.Windows.Forms.ToolStripStatusLabel lblVersion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnClearLogs;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}
