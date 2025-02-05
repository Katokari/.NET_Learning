using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class frmBoxes : Form
    {
        public frmBoxes()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string Checked = $"{chkOnion.Checked.ToString()}, {chkTomato.Checked.ToString()}";
            MessageBox.Show(Checked, "Checked", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "";
            foreach (RadioButton rp in grpSize.Controls.OfType<RadioButton>()) { 
                if (rp.Checked)
                {
                    name = rp.Text;
                    break;
                }
            }
            MessageBox.Show(name, "Checked by user", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
