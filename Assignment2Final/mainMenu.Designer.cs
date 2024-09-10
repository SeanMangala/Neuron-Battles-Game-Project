namespace Assignment2Final
{
    partial class mainMenu
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
            this.startBtn = new System.Windows.Forms.Button();
            this.gameTitleLbl = new System.Windows.Forms.Label();
            this.instructionsBtn = new System.Windows.Forms.Button();
            this.createdByLbl = new System.Windows.Forms.Label();
            this.mainScreenBgPb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainScreenBgPb)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(163, 207);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(131, 53);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // gameTitleLbl
            // 
            this.gameTitleLbl.AutoSize = true;
            this.gameTitleLbl.BackColor = System.Drawing.SystemColors.Window;
            this.gameTitleLbl.Font = new System.Drawing.Font("HYGothic-Extra", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gameTitleLbl.Location = new System.Drawing.Point(28, 78);
            this.gameTitleLbl.Name = "gameTitleLbl";
            this.gameTitleLbl.Size = new System.Drawing.Size(428, 48);
            this.gameTitleLbl.TabIndex = 2;
            this.gameTitleLbl.Text = "Neuron Battles!";
            // 
            // instructionsBtn
            // 
            this.instructionsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsBtn.Location = new System.Drawing.Point(163, 270);
            this.instructionsBtn.Name = "instructionsBtn";
            this.instructionsBtn.Size = new System.Drawing.Size(131, 53);
            this.instructionsBtn.TabIndex = 3;
            this.instructionsBtn.Text = "Instructions";
            this.instructionsBtn.UseVisualStyleBackColor = true;
            this.instructionsBtn.Click += new System.EventHandler(this.instructionsBtn_Click);
            // 
            // createdByLbl
            // 
            this.createdByLbl.AutoSize = true;
            this.createdByLbl.BackColor = System.Drawing.SystemColors.Window;
            this.createdByLbl.Location = new System.Drawing.Point(160, 171);
            this.createdByLbl.Name = "createdByLbl";
            this.createdByLbl.Size = new System.Drawing.Size(133, 13);
            this.createdByLbl.TabIndex = 4;
            this.createdByLbl.Text = "Created by: Sean Mangala";
            // 
            // mainScreenBgPb
            // 
            this.mainScreenBgPb.Image = global::Assignment2Final.Properties.Resources.startMenuUpdated;
            this.mainScreenBgPb.Location = new System.Drawing.Point(-3, -3);
            this.mainScreenBgPb.Name = "mainScreenBgPb";
            this.mainScreenBgPb.Size = new System.Drawing.Size(805, 455);
            this.mainScreenBgPb.TabIndex = 1;
            this.mainScreenBgPb.TabStop = false;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createdByLbl);
            this.Controls.Add(this.instructionsBtn);
            this.Controls.Add(this.gameTitleLbl);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.mainScreenBgPb);
            this.Name = "mainMenu";
            this.Text = "Neuron Battles!";
            ((System.ComponentModel.ISupportInitialize)(this.mainScreenBgPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.PictureBox mainScreenBgPb;
        private System.Windows.Forms.Label gameTitleLbl;
        private System.Windows.Forms.Button instructionsBtn;
        private System.Windows.Forms.Label createdByLbl;
    }
}