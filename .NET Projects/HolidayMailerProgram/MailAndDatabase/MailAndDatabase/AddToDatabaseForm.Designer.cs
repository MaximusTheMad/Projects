namespace MailAndDatabase
{
    partial class AddToDatabaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToDatabaseForm));
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.previousSenderBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.customCategoryBox = new System.Windows.Forms.TextBox();
            this.SubmitEmailButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categoryBox
            // 
            this.categoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Acquaintance",
            "Boss",
            "Co-Worker",
            "Custom",
            "Family",
            "Friend"});
            this.categoryBox.Location = new System.Drawing.Point(12, 240);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(184, 27);
            this.categoryBox.TabIndex = 0;
            this.categoryBox.SelectedIndexChanged += new System.EventHandler(this.categoryBox_SelectedIndexChanged);
            // 
            // lastNameBox
            // 
            this.lastNameBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameBox.Location = new System.Drawing.Point(13, 58);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(276, 26);
            this.lastNameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameBox.Location = new System.Drawing.Point(12, 119);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(276, 26);
            this.firstNameBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name";
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(12, 182);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(520, 26);
            this.emailBox.TabIndex = 6;
            this.emailBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.emailBox_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-mail Address (if the E-mail is already in the database, it will not be added ag" +
    "ain)";
            // 
            // previousSenderBox
            // 
            this.previousSenderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.previousSenderBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousSenderBox.FormattingEnabled = true;
            this.previousSenderBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.previousSenderBox.Location = new System.Drawing.Point(12, 353);
            this.previousSenderBox.Name = "previousSenderBox";
            this.previousSenderBox.Size = new System.Drawing.Size(99, 27);
            this.previousSenderBox.TabIndex = 8;
            this.previousSenderBox.SelectedIndexChanged += new System.EventHandler(this.previousSenderBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Has this person sent you a Holiday Message before?";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.LawnGreen;
            this.SubmitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(13, 416);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(118, 40);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(13, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Custom Category";
            // 
            // customCategoryBox
            // 
            this.customCategoryBox.Enabled = false;
            this.customCategoryBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customCategoryBox.Location = new System.Drawing.Point(13, 297);
            this.customCategoryBox.Name = "customCategoryBox";
            this.customCategoryBox.Size = new System.Drawing.Size(520, 26);
            this.customCategoryBox.TabIndex = 13;
            this.customCategoryBox.TextChanged += new System.EventHandler(this.customCategory_TextChanged);
            // 
            // SubmitEmailButton
            // 
            this.SubmitEmailButton.BackColor = System.Drawing.Color.LawnGreen;
            this.SubmitEmailButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitEmailButton.Location = new System.Drawing.Point(538, 182);
            this.SubmitEmailButton.Name = "SubmitEmailButton";
            this.SubmitEmailButton.Size = new System.Drawing.Size(72, 26);
            this.SubmitEmailButton.TabIndex = 14;
            this.SubmitEmailButton.Text = "Submit";
            this.SubmitEmailButton.UseVisualStyleBackColor = false;
            this.SubmitEmailButton.Click += new System.EventHandler(this.SubmitEmailButton_Click);
            // 
            // AddToDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(625, 522);
            this.Controls.Add(this.SubmitEmailButton);
            this.Controls.Add(this.customCategoryBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.previousSenderBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.categoryBox);
            this.Name = "AddToDatabaseForm";
            this.Text = "Add To Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddToDatabaseForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox previousSenderBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customCategoryBox;
        private System.Windows.Forms.Button SubmitEmailButton;
    }
}