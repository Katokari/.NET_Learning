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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnShowForm1_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
            frm.Show();
        }

        private void btnForm1Dialog_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmBoxes();
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form frm = new frmMaskedTextBox();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new frmComboBox();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new frmLinkLable();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new frmCheckedList();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm = new frmTimePicker();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frm = new frmMonthCalendar();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form frm = new frmTimer();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form frm = new frmNotify();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm = new frmTreeViewer();
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form frm = new frmListView();
            frm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form frm = new frmDialogs();
            frm.Show();
        }
    }
}
