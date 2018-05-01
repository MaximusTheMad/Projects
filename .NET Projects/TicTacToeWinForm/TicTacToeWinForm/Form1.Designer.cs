namespace TicTacToeWinForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesOfPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Player1Shape = new System.Windows.Forms.ToolStripStatusLabel();
            this.Player2Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.Player2Shape = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Player1WinsLabel = new System.Windows.Forms.Label();
            this.Player2WinsLabel = new System.Windows.Forms.Label();
            this.CatsGameLabel = new System.Windows.Forms.Label();
            this.PlayAgainButton = new System.Windows.Forms.Button();
            this.CurrentTurnLabel = new System.Windows.Forms.Label();
            this.CurrentPlayerTurn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Player1WinCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Player2WinCount = new System.Windows.Forms.Label();
            this.CatsGameCounterLabel = new System.Windows.Forms.Label();
            this.CatsGameCounter = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // exitGameToolStripMenuItem
            // 
            this.exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            this.exitGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitGameToolStripMenuItem.Text = "Exit Game";
            this.exitGameToolStripMenuItem.Click += new System.EventHandler(this.exitGameToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgramToolStripMenuItem,
            this.rulesOfPlayToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aboutProgramToolStripMenuItem.Text = "About Program";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // rulesOfPlayToolStripMenuItem
            // 
            this.rulesOfPlayToolStripMenuItem.Name = "rulesOfPlayToolStripMenuItem";
            this.rulesOfPlayToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.rulesOfPlayToolStripMenuItem.Text = "Rules Of Play";
            this.rulesOfPlayToolStripMenuItem.Click += new System.EventHandler(this.rulesOfPlayToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Player1Shape,
            this.Player2Label,
            this.Player2Shape});
            this.statusStrip1.Location = new System.Drawing.Point(0, 547);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(666, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(62, 21);
            this.toolStripStatusLabel1.Text = "Player 1:";
            // 
            // Player1Shape
            // 
            this.Player1Shape.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Player1Shape.Name = "Player1Shape";
            this.Player1Shape.Size = new System.Drawing.Size(19, 21);
            this.Player1Shape.Text = "X";
            // 
            // Player2Label
            // 
            this.Player2Label.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Player2Label.Margin = new System.Windows.Forms.Padding(100, 3, 0, 2);
            this.Player2Label.Name = "Player2Label";
            this.Player2Label.Size = new System.Drawing.Size(58, 21);
            this.Player2Label.Text = "Player2:";
            // 
            // Player2Shape
            // 
            this.Player2Shape.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Player2Shape.Name = "Player2Shape";
            this.Player2Shape.Size = new System.Drawing.Size(22, 21);
            this.Player2Shape.Text = "O";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(29, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 360);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // Player1WinsLabel
            // 
            this.Player1WinsLabel.AutoSize = true;
            this.Player1WinsLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1WinsLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.Player1WinsLabel.Location = new System.Drawing.Point(23, 73);
            this.Player1WinsLabel.Name = "Player1WinsLabel";
            this.Player1WinsLabel.Size = new System.Drawing.Size(223, 36);
            this.Player1WinsLabel.TabIndex = 4;
            this.Player1WinsLabel.Text = "Player 1 Wins!!!";
            this.Player1WinsLabel.Visible = false;
            // 
            // Player2WinsLabel
            // 
            this.Player2WinsLabel.AutoSize = true;
            this.Player2WinsLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2WinsLabel.ForeColor = System.Drawing.Color.Teal;
            this.Player2WinsLabel.Location = new System.Drawing.Point(23, 109);
            this.Player2WinsLabel.Name = "Player2WinsLabel";
            this.Player2WinsLabel.Size = new System.Drawing.Size(223, 36);
            this.Player2WinsLabel.TabIndex = 5;
            this.Player2WinsLabel.Text = "Player 2 Wins!!!";
            this.Player2WinsLabel.Visible = false;
            // 
            // CatsGameLabel
            // 
            this.CatsGameLabel.AutoSize = true;
            this.CatsGameLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatsGameLabel.ForeColor = System.Drawing.Color.Black;
            this.CatsGameLabel.Location = new System.Drawing.Point(23, 37);
            this.CatsGameLabel.Name = "CatsGameLabel";
            this.CatsGameLabel.Size = new System.Drawing.Size(375, 36);
            this.CatsGameLabel.TabIndex = 6;
            this.CatsGameLabel.Text = "Cat\'s Game, No One Wins!!!";
            this.CatsGameLabel.Visible = false;
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.Location = new System.Drawing.Point(395, 148);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(217, 70);
            this.PlayAgainButton.TabIndex = 7;
            this.PlayAgainButton.Text = "Play Again";
            this.PlayAgainButton.UseVisualStyleBackColor = true;
            this.PlayAgainButton.Visible = false;
            this.PlayAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // CurrentTurnLabel
            // 
            this.CurrentTurnLabel.AutoSize = true;
            this.CurrentTurnLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTurnLabel.Location = new System.Drawing.Point(395, 235);
            this.CurrentTurnLabel.Name = "CurrentTurnLabel";
            this.CurrentTurnLabel.Size = new System.Drawing.Size(89, 19);
            this.CurrentTurnLabel.TabIndex = 8;
            this.CurrentTurnLabel.Text = "Current Turn:";
            // 
            // CurrentPlayerTurn
            // 
            this.CurrentPlayerTurn.AutoSize = true;
            this.CurrentPlayerTurn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPlayerTurn.Location = new System.Drawing.Point(490, 235);
            this.CurrentPlayerTurn.Name = "CurrentPlayerTurn";
            this.CurrentPlayerTurn.Size = new System.Drawing.Size(0, 19);
            this.CurrentPlayerTurn.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(395, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Player 1 Wins:";
            // 
            // Player1WinCount
            // 
            this.Player1WinCount.AutoSize = true;
            this.Player1WinCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1WinCount.Location = new System.Drawing.Point(511, 305);
            this.Player1WinCount.Name = "Player1WinCount";
            this.Player1WinCount.Size = new System.Drawing.Size(0, 19);
            this.Player1WinCount.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(395, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Player 2 Wins:";
            // 
            // Player2WinCount
            // 
            this.Player2WinCount.AutoSize = true;
            this.Player2WinCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2WinCount.Location = new System.Drawing.Point(511, 339);
            this.Player2WinCount.Name = "Player2WinCount";
            this.Player2WinCount.Size = new System.Drawing.Size(0, 19);
            this.Player2WinCount.TabIndex = 13;
            // 
            // CatsGameCounterLabel
            // 
            this.CatsGameCounterLabel.AutoSize = true;
            this.CatsGameCounterLabel.BackColor = System.Drawing.Color.Lime;
            this.CatsGameCounterLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatsGameCounterLabel.Location = new System.Drawing.Point(395, 378);
            this.CatsGameCounterLabel.Name = "CatsGameCounterLabel";
            this.CatsGameCounterLabel.Size = new System.Drawing.Size(89, 19);
            this.CatsGameCounterLabel.TabIndex = 14;
            this.CatsGameCounterLabel.Text = "Cat\'s Games:";
            // 
            // CatsGameCounter
            // 
            this.CatsGameCounter.AutoSize = true;
            this.CatsGameCounter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatsGameCounter.Location = new System.Drawing.Point(511, 378);
            this.CatsGameCounter.Name = "CatsGameCounter";
            this.CatsGameCounter.Size = new System.Drawing.Size(0, 19);
            this.CatsGameCounter.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 573);
            this.Controls.Add(this.CatsGameCounter);
            this.Controls.Add(this.CatsGameCounterLabel);
            this.Controls.Add(this.Player2WinCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Player1WinCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentPlayerTurn);
            this.Controls.Add(this.CurrentTurnLabel);
            this.Controls.Add(this.PlayAgainButton);
            this.Controls.Add(this.CatsGameLabel);
            this.Controls.Add(this.Player2WinsLabel);
            this.Controls.Add(this.Player1WinsLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel Player1Shape;
        private System.Windows.Forms.ToolStripStatusLabel Player2Shape;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.Label Player1WinsLabel;
        private System.Windows.Forms.Label Player2WinsLabel;
        private System.Windows.Forms.Label CatsGameLabel;
        private System.Windows.Forms.Button PlayAgainButton;
        private System.Windows.Forms.ToolStripStatusLabel Player2Label;
        private System.Windows.Forms.Label CurrentTurnLabel;
        private System.Windows.Forms.Label CurrentPlayerTurn;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Player1WinCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Player2WinCount;
        private System.Windows.Forms.Label CatsGameCounterLabel;
        private System.Windows.Forms.Label CatsGameCounter;
        private System.Windows.Forms.ToolStripMenuItem exitGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesOfPlayToolStripMenuItem;
    }
}

