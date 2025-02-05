using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        private int CalculatePrice()
        {
            int Price = 0;
            foreach(RadioButton rp in gbSize.Controls.OfType<RadioButton>())
            {
                Price += (rp.Checked) ? Convert.ToInt32(rp.Tag) : 0;
            }
            foreach (CheckBox chk in gbToppings.Controls.OfType<CheckBox>())
            {
                Price += (chk.Checked) ? Convert.ToInt32(chk.Tag) : 0;
            }
            return Price;
        }

        void UpdatePrice()
        {
            labPrice.Text = CalculatePrice().ToString();
        }

        void UpdateSize()
        {
            foreach (RadioButton radio in gbSize.Controls.OfType<RadioButton>())
                if (radio.Checked)
                    labSize.Text = radio.Text;
        }

        void UpdateCrust()
        {
            foreach (RadioButton radio in gbCrust.Controls.OfType<RadioButton>())
                if (radio.Checked)
                    labCrust.Text = radio.Text;
        }

        void UpdateWhereToEat()
        {
            foreach (RadioButton radio in gbWhereToEat.Controls.OfType<RadioButton>())
                if (radio.Checked)
                    labWhereToEat.Text = radio.Text;
        }

        void UpdateToppings()
        {
            string Toppings = "";
            foreach (CheckBox chk in gbToppings.Controls.OfType<CheckBox>())
                if (chk.Checked)
                    Toppings += chk.Text + ", ";
            labToppings.Text = Toppings.Substring(0, Toppings.Length - 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labCrust.Text = rpThin.Text;
            labSize.Text = rpSmall.Text;
            labWhereToEat.Text = rpEatIn.Text;
            UpdatePrice();
        }

        private void rpSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            UpdateSize();
        }

        private void rpMid_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            UpdateSize();
        }

        private void rpBig_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            UpdateSize();
        }

        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            UpdateToppings();
        }

        private void chkMushroom_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            UpdateToppings();
        }

        private void chkTomato_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            UpdateToppings();
        }

        private void chkGreenPepper_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            UpdateToppings();
        }

        private void chkOlive_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            UpdateToppings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Order Pizza", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                MessageBox.Show("Success", "Ordered Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbSize.Enabled = false;
                gbCrust.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(CheckBox chk in gbToppings.Controls.OfType<CheckBox>())
            {
                chk.Checked = false;
            }
            rpSmall.Checked = true;
            rpEatIn.Checked = true;
            rpThin.Checked = true;
            gbSize.Enabled = true;
            gbCrust.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
        }

        private void rpThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rpThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rpEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rpTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }
    }
}
