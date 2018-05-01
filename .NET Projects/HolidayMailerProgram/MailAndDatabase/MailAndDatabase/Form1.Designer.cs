namespace MailAndDatabase
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MessageContentsBox = new System.Windows.Forms.RichTextBox();
            this.EmailContentBoxLabel = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setReturnAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.MessageFilterBox = new System.Windows.Forms.ComboBox();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AttachFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ExitButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageContentsBox
            // 
            this.MessageContentsBox.AcceptsTab = true;
            this.MessageContentsBox.Enabled = false;
            this.MessageContentsBox.Location = new System.Drawing.Point(45, 221);
            this.MessageContentsBox.Name = "MessageContentsBox";
            this.MessageContentsBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.MessageContentsBox.Size = new System.Drawing.Size(640, 358);
            this.MessageContentsBox.TabIndex = 1;
            this.MessageContentsBox.Text = "";
            this.MessageContentsBox.TextChanged += new System.EventHandler(this.MessageContentsBox_TextChanged);
            // 
            // EmailContentBoxLabel
            // 
            this.EmailContentBoxLabel.AutoSize = true;
            this.EmailContentBoxLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailContentBoxLabel.Location = new System.Drawing.Point(41, 197);
            this.EmailContentBoxLabel.Name = "EmailContentBoxLabel";
            this.EmailContentBoxLabel.Size = new System.Drawing.Size(115, 21);
            this.EmailContentBoxLabel.TabIndex = 2;
            this.EmailContentBoxLabel.Text = "Email Content";
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.LawnGreen;
            this.SendButton.Enabled = false;
            this.SendButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(691, 221);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(168, 35);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1122, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setReturnAddressToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // setReturnAddressToolStripMenuItem
            // 
            this.setReturnAddressToolStripMenuItem.Name = "setReturnAddressToolStripMenuItem";
            this.setReturnAddressToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.setReturnAddressToolStripMenuItem.Text = "&Set Return Address";
            this.setReturnAddressToolStripMenuItem.Click += new System.EventHandler(this.setReturnAddressToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToDatabaseToolStripMenuItem,
            this.queryDatabaseToolStripMenuItem,
            this.clearDatabaseToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "&Database";
            // 
            // addToDatabaseToolStripMenuItem
            // 
            this.addToDatabaseToolStripMenuItem.Name = "addToDatabaseToolStripMenuItem";
            this.addToDatabaseToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.addToDatabaseToolStripMenuItem.Text = "&Add To Database";
            this.addToDatabaseToolStripMenuItem.Click += new System.EventHandler(this.addToDatabaseToolStripMenuItem_Click);
            // 
            // queryDatabaseToolStripMenuItem
            // 
            this.queryDatabaseToolStripMenuItem.Name = "queryDatabaseToolStripMenuItem";
            this.queryDatabaseToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.queryDatabaseToolStripMenuItem.Text = "&Query Database";
            this.queryDatabaseToolStripMenuItem.Click += new System.EventHandler(this.queryDatabaseToolStripMenuItem_Click);
            // 
            // clearDatabaseToolStripMenuItem
            // 
            this.clearDatabaseToolStripMenuItem.Name = "clearDatabaseToolStripMenuItem";
            this.clearDatabaseToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.clearDatabaseToolStripMenuItem.Text = "&Clear Database";
            this.clearDatabaseToolStripMenuItem.Click += new System.EventHandler(this.clearDatabaseToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "What category of people do you wish to send this message to? Select from the list" +
    ", and click on your choice";
            // 
            // MessageFilterBox
            // 
            this.MessageFilterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MessageFilterBox.Enabled = false;
            this.MessageFilterBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageFilterBox.FormattingEnabled = true;
            this.MessageFilterBox.Items.AddRange(new object[] {
            "Everyone",
            "Friend",
            "Family",
            "Co-Worker",
            "Boss",
            "Acquaintance",
            "Custom (WILL OPEN CUSTOM FILTER FORM)"});
            this.MessageFilterBox.Location = new System.Drawing.Point(45, 104);
            this.MessageFilterBox.Name = "MessageFilterBox";
            this.MessageFilterBox.Size = new System.Drawing.Size(640, 27);
            this.MessageFilterBox.TabIndex = 9;
            this.MessageFilterBox.SelectedIndexChanged += new System.EventHandler(this.MessageFilterBox_SelectedIndexChanged);
            // 
            // subjectBox
            // 
            this.subjectBox.Enabled = false;
            this.subjectBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectBox.Location = new System.Drawing.Point(45, 168);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(640, 26);
            this.subjectBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(41, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Please set your return address before continuing";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(415, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgramDetailsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // ProgramDetailsToolStripMenuItem
            // 
            this.ProgramDetailsToolStripMenuItem.Name = "ProgramDetailsToolStripMenuItem";
            this.ProgramDetailsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ProgramDetailsToolStripMenuItem.Text = "&Program Details";
            this.ProgramDetailsToolStripMenuItem.Click += new System.EventHandler(this.ProgramDetailsToolStripMenuItem_Click);
            // 
            // AttachFileButton
            // 
            this.AttachFileButton.BackColor = System.Drawing.Color.Gold;
            this.AttachFileButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttachFileButton.Location = new System.Drawing.Point(691, 262);
            this.AttachFileButton.Name = "AttachFileButton";
            this.AttachFileButton.Size = new System.Drawing.Size(168, 35);
            this.AttachFileButton.TabIndex = 14;
            this.AttachFileButton.Text = "Attach File";
            this.AttachFileButton.UseVisualStyleBackColor = false;
            this.AttachFileButton.Click += new System.EventHandler(this.AttachFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Black;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(691, 303);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(168, 40);
            this.ExitButton.TabIndex = 15;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 729);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AttachFileButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subjectBox);
            this.Controls.Add(this.MessageFilterBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.EmailContentBoxLabel);
            this.Controls.Add(this.MessageContentsBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Holiday Mailer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MessageContentsBox;
        private System.Windows.Forms.Label EmailContentBoxLabel;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setReturnAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MessageFilterBox;
        private System.Windows.Forms.ToolStripMenuItem clearDatabaseToolStripMenuItem;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProgramDetailsToolStripMenuItem;
        private System.Windows.Forms.Button AttachFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ExitButton;
    }
}

