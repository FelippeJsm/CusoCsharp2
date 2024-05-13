namespace Felippe_2
{
    partial class F_CheckBox2
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
            this.cb_Joao = new System.Windows.Forms.CheckBox();
            this.cb_Jocimar = new System.Windows.Forms.CheckBox();
            this.cb_Livia = new System.Windows.Forms.CheckBox();
            this.cb_Felippe = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cb_Joao
            // 
            this.cb_Joao.AutoSize = true;
            this.cb_Joao.Location = new System.Drawing.Point(12, 120);
            this.cb_Joao.Name = "cb_Joao";
            this.cb_Joao.Size = new System.Drawing.Size(49, 17);
            this.cb_Joao.TabIndex = 7;
            this.cb_Joao.Text = "Joao";
            this.cb_Joao.UseVisualStyleBackColor = true;
            this.cb_Joao.CheckedChanged += new System.EventHandler(this.cb_Joao_CheckedChanged);
            // 
            // cb_Jocimar
            // 
            this.cb_Jocimar.AutoSize = true;
            this.cb_Jocimar.Location = new System.Drawing.Point(12, 88);
            this.cb_Jocimar.Name = "cb_Jocimar";
            this.cb_Jocimar.Size = new System.Drawing.Size(62, 17);
            this.cb_Jocimar.TabIndex = 6;
            this.cb_Jocimar.Text = "Jocimar";
            this.cb_Jocimar.UseVisualStyleBackColor = true;
            this.cb_Jocimar.CheckedChanged += new System.EventHandler(this.cb_Jocimar_CheckedChanged);
            // 
            // cb_Livia
            // 
            this.cb_Livia.AutoSize = true;
            this.cb_Livia.Location = new System.Drawing.Point(12, 55);
            this.cb_Livia.Name = "cb_Livia";
            this.cb_Livia.Size = new System.Drawing.Size(48, 17);
            this.cb_Livia.TabIndex = 5;
            this.cb_Livia.Text = "Livia";
            this.cb_Livia.UseVisualStyleBackColor = true;
            this.cb_Livia.CheckedChanged += new System.EventHandler(this.cb_Livia_CheckedChanged);
            // 
            // cb_Felippe
            // 
            this.cb_Felippe.AutoSize = true;
            this.cb_Felippe.Location = new System.Drawing.Point(12, 22);
            this.cb_Felippe.Name = "cb_Felippe";
            this.cb_Felippe.Size = new System.Drawing.Size(60, 17);
            this.cb_Felippe.TabIndex = 4;
            this.cb_Felippe.Text = "Felippe";
            this.cb_Felippe.UseVisualStyleBackColor = true;
            this.cb_Felippe.CheckedChanged += new System.EventHandler(this.cb_Felippe_CheckedChanged);
            // 
            // F_CheckBox2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 450);
            this.Controls.Add(this.cb_Joao);
            this.Controls.Add(this.cb_Jocimar);
            this.Controls.Add(this.cb_Livia);
            this.Controls.Add(this.cb_Felippe);
            this.Name = "F_CheckBox2";
            this.Text = "CheckBox2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_Joao;
        private System.Windows.Forms.CheckBox cb_Jocimar;
        private System.Windows.Forms.CheckBox cb_Livia;
        private System.Windows.Forms.CheckBox cb_Felippe;
    }
}