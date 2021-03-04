namespace Hangman_Gmae
{
    partial class FrmHangman
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
            this.picHangman = new System.Windows.Forms.PictureBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHangman)).BeginInit();
            this.SuspendLayout();
            // 
            // picHangman
            // 
            this.picHangman.Image = global::Hangman_Gmae.Properties.Resources.Hangman_0;
            this.picHangman.Location = new System.Drawing.Point(482, 23);
            this.picHangman.Name = "picHangman";
            this.picHangman.Size = new System.Drawing.Size(183, 248);
            this.picHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHangman.TabIndex = 0;
            this.picHangman.TabStop = false;
            // 
            // lblAnswer
            // 
            this.lblAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.White;
            this.lblAnswer.Location = new System.Drawing.Point(137, 193);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(178, 39);
            this.lblAnswer.TabIndex = 1;
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input :";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(141, 86);
            this.txtInput.MaxLength = 1;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(174, 29);
            this.txtInput.TabIndex = 3;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(141, 134);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(174, 35);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(36, 23);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(380, 41);
            this.lblLevel.TabIndex = 5;
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 300);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.picHangman);
            this.Name = "FrmHangman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHangman";
            this.Load += new System.EventHandler(this.FrmHangman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHangman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHangman;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblLevel;
    }
}