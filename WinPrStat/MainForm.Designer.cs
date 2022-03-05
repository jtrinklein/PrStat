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
            this.lstActivePrs = new System.Windows.Forms.ListBox();
            this.btnMarkReviewed = new System.Windows.Forms.Button();
            this.btnFetchPrs = new System.Windows.Forms.Button();
            this.lstReviewedPrs = new System.Windows.Forms.ListBox();
            this.txtLogBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClearLogs = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnExportLogs = new System.Windows.Forms.Button();
            this.dlgExportLogs = new System.Windows.Forms.SaveFileDialog();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutPrStatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstActivePrs
            // 
            this.lstActivePrs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstActivePrs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstActivePrs.FormattingEnabled = true;
            this.lstActivePrs.HorizontalScrollbar = true;
            this.lstActivePrs.IntegralHeight = false;
            this.lstActivePrs.ItemHeight = 21;
            this.lstActivePrs.Location = new System.Drawing.Point(3, 2);
            this.lstActivePrs.Name = "lstActivePrs";
            this.lstActivePrs.Size = new System.Drawing.Size(525, 341);
            this.lstActivePrs.Sorted = true;
            this.lstActivePrs.TabIndex = 22;
            this.lstActivePrs.SelectedIndexChanged += new System.EventHandler(this.lstActivePrs_SelectedIndexChanged);
            this.lstActivePrs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstActivePrs_MouseDoubleClick);
            // 
            // btnMarkReviewed
            // 
            this.btnMarkReviewed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMarkReviewed.Enabled = false;
            this.btnMarkReviewed.Location = new System.Drawing.Point(3, 346);
            this.btnMarkReviewed.Name = "btnMarkReviewed";
            this.btnMarkReviewed.Size = new System.Drawing.Size(522, 23);
            this.btnMarkReviewed.TabIndex = 17;
            this.btnMarkReviewed.Text = "Mark As Reviewed";
            this.btnMarkReviewed.UseVisualStyleBackColor = true;
            this.btnMarkReviewed.Click += new System.EventHandler(this.btnMarkReviewed_Click);
            // 
            // btnFetchPrs
            // 
            this.btnFetchPrs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFetchPrs.Location = new System.Drawing.Point(3, 369);
            this.btnFetchPrs.Name = "btnFetchPrs";
            this.btnFetchPrs.Size = new System.Drawing.Size(522, 23);
            this.btnFetchPrs.TabIndex = 0;
            this.btnFetchPrs.Text = "Refresh PR List";
            this.btnFetchPrs.UseVisualStyleBackColor = true;
            this.btnFetchPrs.Click += new System.EventHandler(this.btnFetchPrs_Click);
            // 
            // lstReviewedPrs
            // 
            this.lstReviewedPrs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstReviewedPrs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstReviewedPrs.FormattingEnabled = true;
            this.lstReviewedPrs.HorizontalScrollbar = true;
            this.lstReviewedPrs.IntegralHeight = false;
            this.lstReviewedPrs.ItemHeight = 21;
            this.lstReviewedPrs.Location = new System.Drawing.Point(3, 2);
            this.lstReviewedPrs.Name = "lstReviewedPrs";
            this.lstReviewedPrs.Size = new System.Drawing.Size(522, 390);
            this.lstReviewedPrs.Sorted = true;
            this.lstReviewedPrs.TabIndex = 23;
            this.lstReviewedPrs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstReviewedPrs_MouseDoubleClick);
            // 
            // txtLogBox
            // 
            this.txtLogBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogBox.Location = new System.Drawing.Point(3, 3);
            this.txtLogBox.Multiline = true;
            this.txtLogBox.Name = "txtLogBox";
            this.txtLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogBox.Size = new System.Drawing.Size(520, 357);
            this.txtLogBox.TabIndex = 15;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 446);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(536, 22);
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
            this.btnClearLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearLogs.Location = new System.Drawing.Point(381, 365);
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new System.Drawing.Size(142, 25);
            this.btnClearLogs.TabIndex = 23;
            this.btnClearLogs.Text = "Clear Logs";
            this.btnClearLogs.UseVisualStyleBackColor = true;
            this.btnClearLogs.Click += new System.EventHandler(this.btnClearLogs_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(536, 24);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(536, 422);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstActivePrs);
            this.tabPage1.Controls.Add(this.btnMarkReviewed);
            this.tabPage1.Controls.Add(this.btnFetchPrs);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(528, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Needs Review";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstReviewedPrs);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(528, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reviewed";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnExportLogs);
            this.tabPage3.Controls.Add(this.btnClearLogs);
            this.tabPage3.Controls.Add(this.txtLogBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(528, 394);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Logs";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnExportLogs
            // 
            this.btnExportLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportLogs.Location = new System.Drawing.Point(233, 365);
            this.btnExportLogs.Name = "btnExportLogs";
            this.btnExportLogs.Size = new System.Drawing.Size(142, 25);
            this.btnExportLogs.TabIndex = 24;
            this.btnExportLogs.Text = "Export Logs";
            this.btnExportLogs.UseVisualStyleBackColor = true;
            this.btnExportLogs.Click += new System.EventHandler(this.btnExportLogs_Click);
            // 
            // dlgExportLogs
            // 
            this.dlgExportLogs.DefaultExt = "txt";
            this.dlgExportLogs.FileName = "prstat-log-export.txt";
            this.dlgExportLogs.Filter = "Text Files|*.txt";
            this.dlgExportLogs.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgExportLogs_FileOk);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutPrStatToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutPrStatToolStripMenuItem
            // 
            this.aboutPrStatToolStripMenuItem.Name = "aboutPrStatToolStripMenuItem";
            this.aboutPrStatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutPrStatToolStripMenuItem.Text = "&About PrStat";
            this.aboutPrStatToolStripMenuItem.Click += new System.EventHandler(this.aboutPrStatToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 468);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "PrStat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMarkReviewed;
        private System.Windows.Forms.TextBox txtLogBox;
        private System.Windows.Forms.Button btnFetchPrs;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListBox lstActivePrs;
        private System.Windows.Forms.ListBox lstReviewedPrs;
        private System.Windows.Forms.ToolStripStatusLabel lblVersion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnClearLogs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSettings;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnExportLogs;
        private System.Windows.Forms.SaveFileDialog dlgExportLogs;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutPrStatToolStripMenuItem;
    }
}
