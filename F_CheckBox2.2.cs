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
    public partial class F_CheckBox2 : Form
    {
        public F_CheckBox FCB;
        public F_CheckBox2()
        {
            InitializeComponent();
            if(Application.OpenForms["F_CheckBox"].Created)
            {
                FCB = Application.OpenForms["F_CheckBox"] as F_CheckBox;
                cb_Felippe.Checked = FCB.cb_Felippe.Checked;
                cb_Livia.Checked = FCB.cb_Livia.Checked;
                cb_Jocimar.Checked = FCB.cb_Jocimar.Checked;
                cb_Joao.Checked = FCB.cb_Joao.Checked;
            }
            
        }

        private void cb_Felippe_CheckedChanged(object sender, EventArgs e)
        {
            FCB.cb_Felippe.Checked = cb_Felippe.Checked;    
        }

        private void cb_Livia_CheckedChanged(object sender, EventArgs e)
        {
            FCB.cb_Livia.Checked = cb_Livia.Checked;
        }

        private void cb_Jocimar_CheckedChanged(object sender, EventArgs e)
        {
            FCB.cb_Jocimar.Checked = cb_Jocimar.Checked;
        }

        private void cb_Joao_CheckedChanged(object sender, EventArgs e)
        {
            FCB.cb_Joao.Checked = cb_Joao.Checked;  
        }
    }
}
