namespace rock_paper_scizzors
{
    partial class frmGameArena
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
            this.lbPlayerName = new System.Windows.Forms.Label();
            this.lbPlayerScore = new System.Windows.Forms.Label();
            this.lbComputerScore = new System.Windows.Forms.Label();
            this.lbComputerName = new System.Windows.Forms.Label();
            this.lbMain = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbRounds = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnNextRound = new System.Windows.Forms.Button();
            this.lbEndGame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPlayerName
            // 
            this.lbPlayerName.AutoSize = true;
            this.lbPlayerName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbPlayerName.ForeColor = System.Drawing.Color.White;
            this.lbPlayerName.Location = new System.Drawing.Point(43, 52);
            this.lbPlayerName.Name = "lbPlayerName";
            this.lbPlayerName.Size = new System.Drawing.Size(156, 32);
            this.lbPlayerName.TabIndex = 0;
            this.lbPlayerName.Text = "Player1: You";
            // 
            // lbPlayerScore
            // 
            this.lbPlayerScore.AutoSize = true;
            this.lbPlayerScore.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lbPlayerScore.ForeColor = System.Drawing.Color.White;
            this.lbPlayerScore.Location = new System.Drawing.Point(95, 94);
            this.lbPlayerScore.Name = "lbPlayerScore";
            this.lbPlayerScore.Size = new System.Drawing.Size(46, 54);
            this.lbPlayerScore.TabIndex = 1;
            this.lbPlayerScore.Text = "0";
            // 
            // lbComputerScore
            // 
            this.lbComputerScore.AutoSize = true;
            this.lbComputerScore.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lbComputerScore.ForeColor = System.Drawing.Color.White;
            this.lbComputerScore.Location = new System.Drawing.Point(864, 94);
            this.lbComputerScore.Name = "lbComputerScore";
            this.lbComputerScore.Size = new System.Drawing.Size(46, 54);
            this.lbComputerScore.TabIndex = 3;
            this.lbComputerScore.Text = "0";
            // 
            // lbComputerName
            // 
            this.lbComputerName.AutoSize = true;
            this.lbComputerName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbComputerName.ForeColor = System.Drawing.Color.White;
            this.lbComputerName.Location = new System.Drawing.Point(756, 52);
            this.lbComputerName.Name = "lbComputerName";
            this.lbComputerName.Size = new System.Drawing.Size(227, 32);
            this.lbComputerName.TabIndex = 2;
            this.lbComputerName.Text = "Player2: Computer";
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lbMain.ForeColor = System.Drawing.Color.Cyan;
            this.lbMain.Location = new System.Drawing.Point(256, 189);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(485, 67);
            this.lbMain.TabIndex = 4;
            this.lbMain.Text = "Choose Your Move!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(450, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 81);
            this.label5.TabIndex = 5;
            this.label5.Text = "VS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::rock_paper_scizzors.Properties.Resources.rock_paper_scissors;
            this.pictureBox2.Location = new System.Drawing.Point(580, 283);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(253, 159);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::rock_paper_scizzors.Properties.Resources.rock_paper_scissors;
            this.pictureBox1.Location = new System.Drawing.Point(175, 283);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lbRounds
            // 
            this.lbRounds.AutoSize = true;
            this.lbRounds.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbRounds.ForeColor = System.Drawing.Color.White;
            this.lbRounds.Location = new System.Drawing.Point(366, 52);
            this.lbRounds.Name = "lbRounds";
            this.lbRounds.Size = new System.Drawing.Size(180, 37);
            this.lbRounds.TabIndex = 11;
            this.lbRounds.Text = "GameMode: ";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(180, 685);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(283, 57);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "End Game";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnScissors);
            this.panel1.Controls.Add(this.btnPaper);
            this.panel1.Controls.Add(this.btnRock);
            this.panel1.Location = new System.Drawing.Point(175, 492);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 157);
            this.panel1.TabIndex = 13;
            // 
            // btnScissors
            // 
            this.btnScissors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnScissors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScissors.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnScissors.ForeColor = System.Drawing.Color.White;
            this.btnScissors.Location = new System.Drawing.Point(507, 50);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(191, 57);
            this.btnScissors.TabIndex = 13;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = false;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(77)))));
            this.btnPaper.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPaper.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnPaper.ForeColor = System.Drawing.Color.White;
            this.btnPaper.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPaper.Location = new System.Drawing.Point(247, 50);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(191, 57);
            this.btnPaper.TabIndex = 12;
            this.btnPaper.Text = "Paper";
            this.btnPaper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPaper.UseVisualStyleBackColor = false;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnRock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRock.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnRock.ForeColor = System.Drawing.Color.White;
            this.btnRock.Location = new System.Drawing.Point(5, 50);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(191, 57);
            this.btnRock.TabIndex = 11;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnNextRound
            // 
            this.btnNextRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnNextRound.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextRound.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnNextRound.ForeColor = System.Drawing.Color.White;
            this.btnNextRound.Location = new System.Drawing.Point(537, 685);
            this.btnNextRound.Name = "btnNextRound";
            this.btnNextRound.Size = new System.Drawing.Size(283, 57);
            this.btnNextRound.TabIndex = 14;
            this.btnNextRound.Text = "Next Round";
            this.btnNextRound.UseVisualStyleBackColor = false;
            this.btnNextRound.Visible = false;
            this.btnNextRound.Click += new System.EventHandler(this.btnNextRound_Click);
            // 
            // lbEndGame
            // 
            this.lbEndGame.AutoSize = true;
            this.lbEndGame.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lbEndGame.ForeColor = System.Drawing.Color.Cyan;
            this.lbEndGame.Location = new System.Drawing.Point(169, 492);
            this.lbEndGame.Name = "lbEndGame";
            this.lbEndGame.Size = new System.Drawing.Size(0, 67);
            this.lbEndGame.TabIndex = 15;
            // 
            // frmGameArena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1004, 754);
            this.Controls.Add(this.lbEndGame);
            this.Controls.Add(this.btnNextRound);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbRounds);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbMain);
            this.Controls.Add(this.lbComputerScore);
            this.Controls.Add(this.lbComputerName);
            this.Controls.Add(this.lbPlayerScore);
            this.Controls.Add(this.lbPlayerName);
            this.Name = "frmGameArena";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmGameArena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPlayerName;
        private System.Windows.Forms.Label lbPlayerScore;
        private System.Windows.Forms.Label lbComputerScore;
        private System.Windows.Forms.Label lbComputerName;
        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbRounds;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnNextRound;
        private System.Windows.Forms.Label lbEndGame;
    }
}