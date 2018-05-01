namespace FileSystemWatcher
{
    partial class FileSystemWatcherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileSystemWatcherForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startWatchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopWatchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.StartMonitoring = new System.Windows.Forms.ToolStripButton();
            this.StopWatching = new System.Windows.Forms.ToolStripButton();
            this.SaveToDatabase = new System.Windows.Forms.ToolStripButton();
            this.QueryDatabaseButton = new System.Windows.Forms.ToolStripButton();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.FilterSetter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DirectoryPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DisplayLog = new System.Windows.Forms.TextBox();
            this.SubmitPath = new System.Windows.Forms.Button();
            this.SubmitFilter = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startWatchingToolStripMenuItem,
            this.stopWatchingToolStripMenuItem,
            this.ToolStripExitButton});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // startWatchingToolStripMenuItem
            // 
            this.startWatchingToolStripMenuItem.Name = "startWatchingToolStripMenuItem";
            this.startWatchingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startWatchingToolStripMenuItem.Text = "Start Watching";
            this.startWatchingToolStripMenuItem.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // stopWatchingToolStripMenuItem
            // 
            this.stopWatchingToolStripMenuItem.Name = "stopWatchingToolStripMenuItem";
            this.stopWatchingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stopWatchingToolStripMenuItem.Text = "Stop Watching";
            this.stopWatchingToolStripMenuItem.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ToolStripExitButton
            // 
            this.ToolStripExitButton.Name = "ToolStripExitButton";
            this.ToolStripExitButton.Size = new System.Drawing.Size(152, 22);
            this.ToolStripExitButton.Text = "Exit";
            this.ToolStripExitButton.Click += new System.EventHandler(this.ToolStripExitButton_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToDatabaseToolStripMenuItem,
            this.viewDatabaseToolStripMenuItem,
            this.deleteDataToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "&Database";
            // 
            // saveToDatabaseToolStripMenuItem
            // 
            this.saveToDatabaseToolStripMenuItem.Name = "saveToDatabaseToolStripMenuItem";
            this.saveToDatabaseToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.saveToDatabaseToolStripMenuItem.Text = "&Save To Database";
            this.saveToDatabaseToolStripMenuItem.Click += new System.EventHandler(this.DatabaseSave_Click);
            // 
            // viewDatabaseToolStripMenuItem
            // 
            this.viewDatabaseToolStripMenuItem.Name = "viewDatabaseToolStripMenuItem";
            this.viewDatabaseToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.viewDatabaseToolStripMenuItem.Text = "&Query Database";
            this.viewDatabaseToolStripMenuItem.Click += new System.EventHandler(this.QueryDatabaseButton_Click);
            // 
            // deleteDataToolStripMenuItem
            // 
            this.deleteDataToolStripMenuItem.Name = "deleteDataToolStripMenuItem";
            this.deleteDataToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.deleteDataToolStripMenuItem.Text = "&Delete Data";
            this.deleteDataToolStripMenuItem.Click += new System.EventHandler(this.deleteDataToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgramDetails});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // ProgramDetails
            // 
            this.ProgramDetails.Name = "ProgramDetails";
            this.ProgramDetails.Size = new System.Drawing.Size(158, 22);
            this.ProgramDetails.Text = "&Program Details";
            this.ProgramDetails.Click += new System.EventHandler(this.ProgramDetails_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartMonitoring,
            this.StopWatching,
            this.SaveToDatabase,
            this.QueryDatabaseButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(721, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // StartMonitoring
            // 
            this.StartMonitoring.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StartMonitoring.Image = ((System.Drawing.Image)(resources.GetObject("StartMonitoring.Image")));
            this.StartMonitoring.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StartMonitoring.Name = "StartMonitoring";
            this.StartMonitoring.Size = new System.Drawing.Size(23, 22);
            this.StartMonitoring.Text = "toolStripButton1";
            this.StartMonitoring.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.StartMonitoring.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopWatching
            // 
            this.StopWatching.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StopWatching.Image = ((System.Drawing.Image)(resources.GetObject("StopWatching.Image")));
            this.StopWatching.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopWatching.Name = "StopWatching";
            this.StopWatching.Size = new System.Drawing.Size(23, 22);
            this.StopWatching.Text = "Stop Watching";
            this.StopWatching.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // SaveToDatabase
            // 
            this.SaveToDatabase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToDatabase.Image = ((System.Drawing.Image)(resources.GetObject("SaveToDatabase.Image")));
            this.SaveToDatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToDatabase.Name = "SaveToDatabase";
            this.SaveToDatabase.Size = new System.Drawing.Size(23, 22);
            this.SaveToDatabase.Text = "Save To Database";
            this.SaveToDatabase.Click += new System.EventHandler(this.DatabaseSave_Click);
            // 
            // QueryDatabaseButton
            // 
            this.QueryDatabaseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.QueryDatabaseButton.Image = ((System.Drawing.Image)(resources.GetObject("QueryDatabaseButton.Image")));
            this.QueryDatabaseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.QueryDatabaseButton.Name = "QueryDatabaseButton";
            this.QueryDatabaseButton.Size = new System.Drawing.Size(23, 22);
            this.QueryDatabaseButton.Text = "Query Database";
            this.QueryDatabaseButton.Click += new System.EventHandler(this.QueryDatabaseButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.StartButton.Location = new System.Drawing.Point(22, 222);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(92, 35);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start Watching";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.StopButton.Location = new System.Drawing.Point(120, 222);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(92, 35);
            this.StopButton.TabIndex = 4;
            this.StopButton.Text = "Stop Watching";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // FilterSetter
            // 
            this.FilterSetter.Location = new System.Drawing.Point(22, 195);
            this.FilterSetter.Name = "FilterSetter";
            this.FilterSetter.Size = new System.Drawing.Size(116, 21);
            this.FilterSetter.TabIndex = 5;
            this.FilterSetter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterFilter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter a file extension(or don\'t to monitor all files), enter a directory, then cl" +
    "ick start to start monitoring";
            // 
            // DirectoryPath
            // 
            this.DirectoryPath.Location = new System.Drawing.Point(25, 129);
            this.DirectoryPath.Name = "DirectoryPath";
            this.DirectoryPath.Size = new System.Drawing.Size(427, 21);
            this.DirectoryPath.TabIndex = 7;
            this.DirectoryPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterPath);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "FileSystemWatcher Filter (Blank=All files monitored)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter a Directory Path, if root drive (like C:) then add a backslash(\'\\\')";
            // 
            // DisplayLog
            // 
            this.DisplayLog.Location = new System.Drawing.Point(22, 263);
            this.DisplayLog.Multiline = true;
            this.DisplayLog.Name = "DisplayLog";
            this.DisplayLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DisplayLog.Size = new System.Drawing.Size(641, 251);
            this.DisplayLog.TabIndex = 10;
            // 
            // SubmitPath
            // 
            this.SubmitPath.Location = new System.Drawing.Point(458, 127);
            this.SubmitPath.Name = "SubmitPath";
            this.SubmitPath.Size = new System.Drawing.Size(75, 23);
            this.SubmitPath.TabIndex = 11;
            this.SubmitPath.Text = "Submit";
            this.SubmitPath.UseVisualStyleBackColor = true;
            this.SubmitPath.Click += new System.EventHandler(this.SubmitPath_Click);
            // 
            // SubmitFilter
            // 
            this.SubmitFilter.Location = new System.Drawing.Point(145, 195);
            this.SubmitFilter.Name = "SubmitFilter";
            this.SubmitFilter.Size = new System.Drawing.Size(75, 23);
            this.SubmitFilter.TabIndex = 12;
            this.SubmitFilter.Text = "Submit";
            this.SubmitFilter.UseVisualStyleBackColor = true;
            this.SubmitFilter.Click += new System.EventHandler(this.SubmitFilter_Click);
            // 
            // FileSystemWatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 526);
            this.Controls.Add(this.SubmitFilter);
            this.Controls.Add(this.SubmitPath);
            this.Controls.Add(this.DisplayLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DirectoryPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilterSetter);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FileSystemWatcherForm";
            this.Text = "File System Watcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProgramDetails;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton StartMonitoring;
        private System.Windows.Forms.ToolStripButton StopWatching;
        private System.Windows.Forms.ToolStripButton SaveToDatabase;
        private System.Windows.Forms.ToolStripMenuItem viewDatabaseToolStripMenuItem;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TextBox FilterSetter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DirectoryPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DisplayLog;
        private System.Windows.Forms.ToolStripMenuItem ToolStripExitButton;
        private System.Windows.Forms.ToolStripMenuItem saveToDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startWatchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopWatchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton QueryDatabaseButton;
        private System.Windows.Forms.Button SubmitPath;
        private System.Windows.Forms.Button SubmitFilter;
        private System.Windows.Forms.ToolStripMenuItem deleteDataToolStripMenuItem;
    }
}

