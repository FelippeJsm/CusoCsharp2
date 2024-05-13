namespace Felippe_2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_nomes = new System.Windows.Forms.Label();
            this.tb_nomes = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tb_listaNomes = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_MostrarLista = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_nomes
            // 
            this.lb_nomes.AutoSize = true;
            this.lb_nomes.Location = new System.Drawing.Point(9, 103);
            this.lb_nomes.Name = "lb_nomes";
            this.lb_nomes.Size = new System.Drawing.Size(82, 13);
            this.lb_nomes.TabIndex = 0;
            this.lb_nomes.Text = "Digite um Nome";
            // 
            // tb_nomes
            // 
            this.tb_nomes.Location = new System.Drawing.Point(12, 120);
            this.tb_nomes.Name = "tb_nomes";
            this.tb_nomes.Size = new System.Drawing.Size(124, 20);
            this.tb_nomes.TabIndex = 1;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_adicionar.Location = new System.Drawing.Point(142, 118);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(122, 23);
            this.btn_adicionar.TabIndex = 2;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // tb_listaNomes
            // 
            this.tb_listaNomes.Location = new System.Drawing.Point(12, 146);
            this.tb_listaNomes.Multiline = true;
            this.tb_listaNomes.Name = "tb_listaNomes";
            this.tb_listaNomes.Size = new System.Drawing.Size(252, 165);
            this.tb_listaNomes.TabIndex = 3;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_limpar.Location = new System.Drawing.Point(12, 318);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(252, 32);
            this.btn_limpar.TabIndex = 4;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_MostrarLista
            // 
            this.btn_MostrarLista.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_MostrarLista.Location = new System.Drawing.Point(12, 356);
            this.btn_MostrarLista.Name = "btn_MostrarLista";
            this.btn_MostrarLista.Size = new System.Drawing.Size(252, 32);
            this.btn_MostrarLista.TabIndex = 5;
            this.btn_MostrarLista.Text = "Mostrar Nomes";
            this.btn_MostrarLista.UseVisualStyleBackColor = false;
            this.btn_MostrarLista.Click += new System.EventHandler(this.btn_MostrarLista_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.OrangeRed;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(275, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxToolStripMenuItem,
            this.cheToolStripMenuItem,
            this.comboBoxToolStripMenuItem,
            this.dateTimePickerToolStripMenuItem});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.componentesToolStripMenuItem.Text = "COMPONENTES";
            // 
            // checkBoxToolStripMenuItem
            // 
            this.checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            this.checkBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkBoxToolStripMenuItem.Text = "CheckBox";
            this.checkBoxToolStripMenuItem.Click += new System.EventHandler(this.checkBoxToolStripMenuItem_Click);
            // 
            // cheToolStripMenuItem
            // 
            this.cheToolStripMenuItem.Name = "cheToolStripMenuItem";
            this.cheToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cheToolStripMenuItem.Text = "CheckedListBox";
            this.cheToolStripMenuItem.Click += new System.EventHandler(this.cheToolStripMenuItem_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comboBoxToolStripMenuItem.Text = "ComboBox";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // dateTimePickerToolStripMenuItem
            // 
            this.dateTimePickerToolStripMenuItem.Name = "dateTimePickerToolStripMenuItem";
            this.dateTimePickerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dateTimePickerToolStripMenuItem.Text = "DateTimePicker";
            this.dateTimePickerToolStripMenuItem.Click += new System.EventHandler(this.dateTimePickerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(275, 450);
            this.Controls.Add(this.btn_MostrarLista);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.tb_listaNomes);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.tb_nomes);
            this.Controls.Add(this.lb_nomes);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nomes;
        private System.Windows.Forms.TextBox tb_nomes;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TextBox tb_listaNomes;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_MostrarLista;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateTimePickerToolStripMenuItem;
    }
}

