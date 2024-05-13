namespace Felippe_2
{
    partial class F_CheckBox
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
            this.cb_Felippe = new System.Windows.Forms.CheckBox();
            this.cb_Livia = new System.Windows.Forms.CheckBox();
            this.cb_Jocimar = new System.Windows.Forms.CheckBox();
            this.cb_Joao = new System.Windows.Forms.CheckBox();
            this.btn_NomesMarcados = new System.Windows.Forms.Button();
            this.cb_mae = new System.Windows.Forms.CheckBox();
            this.btn_abir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Felippe
            // 
            this.cb_Felippe.AutoSize = true;
            this.cb_Felippe.Location = new System.Drawing.Point(12, 12);
            this.cb_Felippe.Name = "cb_Felippe";
            this.cb_Felippe.Size = new System.Drawing.Size(60, 17);
            this.cb_Felippe.TabIndex = 0;
            this.cb_Felippe.Text = "Felippe";
            this.cb_Felippe.UseVisualStyleBackColor = true;
            // 
            // cb_Livia
            // 
            this.cb_Livia.AutoSize = true;
            this.cb_Livia.Location = new System.Drawing.Point(12, 45);
            this.cb_Livia.Name = "cb_Livia";
            this.cb_Livia.Size = new System.Drawing.Size(48, 17);
            this.cb_Livia.TabIndex = 1;
            this.cb_Livia.Text = "Livia";
            this.cb_Livia.UseVisualStyleBackColor = true;
            // 
            // cb_Jocimar
            // 
            this.cb_Jocimar.AutoSize = true;
            this.cb_Jocimar.Location = new System.Drawing.Point(12, 78);
            this.cb_Jocimar.Name = "cb_Jocimar";
            this.cb_Jocimar.Size = new System.Drawing.Size(62, 17);
            this.cb_Jocimar.TabIndex = 2;
            this.cb_Jocimar.Text = "Jocimar";
            this.cb_Jocimar.UseVisualStyleBackColor = true;
            // 
            // cb_Joao
            // 
            this.cb_Joao.AutoSize = true;
            this.cb_Joao.Location = new System.Drawing.Point(12, 110);
            this.cb_Joao.Name = "cb_Joao";
            this.cb_Joao.Size = new System.Drawing.Size(49, 17);
            this.cb_Joao.TabIndex = 3;
            this.cb_Joao.Text = "Joao";
            this.cb_Joao.UseVisualStyleBackColor = true;
            // 
            // btn_NomesMarcados
            // 
            this.btn_NomesMarcados.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_NomesMarcados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_NomesMarcados.Location = new System.Drawing.Point(172, 13);
            this.btn_NomesMarcados.Name = "btn_NomesMarcados";
            this.btn_NomesMarcados.Size = new System.Drawing.Size(236, 31);
            this.btn_NomesMarcados.TabIndex = 4;
            this.btn_NomesMarcados.Text = "Nomes Marcados";
            this.btn_NomesMarcados.UseVisualStyleBackColor = false;
            this.btn_NomesMarcados.Click += new System.EventHandler(this.btn_NomesMarcados_Click);
            // 
            // cb_mae
            // 
            this.cb_mae.AutoSize = true;
            this.cb_mae.Location = new System.Drawing.Point(12, 175);
            this.cb_mae.Name = "cb_mae";
            this.cb_mae.Size = new System.Drawing.Size(47, 17);
            this.cb_mae.TabIndex = 5;
            this.cb_mae.Text = "Mãe";
            this.cb_mae.UseVisualStyleBackColor = true;
            this.cb_mae.CheckedChanged += new System.EventHandler(this.cb_mae_CheckedChanged);
            // 
            // btn_abir
            // 
            this.btn_abir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_abir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_abir.Location = new System.Drawing.Point(172, 64);
            this.btn_abir.Name = "btn_abir";
            this.btn_abir.Size = new System.Drawing.Size(236, 31);
            this.btn_abir.TabIndex = 6;
            this.btn_abir.Text = "Abrir Forms";
            this.btn_abir.UseVisualStyleBackColor = false;
            this.btn_abir.Click += new System.EventHandler(this.btn_abir_Click);
            // 
            // F_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.btn_abir);
            this.Controls.Add(this.cb_mae);
            this.Controls.Add(this.btn_NomesMarcados);
            this.Controls.Add(this.cb_Joao);
            this.Controls.Add(this.cb_Jocimar);
            this.Controls.Add(this.cb_Livia);
            this.Controls.Add(this.cb_Felippe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_CheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_NomesMarcados;
        private System.Windows.Forms.CheckBox cb_mae;
        public System.Windows.Forms.CheckBox cb_Felippe;
        public System.Windows.Forms.CheckBox cb_Livia;
        public System.Windows.Forms.CheckBox cb_Jocimar;
        public System.Windows.Forms.CheckBox cb_Joao;
        private System.Windows.Forms.Button btn_abir;
    }
}