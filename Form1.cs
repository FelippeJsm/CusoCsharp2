using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Felippe_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            tb_listaNomes.Text += tb_nomes.Text + ", ";
            tb_nomes.Clear();
            tb_nomes.Focus();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_listaNomes.Clear();
            tb_nomes.Clear();
            tb_nomes.Focus();
        }

        private void btn_MostrarLista_Click(object sender, EventArgs e)
        {
            F_ListaNomes f_ListaNomes = new F_ListaNomes(tb_listaNomes.Text);
            f_ListaNomes.ShowDialog();
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox f_CheckBox = new F_CheckBox();
            f_CheckBox.ShowDialog();
            
                             
            
        }

        private void cheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
            f_CheckedListBox.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ComboBox f_ComboBox = new F_ComboBox();
            f_ComboBox.ShowDialog();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DateTimePicker f_DateTimePicker = new F_DateTimePicker(); 
            f_DateTimePicker.ShowDialog();
        }
    }
}
