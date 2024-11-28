using System;

namespace WarmOderKalt
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResult = new System.Windows.Forms.Label();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.chkHardmode = new System.Windows.Forms.CheckBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Black;
            this.lblResult.ForeColor = System.Drawing.Color.Lime;
            this.lblResult.Location = new System.Drawing.Point(43, 66);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(207, 13);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Ich habe eine Zahl ausgewählt. Rate jetzt!";
            // 
            // lblHighscore
            // 
            this.lblHighscore.AutoSize = true;
            this.lblHighscore.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblHighscore.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblHighscore.Location = new System.Drawing.Point(74, 109);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(164, 13);
            this.lblHighscore.TabIndex = 1;
            this.lblHighscore.Text = "Noch kein Highscore vorhanden.";
            // 
            // txtGuess
            // 
            this.txtGuess.BackColor = System.Drawing.SystemColors.Window;
            this.txtGuess.Location = new System.Drawing.Point(14, 174);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(102, 20);
            this.txtGuess.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackgroundImage = global::WarmOderKalt.Properties.Resources.Enter;
            this.btnSubmit.Location = new System.Drawing.Point(122, 174);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(128, 21);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Enter";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(122, 203);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(128, 21);
            this.btnRestart.TabIndex = 4;
            this.btnRestart.Text = "Neustart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click_2);
            // 
            // chkHardmode
            // 
            this.chkHardmode.AutoSize = true;
            this.chkHardmode.BackColor = System.Drawing.Color.Lime;
            this.chkHardmode.Location = new System.Drawing.Point(5, 206);
            this.chkHardmode.Name = "chkHardmode";
            this.chkHardmode.Size = new System.Drawing.Size(117, 17);
            this.chkHardmode.TabIndex = 5;
            this.chkHardmode.Text = "Hardmode (1-1000)";
            this.chkHardmode.UseVisualStyleBackColor = false;
            this.chkHardmode.CheckedChanged += new System.EventHandler(this.ChkHardmode_CheckedChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.InitialImage = global::WarmOderKalt.Properties.Resources.Enter;
            this.pictureBox.Location = new System.Drawing.Point(265, 45);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(199, 179);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImage = global::WarmOderKalt.Properties.Resources.Enter;
            this.ClientSize = new System.Drawing.Size(262, 264);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.chkHardmode);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblHighscore);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblHighscore;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.CheckBox chkHardmode;
        private System.Windows.Forms.PictureBox pictureBox;
        private EventHandler btnRestart_Click_1;

        public Form1(EventHandler btnRestart_Click_1)
        {
            this.btnRestart_Click_1 = btnRestart_Click_1;
        }
    }
}

