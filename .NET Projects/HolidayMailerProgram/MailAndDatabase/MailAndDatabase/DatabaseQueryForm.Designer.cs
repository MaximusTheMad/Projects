namespace MailAndDatabase
{
    partial class DatabaseQueryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseQueryForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchBy = new System.Windows.Forms.GroupBox();
            this.FirstInitial = new System.Windows.Forms.RadioButton();
            this.LastInitial = new System.Windows.Forms.RadioButton();
            this.NoPreviousSenders = new System.Windows.Forms.RadioButton();
            this.PreviousSenders = new System.Windows.Forms.RadioButton();
            this.Category = new System.Windows.Forms.RadioButton();
            this.EmailDomain = new System.Windows.Forms.RadioButton();
            this.FirstName = new System.Windows.Forms.RadioButton();
            this.ByLastName = new System.Windows.Forms.RadioButton();
            this.Everyone = new System.Windows.Forms.RadioButton();
            this.SearchFilterBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SearchBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(922, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // SearchBy
            // 
            this.SearchBy.BackColor = System.Drawing.Color.White;
            this.SearchBy.Controls.Add(this.FirstInitial);
            this.SearchBy.Controls.Add(this.LastInitial);
            this.SearchBy.Controls.Add(this.NoPreviousSenders);
            this.SearchBy.Controls.Add(this.PreviousSenders);
            this.SearchBy.Controls.Add(this.Category);
            this.SearchBy.Controls.Add(this.EmailDomain);
            this.SearchBy.Controls.Add(this.FirstName);
            this.SearchBy.Controls.Add(this.ByLastName);
            this.SearchBy.Controls.Add(this.Everyone);
            this.SearchBy.Location = new System.Drawing.Point(13, 13);
            this.SearchBy.Name = "SearchBy";
            this.SearchBy.Size = new System.Drawing.Size(459, 142);
            this.SearchBy.TabIndex = 1;
            this.SearchBy.TabStop = false;
            this.SearchBy.Text = "Search Filters";
            // 
            // FirstInitial
            // 
            this.FirstInitial.AutoSize = true;
            this.FirstInitial.Location = new System.Drawing.Point(7, 115);
            this.FirstInitial.Name = "FirstInitial";
            this.FirstInitial.Size = new System.Drawing.Size(86, 17);
            this.FirstInitial.TabIndex = 8;
            this.FirstInitial.TabStop = true;
            this.FirstInitial.Text = "By First Initial";
            this.FirstInitial.UseVisualStyleBackColor = true;
            this.FirstInitial.Click += new System.EventHandler(this.FirstInitial_Click);
            // 
            // LastInitial
            // 
            this.LastInitial.AutoSize = true;
            this.LastInitial.Location = new System.Drawing.Point(7, 68);
            this.LastInitial.Name = "LastInitial";
            this.LastInitial.Size = new System.Drawing.Size(87, 17);
            this.LastInitial.TabIndex = 7;
            this.LastInitial.TabStop = true;
            this.LastInitial.Text = "By Last Initial";
            this.LastInitial.UseVisualStyleBackColor = true;
            this.LastInitial.Click += new System.EventHandler(this.LastInitial_Click);
            // 
            // NoPreviousSenders
            // 
            this.NoPreviousSenders.AutoSize = true;
            this.NoPreviousSenders.Location = new System.Drawing.Point(131, 44);
            this.NoPreviousSenders.Name = "NoPreviousSenders";
            this.NoPreviousSenders.Size = new System.Drawing.Size(256, 17);
            this.NoPreviousSenders.TabIndex = 6;
            this.NoPreviousSenders.TabStop = true;
            this.NoPreviousSenders.Text = "People who have not sent you a message before";
            this.NoPreviousSenders.UseVisualStyleBackColor = true;
            this.NoPreviousSenders.Click += new System.EventHandler(this.NoPreviousSenders_Click);
            // 
            // PreviousSenders
            // 
            this.PreviousSenders.AutoSize = true;
            this.PreviousSenders.Location = new System.Drawing.Point(131, 20);
            this.PreviousSenders.Name = "PreviousSenders";
            this.PreviousSenders.Size = new System.Drawing.Size(238, 17);
            this.PreviousSenders.TabIndex = 5;
            this.PreviousSenders.TabStop = true;
            this.PreviousSenders.Text = "People who have sent you a message before";
            this.PreviousSenders.UseVisualStyleBackColor = true;
            this.PreviousSenders.Click += new System.EventHandler(this.PreviousSenders_Click);
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(131, 91);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(82, 17);
            this.Category.TabIndex = 4;
            this.Category.TabStop = true;
            this.Category.Text = "By Category";
            this.Category.UseVisualStyleBackColor = true;
            this.Category.Click += new System.EventHandler(this.Category_Click);
            // 
            // EmailDomain
            // 
            this.EmailDomain.AutoSize = true;
            this.EmailDomain.Location = new System.Drawing.Point(131, 68);
            this.EmailDomain.Name = "EmailDomain";
            this.EmailDomain.Size = new System.Drawing.Size(180, 17);
            this.EmailDomain.TabIndex = 3;
            this.EmailDomain.TabStop = true;
            this.EmailDomain.Text = "By E-mail Domain (ex: gmail.com)";
            this.EmailDomain.UseVisualStyleBackColor = true;
            this.EmailDomain.Click += new System.EventHandler(this.EmailDomain_Click);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(7, 91);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(90, 17);
            this.FirstName.TabIndex = 2;
            this.FirstName.TabStop = true;
            this.FirstName.Text = "By First Name";
            this.FirstName.UseVisualStyleBackColor = true;
            this.FirstName.Click += new System.EventHandler(this.FirstName_Click);
            // 
            // ByLastName
            // 
            this.ByLastName.AutoSize = true;
            this.ByLastName.Location = new System.Drawing.Point(7, 44);
            this.ByLastName.Name = "ByLastName";
            this.ByLastName.Size = new System.Drawing.Size(91, 17);
            this.ByLastName.TabIndex = 1;
            this.ByLastName.TabStop = true;
            this.ByLastName.Text = "By Last Name";
            this.ByLastName.UseVisualStyleBackColor = true;
            this.ByLastName.Click += new System.EventHandler(this.ByLastName_Click);
            // 
            // Everyone
            // 
            this.Everyone.AutoSize = true;
            this.Everyone.Location = new System.Drawing.Point(7, 20);
            this.Everyone.Name = "Everyone";
            this.Everyone.Size = new System.Drawing.Size(70, 17);
            this.Everyone.TabIndex = 0;
            this.Everyone.TabStop = true;
            this.Everyone.Text = "Everyone";
            this.Everyone.UseVisualStyleBackColor = true;
            this.Everyone.Click += new System.EventHandler(this.Everyone_Click);
            // 
            // SearchFilterBox
            // 
            this.SearchFilterBox.Enabled = false;
            this.SearchFilterBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFilterBox.Location = new System.Drawing.Point(12, 213);
            this.SearchFilterBox.Multiline = true;
            this.SearchFilterBox.Name = "SearchFilterBox";
            this.SearchFilterBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SearchFilterBox.Size = new System.Drawing.Size(914, 96);
            this.SearchFilterBox.TabIndex = 2;
            this.SearchFilterBox.TextChanged += new System.EventHandler(this.SearchFilterBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter (One Value Per Line)";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.LawnGreen;
            this.SubmitButton.Enabled = false;
            this.SubmitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(478, 20);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(118, 40);
            this.SubmitButton.TabIndex = 11;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // DatabaseQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(947, 636);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchFilterBox);
            this.Controls.Add(this.SearchBy);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DatabaseQueryForm";
            this.Text = "DatabaseQueryForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DatabaseQueryForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.SearchBy.ResumeLayout(false);
            this.SearchBy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox SearchBy;
        private System.Windows.Forms.RadioButton PreviousSenders;
        private System.Windows.Forms.RadioButton Category;
        private System.Windows.Forms.RadioButton EmailDomain;
        private System.Windows.Forms.RadioButton FirstName;
        private System.Windows.Forms.RadioButton ByLastName;
        private System.Windows.Forms.RadioButton Everyone;
        private System.Windows.Forms.RadioButton LastInitial;
        private System.Windows.Forms.RadioButton NoPreviousSenders;
        private System.Windows.Forms.RadioButton FirstInitial;
        private System.Windows.Forms.TextBox SearchFilterBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitButton;
    }
}