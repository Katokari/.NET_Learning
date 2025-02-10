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
    public partial class frmNotify : Form
    {
        public frmNotify()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Kato Meow";
            notifyIcon1.BalloonTipText = "Meow Meow";
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Meow Nyaa Nya!", "Meow!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
