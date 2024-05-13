namespace Felippe_2
{
    partial class F_CheckedListBox
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
            this.clb_Familia = new System.Windows.Forms.CheckedListBox();
            this.btn_mostrarSelecionados = new System.Windows.Forms.Button();
            this.btn_LimparLista = new System.Windows.Forms.Button();
            this.btn_ResetarLista = new System.Windows.Forms.Button();
            this.btn_AdicionarFamiliar = new System.Windows.Forms.Button();
            this.tb_NovoFamiliar = new System.Windows.Forms.TextBox();
            this.lb_Familiar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_Familia
            // 
            this.clb_Familia.FormattingEnabled = true;
            this.clb_Familia.Items.AddRange(new object[] {
            "Felippe",
            "Livia",
            "Joao",
            "Jocimar"});
            this.clb_Familia.Location = new System.Drawing.Point(13, 13);
            this.clb_Familia.Name = "clb_Familia";
            this.clb_Familia.Size = new System.Drawing.Size(153, 274);
            this.clb_Familia.TabIndex = 0;
            // 
            // btn_mostrarSelecionados
            // 
            this.btn_mostrarSelecionados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_mostrarSelecionados.Location = new System.Drawing.Point(172, 13);
            this.btn_mostrarSelecionados.Name = "btn_mostrarSelecionados";
            this.btn_mostrarSelecionados.Size = new System.Drawing.Size(164, 31);
            this.btn_mostrarSelecionados.TabIndex = 1;
            this.btn_mostrarSelecionados.Text = "Mostrar Selecionados";
            this.btn_mostrarSelecionados.UseVisualStyleBackColor = false;
            this.btn_mostrarSelecionados.Click += new System.EventHandler(this.btn_mostrarSelecionados_Click);
            // 
            // btn_LimparLista
            // 
            this.btn_LimparLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_LimparLista.Location = new System.Drawing.Point(171, 50);
            this.btn_LimparLista.Name = "btn_LimparLista";
            this.btn_LimparLista.Size = new System.Drawing.Size(164, 31);
            this.btn_LimparLista.TabIndex = 2;
            this.btn_LimparLista.Text = "Limpar Lista";
            this.btn_LimparLista.UseVisualStyleBackColor = false;
            this.btn_LimparLista.Click += new System.EventHandler(this.btn_LimparLista_Click);
            // 
            // btn_ResetarLista
            // 
            this.btn_ResetarLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ResetarLista.Location = new System.Drawing.Point(172, 87);
            this.btn_ResetarLista.Name = "btn_ResetarLista";
            this.btn_ResetarLista.Size = new System.Drawing.Size(164, 31);
            this.btn_ResetarLista.TabIndex = 3;
            this.btn_ResetarLista.Text = "Resetar Lista";
            this.btn_ResetarLista.UseVisualStyleBackColor = false;
            this.btn_ResetarLista.Click += new System.EventHandler(this.btn_ResetarLista_Click);
            // 
            // btn_AdicionarFamiliar
            // 
            this.btn_AdicionarFamiliar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_AdicionarFamiliar.Location = new System.Drawing.Point(171, 214);
            this.btn_AdicionarFamiliar.Name = "btn_AdicionarFamiliar";
            this.btn_AdicionarFamiliar.Size = new System.Drawing.Size(164, 31);
            this.btn_AdicionarFamiliar.TabIndex = 4;
            this.btn_AdicionarFamiliar.Text = "Adicionar Familiar";
            this.btn_AdicionarFamiliar.UseVisualStyleBackColor = false;
            // 
            // tb_NovoFamiliar
            // 
            this.tb_NovoFamiliar.Location = new System.Drawing.Point(171, 251);
            this.tb_NovoFamiliar.Name = "tb_NovoFamiliar";
            this.tb_NovoFamiliar.Size = new System.Drawing.Size(164, 20);
            this.tb_NovoFamiliar.TabIndex = 5;
            // 
            // lb_Familiar
            // 
            this.lb_Familiar.AutoSize = true;
            this.lb_Familiar.Location = new System.Drawing.Point(169, 274);
            this.lb_Familiar.Name = "lb_Familiar";
            this.lb_Familiar.Size = new System.Drawing.Size(144, 13);
            this.lb_Familiar.TabIndex = 6;
            this.lb_Familiar.Text = "Digite o Nome de um Familiar";
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.lb_Familiar);
            this.Controls.Add(this.tb_NovoFamiliar);
            this.Controls.Add(this.btn_AdicionarFamiliar);
            this.Controls.Add(this.btn_ResetarLista);
            this.Controls.Add(this.btn_LimparLista);
            this.Controls.Add(this.btn_mostrarSelecionados);
            this.Controls.Add(this.clb_Familia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedLisBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_Familia;
        private System.Windows.Forms.Button btn_mostrarSelecionados;
        private System.Windows.Forms.Button btn_LimparLista;
        private System.Windows.Forms.Button btn_ResetarLista;
        private System.Windows.Forms.Button btn_AdicionarFamiliar;
        private System.Windows.Forms.TextBox tb_NovoFamiliar;
        private System.Windows.Forms.Label lb_Familiar;
    }
}