namespace Baldwin_Asg7_RockPaperScissors
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
            this.buttonChoosePaper = new System.Windows.Forms.Button();
            this.buttonChooseScissors = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPlayerChoice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelComputerChoice = new System.Windows.Forms.Label();
            this.labelWinner = new System.Windows.Forms.Label();
            this.buttonChooseRock = new System.Windows.Forms.Button();
            this.Totals = new System.Windows.Forms.GroupBox();
            this.labelTotalGames = new System.Windows.Forms.Label();
            this.labelTieCountTotal = new System.Windows.Forms.Label();
            this.labelComputerWinTotal = new System.Windows.Forms.Label();
            this.labelPlayerWinTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonResetScores = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Totals.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonChoosePaper
            // 
            this.buttonChoosePaper.Location = new System.Drawing.Point(6, 74);
            this.buttonChoosePaper.Name = "buttonChoosePaper";
            this.buttonChoosePaper.Size = new System.Drawing.Size(88, 49);
            this.buttonChoosePaper.TabIndex = 1;
            this.buttonChoosePaper.Text = "Paper";
            this.buttonChoosePaper.UseVisualStyleBackColor = true;
            this.buttonChoosePaper.Click += new System.EventHandler(this.buttonChoosePaper_Click);
            // 
            // buttonChooseScissors
            // 
            this.buttonChooseScissors.Location = new System.Drawing.Point(6, 129);
            this.buttonChooseScissors.Name = "buttonChooseScissors";
            this.buttonChooseScissors.Size = new System.Drawing.Size(88, 49);
            this.buttonChooseScissors.TabIndex = 2;
            this.buttonChooseScissors.Text = "Scissors";
            this.buttonChooseScissors.UseVisualStyleBackColor = true;
            this.buttonChooseScissors.Click += new System.EventHandler(this.buttonChooseScissors_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player\'s Choice";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Computer\'s Choice";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlayerChoice
            // 
            this.labelPlayerChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlayerChoice.Location = new System.Drawing.Point(125, 54);
            this.labelPlayerChoice.Name = "labelPlayerChoice";
            this.labelPlayerChoice.Size = new System.Drawing.Size(72, 23);
            this.labelPlayerChoice.TabIndex = 5;
            this.labelPlayerChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Winner";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelComputerChoice);
            this.groupBox1.Controls.Add(this.labelWinner);
            this.groupBox1.Controls.Add(this.buttonChooseRock);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonChoosePaper);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonChooseScissors);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelPlayerChoice);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 186);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Play Game";
            // 
            // labelComputerChoice
            // 
            this.labelComputerChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelComputerChoice.Location = new System.Drawing.Point(239, 54);
            this.labelComputerChoice.Name = "labelComputerChoice";
            this.labelComputerChoice.Size = new System.Drawing.Size(72, 23);
            this.labelComputerChoice.TabIndex = 10;
            this.labelComputerChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWinner
            // 
            this.labelWinner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWinner.Location = new System.Drawing.Point(178, 122);
            this.labelWinner.Name = "labelWinner";
            this.labelWinner.Size = new System.Drawing.Size(72, 23);
            this.labelWinner.TabIndex = 9;
            this.labelWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonChooseRock
            // 
            this.buttonChooseRock.Location = new System.Drawing.Point(6, 19);
            this.buttonChooseRock.Name = "buttonChooseRock";
            this.buttonChooseRock.Size = new System.Drawing.Size(88, 49);
            this.buttonChooseRock.TabIndex = 0;
            this.buttonChooseRock.Text = "Rock";
            this.buttonChooseRock.UseVisualStyleBackColor = true;
            this.buttonChooseRock.Click += new System.EventHandler(this.buttonChooseRock_Click);
            // 
            // Totals
            // 
            this.Totals.Controls.Add(this.labelTotalGames);
            this.Totals.Controls.Add(this.labelTieCountTotal);
            this.Totals.Controls.Add(this.labelComputerWinTotal);
            this.Totals.Controls.Add(this.labelPlayerWinTotal);
            this.Totals.Controls.Add(this.label7);
            this.Totals.Controls.Add(this.label6);
            this.Totals.Controls.Add(this.label4);
            this.Totals.Controls.Add(this.label3);
            this.Totals.Controls.Add(this.buttonResetScores);
            this.Totals.Location = new System.Drawing.Point(364, 13);
            this.Totals.Name = "Totals";
            this.Totals.Size = new System.Drawing.Size(235, 186);
            this.Totals.TabIndex = 10;
            this.Totals.TabStop = false;
            this.Totals.Text = "Totals";
            // 
            // labelTotalGames
            // 
            this.labelTotalGames.AutoSize = true;
            this.labelTotalGames.Location = new System.Drawing.Point(126, 104);
            this.labelTotalGames.Name = "labelTotalGames";
            this.labelTotalGames.Size = new System.Drawing.Size(13, 13);
            this.labelTotalGames.TabIndex = 11;
            this.labelTotalGames.Text = "0";
            // 
            // labelTieCountTotal
            // 
            this.labelTieCountTotal.AutoSize = true;
            this.labelTieCountTotal.Location = new System.Drawing.Point(126, 76);
            this.labelTieCountTotal.Name = "labelTieCountTotal";
            this.labelTieCountTotal.Size = new System.Drawing.Size(13, 13);
            this.labelTieCountTotal.TabIndex = 10;
            this.labelTieCountTotal.Text = "0";
            // 
            // labelComputerWinTotal
            // 
            this.labelComputerWinTotal.AutoSize = true;
            this.labelComputerWinTotal.Location = new System.Drawing.Point(126, 47);
            this.labelComputerWinTotal.Name = "labelComputerWinTotal";
            this.labelComputerWinTotal.Size = new System.Drawing.Size(13, 13);
            this.labelComputerWinTotal.TabIndex = 9;
            this.labelComputerWinTotal.Text = "0";
            // 
            // labelPlayerWinTotal
            // 
            this.labelPlayerWinTotal.AutoSize = true;
            this.labelPlayerWinTotal.Location = new System.Drawing.Point(126, 19);
            this.labelPlayerWinTotal.Name = "labelPlayerWinTotal";
            this.labelPlayerWinTotal.Size = new System.Drawing.Size(13, 13);
            this.labelPlayerWinTotal.TabIndex = 8;
            this.labelPlayerWinTotal.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ties:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Games:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Computer Wins:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Player Wins:";
            // 
            // buttonResetScores
            // 
            this.buttonResetScores.Location = new System.Drawing.Point(61, 142);
            this.buttonResetScores.Name = "buttonResetScores";
            this.buttonResetScores.Size = new System.Drawing.Size(115, 36);
            this.buttonResetScores.TabIndex = 3;
            this.buttonResetScores.Text = "Reset Score";
            this.buttonResetScores.UseVisualStyleBackColor = true;
            this.buttonResetScores.Click += new System.EventHandler(this.buttonResetScores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 209);
            this.Controls.Add(this.Totals);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Baldwin ASG7 Rock-Paper-Scissors";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Totals.ResumeLayout(false);
            this.Totals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonChoosePaper;
        private System.Windows.Forms.Button buttonChooseScissors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPlayerChoice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelComputerChoice;
        private System.Windows.Forms.Label labelWinner;
        private System.Windows.Forms.Button buttonChooseRock;
        private System.Windows.Forms.GroupBox Totals;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonResetScores;
        private System.Windows.Forms.Label labelTotalGames;
        private System.Windows.Forms.Label labelTieCountTotal;
        private System.Windows.Forms.Label labelComputerWinTotal;
        private System.Windows.Forms.Label labelPlayerWinTotal;
    }
}

