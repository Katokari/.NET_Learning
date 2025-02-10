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
    public partial class frmCheckedList : Form
    {
        public frmCheckedList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5;  i++)
            {
                checkedListBox1.Items.Add("Item " + i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.Items.RemoveAt(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0;i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Str = "";
            for (int i = 0;i < checkedListBox1.CheckedItems.Count; i++)
            {
                Str += checkedListBox1.CheckedItems[i].ToString() + ", ";
            }
            Str = Str.Substring(0, Str.Length - 2);
            MessageBox.Show(Str, "Checked Items", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(checkedListBox1.Items[checkedListBox1.SelectedIndex].ToString(), "Selected Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
