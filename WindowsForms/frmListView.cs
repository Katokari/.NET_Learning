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
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1 == null || maskedTextBox1 == null)
                return;

            ListViewItem item = new ListViewItem(maskedTextBox1.Text);
            item.SubItems.Add(textBox1.Text);
            
            if (rbF.Checked)
            {
                item.ImageIndex = 0;
            } else
            {
                item.ImageIndex = 1;
            }

            listView1.Items.Add(item);
            textBox1.Clear();
            maskedTextBox1.Clear();
            maskedTextBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add("Perosn " + i);
                if (i % 2 == 0)
                {
                    item.ImageIndex = 0;
                }
                else { item.ImageIndex = 1; }

                listView1.Items.Add(item);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(listView1.SelectedItems[0].ToString(), "Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
