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
            this.txtLogBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClearLogs = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstActivePrs);
            this.groupBox1.Controls.Add(this.btnMarkReviewed);
            this.groupBox1.Controls.Add(this.btnFetchPrs);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 287);
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
            this.lstActivePrs.Size = new System.Drawing.Size(441, 229);
            this.lstActivePrs.Sorted = true;
            this.lstActivePrs.TabIndex = 22;
            this.lstActivePrs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstActivePrs_MouseDoubleClick);
            // 
            // btnMarkReviewed
            // 
            this.btnMarkReviewed.Location = new System.Drawing.Point(6, 257);
            this.btnMarkReviewed.Name = "btnMarkReviewed";
            this.btnMarkReviewed.Size = new System.Drawing.Size(119, 23);
            this.btnMarkReviewed.TabIndex = 17;
            this.btnMarkReviewed.Text = "Mark As Reviewed";
            this.btnMarkReviewed.UseVisualStyleBackColor = true;
            this.btnMarkReviewed.Click += new System.EventHandler(this.btnMarkReviewed_Click);
            // 
            // btnFetchPrs
            // 
            this.btnFetchPrs.Location = new System.Drawing.Point(131, 257);
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
            // txtLogBox
            // 
            this.txtLogBox.Location = new System.Drawing.Point(6, 22);
            this.txtLogBox.Multiline = true;
            this.txtLogBox.Name = "txtLogBox";
            this.txtLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogBox.Size = new System.Drawing.Size(441, 98);
            this.txtLogBox.TabIndex = 15;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 664);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(477, 22);
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
            this.btnClearLogs.Location = new System.Drawing.Point(305, 126);
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new System.Drawing.Size(142, 25);
            this.btnClearLogs.TabIndex = 23;
            this.btnClearLogs.Text = "Clear Logs";
            this.btnClearLogs.UseVisualStyleBackColor = true;
            this.btnClearLogs.Click += new System.EventHandler(this.btnClearLogs_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClearLogs);
            this.groupBox4.Controls.Add(this.txtLogBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 500);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(453, 158);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Logs";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(477, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSettings,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuSettings
            // 
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.Size = new System.Drawing.Size(180, 22);
            this.mnuSettings.Text = "&Settings";
            this.mnuSettings.Click += new System.EventHandler(this.mnuSettings_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 686);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "PrStat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMarkReviewed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLogBox;
        private System.Windows.Forms.Button btnFetchPrs;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListBox lstActivePrs;
        private System.Windows.Forms.ListBox lstReviewedPrs;
        private System.Windows.Forms.ToolStripStatusLabel lblVersion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnClearLogs;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSettings;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}
