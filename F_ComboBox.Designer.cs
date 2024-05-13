namespace Felippe_2
{
    partial class F_ComboBox
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
            this.CombB_Familia = new System.Windows.Forms.ComboBox();
            this.btn_MostrarSelecionados = new System.Windows.Forms.Button();
            this.btn_LimparElementos = new System.Windows.Forms.Button();
            this.btn_ResetarElementos = new System.Windows.Forms.Button();
            this.btn_AdicionarElementos = new System.Windows.Forms.Button();
            this.tb_NovoFamiliar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CombB_Familia
            // 
            this.CombB_Familia.FormattingEnabled = true;
            this.CombB_Familia.Items.AddRange(new object[] {
            "Felippe",
            "Livia",
            "Joao",
            "Jocimar"});
            this.CombB_Familia.Location = new System.Drawing.Point(13, 13);
            this.CombB_Familia.Name = "CombB_Familia";
            this.CombB_Familia.Size = new System.Drawing.Size(182, 21);
            this.CombB_Familia.TabIndex = 0;
            this.CombB_Familia.SelectedIndexChanged += new System.EventHandler(this.CombB_Familia_SelectedIndexChanged);
            // 
            // btn_MostrarSelecionados
            // 
            this.btn_MostrarSelecionados.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_MostrarSelecionados.Location = new System.Drawing.Point(202, 10);
            this.btn_MostrarSelecionados.Name = "btn_MostrarSelecionados";
            this.btn_MostrarSelecionados.Size = new System.Drawing.Size(152, 23);
            this.btn_MostrarSelecionados.TabIndex = 1;
            this.btn_MostrarSelecionados.Text = "Mostrar Selecionados";
            this.btn_MostrarSelecionados.UseVisualStyleBackColor = false;
            this.btn_MostrarSelecionados.Click += new System.EventHandler(this.btn_MostrarSelecionados_Click);
            // 
            // btn_LimparElementos
            // 
            this.btn_LimparElementos.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_LimparElementos.Location = new System.Drawing.Point(202, 39);
            this.btn_LimparElementos.Name = "btn_LimparElementos";
            this.btn_LimparElementos.Size = new System.Drawing.Size(152, 23);
            this.btn_LimparElementos.TabIndex = 2;
            this.btn_LimparElementos.Text = "Limpar Elementos";
            this.btn_LimparElementos.UseVisualStyleBackColor = false;
            this.btn_LimparElementos.Click += new System.EventHandler(this.btn_LimparElementos_Click);
            // 
            // btn_ResetarElementos
            // 
            this.btn_ResetarElementos.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_ResetarElementos.Location = new System.Drawing.Point(202, 68);
            this.btn_ResetarElementos.Name = "btn_ResetarElementos";
            this.btn_ResetarElementos.Size = new System.Drawing.Size(152, 23);
            this.btn_ResetarElementos.TabIndex = 3;
            this.btn_ResetarElementos.Text = "Resetar Elementos";
            this.btn_ResetarElementos.UseVisualStyleBackColor = false;
            this.btn_ResetarElementos.Click += new System.EventHandler(this.btn_ResetarElementos_Click);
            // 
            // btn_AdicionarElementos
            // 
            this.btn_AdicionarElementos.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_AdicionarElementos.Location = new System.Drawing.Point(202, 162);
            this.btn_AdicionarElementos.Name = "btn_AdicionarElementos";
            this.btn_AdicionarElementos.Size = new System.Drawing.Size(152, 23);
            this.btn_AdicionarElementos.TabIndex = 4;
            this.btn_AdicionarElementos.Text = "Adicionar Elemento";
            this.btn_AdicionarElementos.UseVisualStyleBackColor = false;
            this.btn_AdicionarElementos.Click += new System.EventHandler(this.btn_AdicionarElementos_Click);
            // 
            // tb_NovoFamiliar
            // 
            this.tb_NovoFamiliar.Location = new System.Drawing.Point(202, 136);
            this.tb_NovoFamiliar.Name = "tb_NovoFamiliar";
            this.tb_NovoFamiliar.Size = new System.Drawing.Size(152, 20);
            this.tb_NovoFamiliar.TabIndex = 5;
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.tb_NovoFamiliar);
            this.Controls.Add(this.btn_AdicionarElementos);
            this.Controls.Add(this.btn_ResetarElementos);
            this.Controls.Add(this.btn_LimparElementos);
            this.Controls.Add(this.btn_MostrarSelecionados);
            this.Controls.Add(this.CombB_Familia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CombB_Familia;
        private System.Windows.Forms.Button btn_MostrarSelecionados;
        private System.Windows.Forms.Button btn_LimparElementos;
        private System.Windows.Forms.Button btn_ResetarElementos;
        private System.Windows.Forms.Button btn_AdicionarElementos;
        private System.Windows.Forms.TextBox tb_NovoFamiliar;
    }
}