namespace Assignment2Final
{
    partial class gameOver
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
            this.gameOverLbl = new System.Windows.Forms.Label();
            this.endMsgLbl = new System.Windows.Forms.Label();
            this.createdByLbl = new System.Windows.Forms.Label();
            this.mainScreenBgPb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainScreenBgPb)).BeginInit();
            this.SuspendLayout();
            // 
            // gameOverLbl
            // 
            this.gameOverLbl.AutoSize = true;
            this.gameOverLbl.BackColor = System.Drawing.SystemColors.Window;
            this.gameOverLbl.Font = new System.Drawing.Font("HYGothic-Extra", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gameOverLbl.Location = new System.Drawing.Point(243, 86);
            this.gameOverLbl.Name = "gameOverLbl";
            this.gameOverLbl.Size = new System.Drawing.Size(304, 48);
            this.gameOverLbl.TabIndex = 6;
            this.gameOverLbl.Text = "Game Over";
            // 
            // endMsgLbl
            // 
            this.endMsgLbl.AutoSize = true;
            this.endMsgLbl.BackColor = System.Drawing.SystemColors.Window;
            this.endMsgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endMsgLbl.Location = new System.Drawing.Point(299, 145);
            this.endMsgLbl.Name = "endMsgLbl";
            this.endMsgLbl.Size = new System.Drawing.Size(195, 25);
            this.endMsgLbl.TabIndex = 7;
            this.endMsgLbl.Text = "Thanks for playing!";
            // 
            // createdByLbl
            // 
            this.createdByLbl.AutoSize = true;
            this.createdByLbl.BackColor = System.Drawing.SystemColors.Window;
            this.createdByLbl.Location = new System.Drawing.Point(331, 284);
            this.createdByLbl.Name = "createdByLbl";
            this.createdByLbl.Size = new System.Drawing.Size(133, 13);
            this.createdByLbl.TabIndex = 8;
            this.createdByLbl.Text = "Created by: Sean Mangala";
            // 
            // mainScreenBgPb
            // 
            this.mainScreenBgPb.Image = global::Assignment2Final.Properties.Resources.gameOverBg;
            this.mainScreenBgPb.Location = new System.Drawing.Point(-2, -2);
            this.mainScreenBgPb.Name = "mainScreenBgPb";
            this.mainScreenBgPb.Size = new System.Drawing.Size(805, 455);
            this.mainScreenBgPb.TabIndex = 5;
            this.mainScreenBgPb.TabStop = false;
            // 
            // gameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createdByLbl);
            this.Controls.Add(this.endMsgLbl);
            this.Controls.Add(this.gameOverLbl);
            this.Controls.Add(this.mainScreenBgPb);
            this.Name = "gameOver";
            this.Text = "Neuron Battles!";
            ((System.ComponentModel.ISupportInitialize)(this.mainScreenBgPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label gameOverLbl;
        private System.Windows.Forms.PictureBox mainScreenBgPb;
        private System.Windows.Forms.Label endMsgLbl;
        private System.Windows.Forms.Label createdByLbl;
    }
}