
namespace Report_Editor
{
    partial class MainWindow
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NewReportButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ContentBox = new System.Windows.Forms.TextBox();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.SearchIntervalBox = new System.Windows.Forms.ComboBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.TextButton = new System.Windows.Forms.RadioButton();
            this.IntervalButton = new System.Windows.Forms.RadioButton();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportIntervalLabel = new System.Windows.Forms.Label();
            this.ReportIntervalBox = new System.Windows.Forms.ComboBox();
            this.IntervalWarning = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ReportsGridView = new System.Windows.Forms.DataGridView();
            this.ReportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportTimespan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(549, 420);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(112, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete Report";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NewReportButton
            // 
            this.NewReportButton.Location = new System.Drawing.Point(431, 420);
            this.NewReportButton.Name = "NewReportButton";
            this.NewReportButton.Size = new System.Drawing.Size(112, 23);
            this.NewReportButton.TabIndex = 4;
            this.NewReportButton.Text = "New Report";
            this.NewReportButton.UseVisualStyleBackColor = true;
            this.NewReportButton.Click += new System.EventHandler(this.NewReportButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(667, 420);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(112, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save Report";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ContentBox
            // 
            this.ContentBox.Enabled = false;
            this.ContentBox.Location = new System.Drawing.Point(431, 68);
            this.ContentBox.Multiline = true;
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.Size = new System.Drawing.Size(348, 316);
            this.ContentBox.TabIndex = 6;
            this.ContentBox.TextChanged += new System.EventHandler(this.ContentBox_TextChanged);
            // 
            // DateBox
            // 
            this.DateBox.Enabled = false;
            this.DateBox.Location = new System.Drawing.Point(502, 45);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(106, 20);
            this.DateBox.TabIndex = 8;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(428, 48);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(68, 13);
            this.DateLabel.TabIndex = 9;
            this.DateLabel.Text = "Report Date:";
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(546, 450);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(102, 13);
            this.WarningLabel.TabIndex = 10;
            this.WarningLabel.Text = "Changes not saved!";
            this.WarningLabel.Visible = false;
            // 
            // SearchIntervalBox
            // 
            this.SearchIntervalBox.FormattingEnabled = true;
            this.SearchIntervalBox.Items.AddRange(new object[] {
            "All",
            "Daily",
            "Weekly",
            "Monthly",
            "Quarterly",
            "Yearly"});
            this.SearchIntervalBox.Location = new System.Drawing.Point(267, 41);
            this.SearchIntervalBox.Name = "SearchIntervalBox";
            this.SearchIntervalBox.Size = new System.Drawing.Size(77, 21);
            this.SearchIntervalBox.TabIndex = 12;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Enabled = false;
            this.SearchTextBox.Location = new System.Drawing.Point(68, 41);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchTextBox.TabIndex = 14;
            // 
            // TextButton
            // 
            this.TextButton.AutoSize = true;
            this.TextButton.Location = new System.Drawing.Point(13, 42);
            this.TextButton.Name = "TextButton";
            this.TextButton.Size = new System.Drawing.Size(49, 17);
            this.TextButton.TabIndex = 16;
            this.TextButton.Text = "Text:";
            this.TextButton.UseVisualStyleBackColor = true;
            this.TextButton.CheckedChanged += new System.EventHandler(this.TextButton_CheckedChanged);
            // 
            // IntervalButton
            // 
            this.IntervalButton.AutoSize = true;
            this.IntervalButton.Checked = true;
            this.IntervalButton.Location = new System.Drawing.Point(174, 42);
            this.IntervalButton.Name = "IntervalButton";
            this.IntervalButton.Size = new System.Drawing.Size(87, 17);
            this.IntervalButton.TabIndex = 17;
            this.IntervalButton.TabStop = true;
            this.IntervalButton.Text = "Report Type:";
            this.IntervalButton.UseVisualStyleBackColor = true;
            this.IntervalButton.CheckedChanged += new System.EventHandler(this.IntervalButton_CheckedChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(91, 23);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(93, 13);
            this.SearchLabel.TabIndex = 18;
            this.SearchLabel.Text = "Search reports by:";
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(785, 24);
            this.MainMenuStrip.TabIndex = 19;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ReportIntervalLabel
            // 
            this.ReportIntervalLabel.AutoSize = true;
            this.ReportIntervalLabel.Location = new System.Drawing.Point(614, 48);
            this.ReportIntervalLabel.Name = "ReportIntervalLabel";
            this.ReportIntervalLabel.Size = new System.Drawing.Size(69, 13);
            this.ReportIntervalLabel.TabIndex = 20;
            this.ReportIntervalLabel.Text = "Report Type:";
            // 
            // ReportIntervalBox
            // 
            this.ReportIntervalBox.Enabled = false;
            this.ReportIntervalBox.FormattingEnabled = true;
            this.ReportIntervalBox.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "Quarterly",
            "Yearly"});
            this.ReportIntervalBox.Location = new System.Drawing.Point(689, 44);
            this.ReportIntervalBox.Name = "ReportIntervalBox";
            this.ReportIntervalBox.Size = new System.Drawing.Size(90, 21);
            this.ReportIntervalBox.TabIndex = 21;
            this.ReportIntervalBox.SelectedIndexChanged += new System.EventHandler(this.ReportIntervalBox_SelectedIndexChanged);
            // 
            // IntervalWarning
            // 
            this.IntervalWarning.AutoSize = true;
            this.IntervalWarning.ForeColor = System.Drawing.Color.Red;
            this.IntervalWarning.Location = new System.Drawing.Point(667, 450);
            this.IntervalWarning.Name = "IntervalWarning";
            this.IntervalWarning.Size = new System.Drawing.Size(102, 13);
            this.IntervalWarning.TabIndex = 22;
            this.IntervalWarning.Text = "Select a report type.";
            this.IntervalWarning.Visible = false;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(350, 40);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 21);
            this.SearchButton.TabIndex = 23;
            this.SearchButton.Text = "Run Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.Location = new System.Drawing.Point(355, 449);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(132, 13);
            this.CopyrightLabel.TabIndex = 24;
            this.CopyrightLabel.Text = "© 2021 Shabel Group Inc.";
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            this.EditButton.Location = new System.Drawing.Point(549, 391);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(112, 23);
            this.EditButton.TabIndex = 25;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Enabled = false;
            this.CancelButton.Location = new System.Drawing.Point(668, 391);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(111, 23);
            this.CancelButton.TabIndex = 26;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ReportsGridView
            // 
            this.ReportsGridView.AllowUserToAddRows = false;
            this.ReportsGridView.AllowUserToDeleteRows = false;
            this.ReportsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReportID,
            this.ReportDate,
            this.ReportTimespan,
            this.ReportContent});
            this.ReportsGridView.Location = new System.Drawing.Point(13, 68);
            this.ReportsGridView.MultiSelect = false;
            this.ReportsGridView.Name = "ReportsGridView";
            this.ReportsGridView.ReadOnly = true;
            this.ReportsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReportsGridView.Size = new System.Drawing.Size(412, 375);
            this.ReportsGridView.TabIndex = 27;
            this.ReportsGridView.SelectionChanged += new System.EventHandler(this.ReportsGridView_SelectionChanged);
            // 
            // ReportID
            // 
            this.ReportID.HeaderText = "ID";
            this.ReportID.Name = "ReportID";
            this.ReportID.ReadOnly = true;
            this.ReportID.Visible = false;
            // 
            // ReportDate
            // 
            this.ReportDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ReportDate.HeaderText = "Report Date";
            this.ReportDate.Name = "ReportDate";
            this.ReportDate.ReadOnly = true;
            this.ReportDate.Width = 90;
            // 
            // ReportTimespan
            // 
            this.ReportTimespan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ReportTimespan.HeaderText = "Report Type";
            this.ReportTimespan.Name = "ReportTimespan";
            this.ReportTimespan.ReadOnly = true;
            this.ReportTimespan.Width = 89;
            // 
            // ReportContent
            // 
            this.ReportContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReportContent.HeaderText = "Report Details";
            this.ReportContent.Name = "ReportContent";
            this.ReportContent.ReadOnly = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 471);
            this.Controls.Add(this.ReportsGridView);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.IntervalWarning);
            this.Controls.Add(this.ReportIntervalBox);
            this.Controls.Add(this.ReportIntervalLabel);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.IntervalButton);
            this.Controls.Add(this.TextButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchIntervalBox);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.ContentBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NewReportButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.MainMenuStrip);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shabel Group Inc. Content Management System";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button NewReportButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox ContentBox;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.ComboBox SearchIntervalBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.RadioButton TextButton;
        private System.Windows.Forms.RadioButton IntervalButton;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label ReportIntervalLabel;
        private System.Windows.Forms.ComboBox ReportIntervalBox;
        private System.Windows.Forms.Label IntervalWarning;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label CopyrightLabel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.DataGridView ReportsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportTimespan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportContent;
    }
}

