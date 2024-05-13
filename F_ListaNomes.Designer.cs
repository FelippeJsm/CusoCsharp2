namespace Felippe_2
{
    partial class F_ListaNomes
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
            this.tb_ListaNomes1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_ListaNomes1
            // 
            this.tb_ListaNomes1.BackColor = System.Drawing.Color.Orange;
            this.tb_ListaNomes1.Location = new System.Drawing.Point(13, 13);
            this.tb_ListaNomes1.Multiline = true;
            this.tb_ListaNomes1.Name = "tb_ListaNomes1";
            this.tb_ListaNomes1.Size = new System.Drawing.Size(394, 425);
            this.tb_ListaNomes1.TabIndex = 0;
            // 
            // F_ListaNomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.tb_ListaNomes1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_ListaNomes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ListaNomes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ListaNomes1;
    }
}