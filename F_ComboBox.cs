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
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_MostrarSelecionados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CombB_Familia.Text);
        }

        private void btn_LimparElementos_Click(object sender, EventArgs e)
        {
            CombB_Familia.Items.Clear();    
        }

        private void btn_ResetarElementos_Click(object sender, EventArgs e)
        {
            CombB_Familia.Items.Add("Felippe");
            CombB_Familia.Items.Add("Livia");
            CombB_Familia.Items.Add("Joao");
            CombB_Familia.Items.Add("Jocimar");
        }

        private void btn_AdicionarElementos_Click(object sender, EventArgs e)
        {
            if (tb_NovoFamiliar.Text != "")
            {
                //if (CombB_Familia.FindString(tb_NovoFamiliar.Text)>0);
                CombB_Familia.Items.Add(tb_NovoFamiliar.Text);   
            }
        }

        private void CombB_Familia_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_NovoFamiliar.Text = CombB_Familia.Text;
        }
    }
}
