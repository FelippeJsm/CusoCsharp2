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
    public partial class F_CheckBox : Form
    {
        List<CheckBox> Familiar = new List<CheckBox>(); //criação de uma lista
            
        public F_CheckBox()
        {
            //Adicionar itens a lista
            InitializeComponent();
            Familiar.Add(cb_Felippe);
            Familiar.Add(cb_Livia);
            Familiar.Add(cb_Jocimar);
            Familiar.Add(cb_Joao);
        }

        //Verificação da lista estar marcada ou não
        private void btn_NomesMarcados_Click(object sender, EventArgs e)
        {
            string txt = "";
            
            foreach (CheckBox t in Familiar)
            {
                if (t.Checked)
                {
                    txt += t.Text + ", ";
                }
            }

            MessageBox.Show(txt);
        }

//Verificar se está Marcado
        private void cb_mae_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_mae.Checked)
            {
                MessageBox.Show("Mãe Confere");
            }
        }

        private void btn_abir_Click(object sender, EventArgs e)
        {
            F_CheckBox2 f_CheckBox2 = new F_CheckBox2();
            f_CheckBox2.ShowDialog();
        }
    }
}
