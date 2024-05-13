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
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach (string t in clb_Familia.CheckedItems)
            {
                txt += t + ", ";
            }

            MessageBox.Show(txt);
        }

        private void btn_LimparLista_Click(object sender, EventArgs e)
        {
            clb_Familia.Items.Clear();
        }

        private void btn_ResetarLista_Click(object sender, EventArgs e)
        {

            clb_Familia.Items.Add("CARRO", true);

        }
    }
}
