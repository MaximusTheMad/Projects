namespace MailAndDatabase
{
    partial class SetReturnAddressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetReturnAddressForm));
            this.addressText = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.EmailServiceSelector = new System.Windows.Forms.Label();
            this.CustomSMTPBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SubmitEmail = new System.Windows.Forms.Button();
            this.SubmitSMTPButton = new System.Windows.Forms.Button();
            this.EmailServerList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomServer = new System.Windows.Forms.TextBox();
            this.SubmitServerButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addressText
            // 
            this.addressText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressText.Location = new System.Drawing.Point(16, 60);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(452, 26);
            this.addressText.TabIndex = 0;
            this.addressText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressText_KeyDown);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(12, 38);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(239, 19);
            this.AddressLabel.TabIndex = 1;
            this.AddressLabel.Text = "Enter your E-mail Address to continue";
            // 
            // EmailServiceSelector
            // 
            this.EmailServiceSelector.AutoSize = true;
            this.EmailServiceSelector.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailServiceSelector.Location = new System.Drawing.Point(13, 101);
            this.EmailServiceSelector.Name = "EmailServiceSelector";
            this.EmailServiceSelector.Size = new System.Drawing.Size(304, 15);
            this.EmailServiceSelector.TabIndex = 3;
            this.EmailServiceSelector.Text = "Please select your e-mail provider from the list and click on it.";
            // 
            // CustomSMTPBox
            // 
            this.CustomSMTPBox.Enabled = false;
            this.CustomSMTPBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomSMTPBox.Location = new System.Drawing.Point(16, 207);
            this.CustomSMTPBox.Name = "CustomSMTPBox";
            this.CustomSMTPBox.Size = new System.Drawing.Size(100, 26);
            this.CustomSMTPBox.TabIndex = 4;
            this.CustomSMTPBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomSMTPBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Custom SMTP Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username";
            // 
            // usernameBox
            // 
            this.usernameBox.Enabled = false;
            this.usernameBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(16, 273);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(307, 26);
            this.usernameBox.TabIndex = 7;
            // 
            // passwordBox
            // 
            this.passwordBox.Enabled = false;
            this.passwordBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(16, 333);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(307, 26);
            this.passwordBox.TabIndex = 8;
            this.passwordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.LawnGreen;
            this.SubmitButton.Enabled = false;
            this.SubmitButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(16, 365);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(187, 35);
            this.SubmitButton.TabIndex = 11;
            this.SubmitButton.Text = "Submit Username and Password";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(458, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "If you don\'t see it on this list, select custom and enter the SMTP port it uses i" +
    "n the box below";
            // 
            // SubmitEmail
            // 
            this.SubmitEmail.BackColor = System.Drawing.Color.Black;
            this.SubmitEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitEmail.ForeColor = System.Drawing.Color.White;
            this.SubmitEmail.Location = new System.Drawing.Point(474, 59);
            this.SubmitEmail.Name = "SubmitEmail";
            this.SubmitEmail.Size = new System.Drawing.Size(75, 26);
            this.SubmitEmail.TabIndex = 13;
            this.SubmitEmail.Text = "Submit";
            this.SubmitEmail.UseVisualStyleBackColor = false;
            this.SubmitEmail.Click += new System.EventHandler(this.SubmitEmail_Click);
            // 
            // SubmitSMTPButton
            // 
            this.SubmitSMTPButton.BackColor = System.Drawing.Color.White;
            this.SubmitSMTPButton.Enabled = false;
            this.SubmitSMTPButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitSMTPButton.ForeColor = System.Drawing.Color.Black;
            this.SubmitSMTPButton.Location = new System.Drawing.Point(122, 206);
            this.SubmitSMTPButton.Name = "SubmitSMTPButton";
            this.SubmitSMTPButton.Size = new System.Drawing.Size(81, 27);
            this.SubmitSMTPButton.TabIndex = 14;
            this.SubmitSMTPButton.Text = "Submit";
            this.SubmitSMTPButton.UseVisualStyleBackColor = false;
            this.SubmitSMTPButton.Click += new System.EventHandler(this.SubmitSMTP_Click);
            // 
            // EmailServerList
            // 
            this.EmailServerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmailServerList.Enabled = false;
            this.EmailServerList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailServerList.FormattingEnabled = true;
            this.EmailServerList.Items.AddRange(new object[] {
            "1&1(1and1) {smtp.1and1.com}",
            "1&1 Deutschland {smtp.1und1.de}",
            "AOL.com {smtp.aol.com}",
            "AT&T {smtp.att.yahoo.com}",
            "BT Connect {pop3.btconnect.com}",
            "BT Internet {mail.btinternet.com}",
            "BT Openworld {mail.btopenworld.com}",
            "Comcast {smtp.comcast.net}",
            "Custom (You\'ll need to add your STMP Port)",
            "Gmail {smtp.gmail.com}(You\'ll need to enable less secure apps in your Gmail setti" +
                "ngs)",
            "GMX.com {smtp.gmx.com}",
            "Hotmail {smtp.live.com}",
            "Mail.com {smtp.mail.com}",
            "NTL @ntlworld.com {smtp.ntlworld.com}",
            "O2 {smtp.o2.ie}",
            "O2 Online Deutschland {mail.o2online.de}",
            "O2.uk {smtp.o2.co.uk}",
            "Office365.com {smtp.office365.com} (go to the \"Settings\" > \"Options\" > \"Account\" " +
                "> \"My Account\" > \"Settings for POP and IMAP Access\".)",
            "Orange {smtp.orange.net}",
            "Orange.uk {smtp.orange.co.uk}",
            "Outlook.com {smtp.live.com}",
            "T-Online Deustchland {securesmtp.t-online.de}",
            "Verizon {outgoing.verizon.net}",
            "Verizon (Yahoo hosted) {outgoing.yahoo.verizon.net}",
            "Wanadoo UK {smtp.wanadoo.co.uk}",
            "Yahoo AU/NZ {smtp.mail.yahoo.com.au}",
            "Yahoo Deutschland {smtp.mail.yahoo.com}",
            "Yahoo Mail {smtp.mail.yahoo.com}",
            "Yahoo Mail Plus {plus.smtp.mail.yahoo.com}",
            "Yahoo UK {smtp.mail.yahoo.co.uk}",
            "zoho Mail {smtp.zoho.com}"});
            this.EmailServerList.Location = new System.Drawing.Point(16, 135);
            this.EmailServerList.Name = "EmailServerList";
            this.EmailServerList.Size = new System.Drawing.Size(1065, 27);
            this.EmailServerList.TabIndex = 15;
            this.EmailServerList.SelectedIndexChanged += new System.EventHandler(this.EmailServerList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(238, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Custom SMTP Server";
            // 
            // CustomServer
            // 
            this.CustomServer.Enabled = false;
            this.CustomServer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomServer.Location = new System.Drawing.Point(242, 206);
            this.CustomServer.Name = "CustomServer";
            this.CustomServer.Size = new System.Drawing.Size(286, 26);
            this.CustomServer.TabIndex = 17;
            this.CustomServer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomServer_KeyDown);
            // 
            // SubmitServerButton
            // 
            this.SubmitServerButton.BackColor = System.Drawing.Color.White;
            this.SubmitServerButton.Enabled = false;
            this.SubmitServerButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitServerButton.ForeColor = System.Drawing.Color.Black;
            this.SubmitServerButton.Location = new System.Drawing.Point(534, 206);
            this.SubmitServerButton.Name = "SubmitServerButton";
            this.SubmitServerButton.Size = new System.Drawing.Size(81, 27);
            this.SubmitServerButton.TabIndex = 18;
            this.SubmitServerButton.Text = "Submit";
            this.SubmitServerButton.UseVisualStyleBackColor = false;
            this.SubmitServerButton.Click += new System.EventHandler(this.SubmitServerButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.White;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Location = new System.Drawing.Point(16, 445);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 45);
            this.ExitButton.TabIndex = 19;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SetReturnAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1104, 502);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SubmitServerButton);
            this.Controls.Add(this.CustomServer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmailServerList);
            this.Controls.Add(this.SubmitSMTPButton);
            this.Controls.Add(this.SubmitEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomSMTPBox);
            this.Controls.Add(this.EmailServiceSelector);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.addressText);
            this.Name = "SetReturnAddressForm";
            this.Text = "Set Return Address";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetReturnAddressForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label EmailServiceSelector;
        private System.Windows.Forms.TextBox CustomSMTPBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SubmitEmail;
        private System.Windows.Forms.Button SubmitSMTPButton;
        private System.Windows.Forms.ComboBox EmailServerList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CustomServer;
        private System.Windows.Forms.Button SubmitServerButton;
        private System.Windows.Forms.Button ExitButton;
    }
}