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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddReviewer = new System.Windows.Forms.Button();
            this.lstActiveReviewers = new System.Windows.Forms.ListBox();
            this.btnFetchReviewers = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnRemoveReviewer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrganization = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccessToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lstAvailableReviewers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtProject);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtOrganization);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtAccessToken);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtUsername);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(638, 89);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Auth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Watching";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Available";
            // 
            // btnAddReviewer
            // 
            this.btnAddReviewer.Location = new System.Drawing.Point(275, 79);
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
            this.lstActiveReviewers.Location = new System.Drawing.Point(357, 37);
            this.lstActiveReviewers.Name = "lstActiveReviewers";
            this.lstActiveReviewers.Size = new System.Drawing.Size(273, 154);
            this.lstActiveReviewers.Sorted = true;
            this.lstActiveReviewers.TabIndex = 17;
            // 
            // btnFetchReviewers
            // 
            this.btnFetchReviewers.Location = new System.Drawing.Point(6, 200);
            this.btnFetchReviewers.Name = "btnFetchReviewers";
            this.btnFetchReviewers.Size = new System.Drawing.Size(263, 23);
            this.btnFetchReviewers.TabIndex = 16;
            this.btnFetchReviewers.Text = "Refresh Available";
            this.btnFetchReviewers.UseVisualStyleBackColor = true;
            this.btnFetchReviewers.Click += new System.EventHandler(this.btnFetchReviewers_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(501, 352);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(149, 23);
            this.btnSaveSettings.TabIndex = 14;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnRemoveReviewer
            // 
            this.btnRemoveReviewer.Location = new System.Drawing.Point(275, 127);
            this.btnRemoveReviewer.Name = "btnRemoveReviewer";
            this.btnRemoveReviewer.Size = new System.Drawing.Size(76, 23);
            this.btnRemoveReviewer.TabIndex = 13;
            this.btnRemoveReviewer.Text = "<--";
            this.btnRemoveReviewer.UseVisualStyleBackColor = true;
            this.btnRemoveReviewer.Click += new System.EventHandler(this.btnRemoveReviewer_Click);
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
            this.lstAvailableReviewers.Location = new System.Drawing.Point(6, 37);
            this.lstAvailableReviewers.Name = "lstAvailableReviewers";
            this.lstAvailableReviewers.Size = new System.Drawing.Size(263, 154);
            this.lstAvailableReviewers.Sorted = true;
            this.lstAvailableReviewers.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lstAvailableReviewers);
            this.groupBox1.Controls.Add(this.btnAddReviewer);
            this.groupBox1.Controls.Add(this.btnRemoveReviewer);
            this.groupBox1.Controls.Add(this.lstActiveReviewers);
            this.groupBox1.Controls.Add(this.btnFetchReviewers);
            this.groupBox1.Location = new System.Drawing.Point(12, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 239);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reviewers";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(346, 352);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 384);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
    }
}