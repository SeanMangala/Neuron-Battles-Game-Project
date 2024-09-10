namespace Assignment2Final
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
            this.components = new System.ComponentModel.Container();
            this.playerOneNameLbl = new System.Windows.Forms.Label();
            this.playerOneNameTb = new System.Windows.Forms.TextBox();
            this.playerOneColorLb = new System.Windows.Forms.ListBox();
            this.playerOneColorLbl = new System.Windows.Forms.Label();
            this.playerTwoColorLbl = new System.Windows.Forms.Label();
            this.playerTwoColorLb = new System.Windows.Forms.ListBox();
            this.playerTwoNameTb = new System.Windows.Forms.TextBox();
            this.playerTwoNameLbl = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.playerOneLbl = new System.Windows.Forms.Label();
            this.playerTwoLbl = new System.Windows.Forms.Label();
            this.playerTwoHealth = new System.Windows.Forms.Label();
            this.questionLbl = new System.Windows.Forms.Label();
            this.answerTb = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.playerTurnLbl = new System.Windows.Forms.Label();
            this.damageLbl = new System.Windows.Forms.Label();
            this.instructionsBtn = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            this.answeringTimer = new System.Windows.Forms.Timer(this.components);
            this.timerLbl = new System.Windows.Forms.Label();
            this.playerTwoDamagePopUp = new System.Windows.Forms.Label();
            this.playerOneDamagePopUp = new System.Windows.Forms.Label();
            this.playerOneProgB = new System.Windows.Forms.ProgressBar();
            this.playerTwoProgB = new System.Windows.Forms.ProgressBar();
            this.playerOneHealth = new System.Windows.Forms.Label();
            this.versusLbl = new System.Windows.Forms.Label();
            this.playerTwoPb = new System.Windows.Forms.PictureBox();
            this.playerOnePb = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerTwoPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerOnePb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // playerOneNameLbl
            // 
            this.playerOneNameLbl.AutoSize = true;
            this.playerOneNameLbl.BackColor = System.Drawing.SystemColors.Window;
            this.playerOneNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneNameLbl.Location = new System.Drawing.Point(24, 380);
            this.playerOneNameLbl.Name = "playerOneNameLbl";
            this.playerOneNameLbl.Size = new System.Drawing.Size(55, 20);
            this.playerOneNameLbl.TabIndex = 1;
            this.playerOneNameLbl.Text = "Name:";
            // 
            // playerOneNameTb
            // 
            this.playerOneNameTb.BackColor = System.Drawing.SystemColors.Menu;
            this.playerOneNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneNameTb.Location = new System.Drawing.Point(28, 402);
            this.playerOneNameTb.Name = "playerOneNameTb";
            this.playerOneNameTb.Size = new System.Drawing.Size(100, 26);
            this.playerOneNameTb.TabIndex = 2;
            this.playerOneNameTb.Click += new System.EventHandler(this.playerOneNameTb_Click);
            // 
            // playerOneColorLb
            // 
            this.playerOneColorLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneColorLb.FormattingEnabled = true;
            this.playerOneColorLb.ItemHeight = 16;
            this.playerOneColorLb.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Yellow",
            "Pink",
            "C# God",
            "HTML Master"});
            this.playerOneColorLb.Location = new System.Drawing.Point(156, 392);
            this.playerOneColorLb.Name = "playerOneColorLb";
            this.playerOneColorLb.Size = new System.Drawing.Size(120, 52);
            this.playerOneColorLb.TabIndex = 3;
            this.playerOneColorLb.SelectedIndexChanged += new System.EventHandler(this.playerOneColorLb_SelectedIndexChanged);
            // 
            // playerOneColorLbl
            // 
            this.playerOneColorLbl.AutoSize = true;
            this.playerOneColorLbl.BackColor = System.Drawing.SystemColors.Window;
            this.playerOneColorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneColorLbl.Location = new System.Drawing.Point(152, 371);
            this.playerOneColorLbl.Name = "playerOneColorLbl";
            this.playerOneColorLbl.Size = new System.Drawing.Size(50, 20);
            this.playerOneColorLbl.TabIndex = 4;
            this.playerOneColorLbl.Text = "Color:";
            // 
            // playerTwoColorLbl
            // 
            this.playerTwoColorLbl.AutoSize = true;
            this.playerTwoColorLbl.BackColor = System.Drawing.SystemColors.Window;
            this.playerTwoColorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.playerTwoColorLbl.Location = new System.Drawing.Point(653, 371);
            this.playerTwoColorLbl.Name = "playerTwoColorLbl";
            this.playerTwoColorLbl.Size = new System.Drawing.Size(50, 20);
            this.playerTwoColorLbl.TabIndex = 8;
            this.playerTwoColorLbl.Text = "Color:";
            // 
            // playerTwoColorLb
            // 
            this.playerTwoColorLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoColorLb.FormattingEnabled = true;
            this.playerTwoColorLb.ItemHeight = 16;
            this.playerTwoColorLb.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Yellow",
            "Pink",
            "C# God",
            "HTML Master"});
            this.playerTwoColorLb.Location = new System.Drawing.Point(657, 392);
            this.playerTwoColorLb.Name = "playerTwoColorLb";
            this.playerTwoColorLb.Size = new System.Drawing.Size(120, 52);
            this.playerTwoColorLb.TabIndex = 7;
            this.playerTwoColorLb.SelectedIndexChanged += new System.EventHandler(this.playerTwoColorLb_SelectedIndexChanged);
            // 
            // playerTwoNameTb
            // 
            this.playerTwoNameTb.BackColor = System.Drawing.SystemColors.Menu;
            this.playerTwoNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoNameTb.Location = new System.Drawing.Point(533, 402);
            this.playerTwoNameTb.Name = "playerTwoNameTb";
            this.playerTwoNameTb.Size = new System.Drawing.Size(100, 26);
            this.playerTwoNameTb.TabIndex = 6;
            this.playerTwoNameTb.Click += new System.EventHandler(this.playerTwoNameTb_Click);
            // 
            // playerTwoNameLbl
            // 
            this.playerTwoNameLbl.AutoSize = true;
            this.playerTwoNameLbl.BackColor = System.Drawing.SystemColors.Window;
            this.playerTwoNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.playerTwoNameLbl.Location = new System.Drawing.Point(529, 380);
            this.playerTwoNameLbl.Name = "playerTwoNameLbl";
            this.playerTwoNameLbl.Size = new System.Drawing.Size(55, 20);
            this.playerTwoNameLbl.TabIndex = 5;
            this.playerTwoNameLbl.Text = "Name:";
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(361, 373);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(97, 41);
            this.startBtn.TabIndex = 9;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // playerOneLbl
            // 
            this.playerOneLbl.BackColor = System.Drawing.SystemColors.Window;
            this.playerOneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneLbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.playerOneLbl.Location = new System.Drawing.Point(40, 30);
            this.playerOneLbl.Name = "playerOneLbl";
            this.playerOneLbl.Size = new System.Drawing.Size(119, 25);
            this.playerOneLbl.TabIndex = 10;
            this.playerOneLbl.Text = "Player One";
            this.playerOneLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerTwoLbl
            // 
            this.playerTwoLbl.BackColor = System.Drawing.SystemColors.Window;
            this.playerTwoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.playerTwoLbl.Location = new System.Drawing.Point(647, 30);
            this.playerTwoLbl.Name = "playerTwoLbl";
            this.playerTwoLbl.Size = new System.Drawing.Size(119, 25);
            this.playerTwoLbl.TabIndex = 11;
            this.playerTwoLbl.Text = "Player Two";
            this.playerTwoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerTwoHealth
            // 
            this.playerTwoHealth.BackColor = System.Drawing.SystemColors.Window;
            this.playerTwoHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoHealth.Location = new System.Drawing.Point(447, 21);
            this.playerTwoHealth.Name = "playerTwoHealth";
            this.playerTwoHealth.Size = new System.Drawing.Size(101, 18);
            this.playerTwoHealth.TabIndex = 15;
            this.playerTwoHealth.Text = "000";
            this.playerTwoHealth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.playerTwoHealth.Visible = false;
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.BackColor = System.Drawing.SystemColors.Window;
            this.questionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.Location = new System.Drawing.Point(386, 119);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(40, 29);
            this.questionLbl.TabIndex = 16;
            this.questionLbl.Text = "---";
            this.questionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.questionLbl.Visible = false;
            // 
            // answerTb
            // 
            this.answerTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTb.Location = new System.Drawing.Point(347, 184);
            this.answerTb.Name = "answerTb";
            this.answerTb.Size = new System.Drawing.Size(121, 26);
            this.answerTb.TabIndex = 17;
            this.answerTb.Visible = false;
            this.answerTb.Click += new System.EventHandler(this.answerTb_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(347, 220);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(121, 32);
            this.submitBtn.TabIndex = 18;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Visible = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // playerTurnLbl
            // 
            this.playerTurnLbl.AutoSize = true;
            this.playerTurnLbl.BackColor = System.Drawing.SystemColors.Window;
            this.playerTurnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTurnLbl.Location = new System.Drawing.Point(395, 83);
            this.playerTurnLbl.Name = "playerTurnLbl";
            this.playerTurnLbl.Size = new System.Drawing.Size(24, 20);
            this.playerTurnLbl.TabIndex = 19;
            this.playerTurnLbl.Text = "---";
            this.playerTurnLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playerTurnLbl.Visible = false;
            // 
            // damageLbl
            // 
            this.damageLbl.AutoSize = true;
            this.damageLbl.BackColor = System.Drawing.SystemColors.Window;
            this.damageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damageLbl.Location = new System.Drawing.Point(397, 152);
            this.damageLbl.Name = "damageLbl";
            this.damageLbl.Size = new System.Drawing.Size(19, 16);
            this.damageLbl.TabIndex = 24;
            this.damageLbl.Text = "---";
            this.damageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.damageLbl.Visible = false;
            // 
            // instructionsBtn
            // 
            this.instructionsBtn.Location = new System.Drawing.Point(361, 420);
            this.instructionsBtn.Name = "instructionsBtn";
            this.instructionsBtn.Size = new System.Drawing.Size(97, 23);
            this.instructionsBtn.TabIndex = 25;
            this.instructionsBtn.Text = "Instructions";
            this.instructionsBtn.UseVisualStyleBackColor = true;
            this.instructionsBtn.Click += new System.EventHandler(this.instructionsBtn_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.BackColor = System.Drawing.SystemColors.Window;
            this.errorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(396, 331);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(27, 20);
            this.errorLbl.TabIndex = 26;
            this.errorLbl.Text = "---";
            this.errorLbl.Visible = false;
            // 
            // answeringTimer
            // 
            this.answeringTimer.Interval = 1000;
            this.answeringTimer.Tick += new System.EventHandler(this.answeringTimer_Tick);
            // 
            // timerLbl
            // 
            this.timerLbl.AutoSize = true;
            this.timerLbl.BackColor = System.Drawing.SystemColors.Window;
            this.timerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLbl.Location = new System.Drawing.Point(394, 290);
            this.timerLbl.Name = "timerLbl";
            this.timerLbl.Size = new System.Drawing.Size(30, 31);
            this.timerLbl.TabIndex = 27;
            this.timerLbl.Text = "0";
            this.timerLbl.Visible = false;
            // 
            // playerTwoDamagePopUp
            // 
            this.playerTwoDamagePopUp.AutoSize = true;
            this.playerTwoDamagePopUp.BackColor = System.Drawing.SystemColors.Window;
            this.playerTwoDamagePopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoDamagePopUp.ForeColor = System.Drawing.Color.Red;
            this.playerTwoDamagePopUp.Location = new System.Drawing.Point(715, 152);
            this.playerTwoDamagePopUp.Name = "playerTwoDamagePopUp";
            this.playerTwoDamagePopUp.Size = new System.Drawing.Size(36, 25);
            this.playerTwoDamagePopUp.TabIndex = 28;
            this.playerTwoDamagePopUp.Text = "---";
            this.playerTwoDamagePopUp.Visible = false;
            // 
            // playerOneDamagePopUp
            // 
            this.playerOneDamagePopUp.AutoSize = true;
            this.playerOneDamagePopUp.BackColor = System.Drawing.SystemColors.Window;
            this.playerOneDamagePopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneDamagePopUp.ForeColor = System.Drawing.Color.Red;
            this.playerOneDamagePopUp.Location = new System.Drawing.Point(57, 152);
            this.playerOneDamagePopUp.Name = "playerOneDamagePopUp";
            this.playerOneDamagePopUp.Size = new System.Drawing.Size(36, 25);
            this.playerOneDamagePopUp.TabIndex = 29;
            this.playerOneDamagePopUp.Text = "---";
            this.playerOneDamagePopUp.Visible = false;
            // 
            // playerOneProgB
            // 
            this.playerOneProgB.ForeColor = System.Drawing.Color.Green;
            this.playerOneProgB.Location = new System.Drawing.Point(183, 40);
            this.playerOneProgB.MarqueeAnimationSpeed = 0;
            this.playerOneProgB.Name = "playerOneProgB";
            this.playerOneProgB.Size = new System.Drawing.Size(185, 23);
            this.playerOneProgB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.playerOneProgB.TabIndex = 30;
            // 
            // playerTwoProgB
            // 
            this.playerTwoProgB.ForeColor = System.Drawing.Color.Green;
            this.playerTwoProgB.Location = new System.Drawing.Point(447, 40);
            this.playerTwoProgB.MarqueeAnimationSpeed = 0;
            this.playerTwoProgB.Name = "playerTwoProgB";
            this.playerTwoProgB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.playerTwoProgB.RightToLeftLayout = true;
            this.playerTwoProgB.Size = new System.Drawing.Size(185, 23);
            this.playerTwoProgB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.playerTwoProgB.TabIndex = 31;
            // 
            // playerOneHealth
            // 
            this.playerOneHealth.BackColor = System.Drawing.SystemColors.Window;
            this.playerOneHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneHealth.Location = new System.Drawing.Point(272, 21);
            this.playerOneHealth.Name = "playerOneHealth";
            this.playerOneHealth.Size = new System.Drawing.Size(97, 18);
            this.playerOneHealth.TabIndex = 14;
            this.playerOneHealth.Text = "000";
            this.playerOneHealth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.playerOneHealth.Visible = false;
            // 
            // versusLbl
            // 
            this.versusLbl.AutoSize = true;
            this.versusLbl.BackColor = System.Drawing.SystemColors.Window;
            this.versusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versusLbl.Location = new System.Drawing.Point(385, 28);
            this.versusLbl.Name = "versusLbl";
            this.versusLbl.Size = new System.Drawing.Size(46, 29);
            this.versusLbl.TabIndex = 20;
            this.versusLbl.Text = "VS";
            // 
            // playerTwoPb
            // 
            this.playerTwoPb.BackColor = System.Drawing.SystemColors.Window;
            this.playerTwoPb.Location = new System.Drawing.Point(575, 161);
            this.playerTwoPb.Name = "playerTwoPb";
            this.playerTwoPb.Size = new System.Drawing.Size(164, 200);
            this.playerTwoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerTwoPb.TabIndex = 13;
            this.playerTwoPb.TabStop = false;
            // 
            // playerOnePb
            // 
            this.playerOnePb.BackColor = System.Drawing.SystemColors.Window;
            this.playerOnePb.Location = new System.Drawing.Point(62, 161);
            this.playerOnePb.Name = "playerOnePb";
            this.playerOnePb.Size = new System.Drawing.Size(164, 200);
            this.playerOnePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerOnePb.TabIndex = 12;
            this.playerOnePb.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assignment2Final.Properties.Resources.battleFieldBasicUpdated5;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playerTwoProgB);
            this.Controls.Add(this.playerOneProgB);
            this.Controls.Add(this.playerOneDamagePopUp);
            this.Controls.Add(this.playerTwoDamagePopUp);
            this.Controls.Add(this.timerLbl);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.instructionsBtn);
            this.Controls.Add(this.damageLbl);
            this.Controls.Add(this.versusLbl);
            this.Controls.Add(this.playerTurnLbl);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.answerTb);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.playerTwoHealth);
            this.Controls.Add(this.playerOneHealth);
            this.Controls.Add(this.playerTwoPb);
            this.Controls.Add(this.playerOnePb);
            this.Controls.Add(this.playerTwoLbl);
            this.Controls.Add(this.playerOneLbl);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.playerTwoColorLbl);
            this.Controls.Add(this.playerTwoColorLb);
            this.Controls.Add(this.playerTwoNameTb);
            this.Controls.Add(this.playerTwoNameLbl);
            this.Controls.Add(this.playerOneColorLbl);
            this.Controls.Add(this.playerOneColorLb);
            this.Controls.Add(this.playerOneNameTb);
            this.Controls.Add(this.playerOneNameLbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Neuron Battles!";
            ((System.ComponentModel.ISupportInitialize)(this.playerTwoPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerOnePb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label playerOneNameLbl;
        private System.Windows.Forms.TextBox playerOneNameTb;
        private System.Windows.Forms.ListBox playerOneColorLb;
        private System.Windows.Forms.Label playerOneColorLbl;
        private System.Windows.Forms.Label playerTwoColorLbl;
        private System.Windows.Forms.ListBox playerTwoColorLb;
        private System.Windows.Forms.TextBox playerTwoNameTb;
        private System.Windows.Forms.Label playerTwoNameLbl;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label playerOneLbl;
        private System.Windows.Forms.Label playerTwoLbl;
        private System.Windows.Forms.PictureBox playerOnePb;
        private System.Windows.Forms.PictureBox playerTwoPb;
        private System.Windows.Forms.Label playerTwoHealth;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.TextBox answerTb;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label playerTurnLbl;
        private System.Windows.Forms.Label damageLbl;
        private System.Windows.Forms.Button instructionsBtn;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Timer answeringTimer;
        private System.Windows.Forms.Label timerLbl;
        private System.Windows.Forms.Label playerTwoDamagePopUp;
        private System.Windows.Forms.Label playerOneDamagePopUp;
        private System.Windows.Forms.ProgressBar playerOneProgB;
        private System.Windows.Forms.ProgressBar playerTwoProgB;
        private System.Windows.Forms.Label playerOneHealth;
        private System.Windows.Forms.Label versusLbl;
    }
}

