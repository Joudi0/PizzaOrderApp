using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        float price = 0;
        public Form1()
        {
            InitializeComponent();
        }
        void calculate_And_Update_Size()
        {
            if (rbSmall.Checked)
            {
                price = 10;
                lblSize.Text = "Small";
            }
            else if (rbMedium.Checked)
            {
                price = 15;
                lblSize.Text = "Medium";
            }
            else if (rbLarge.Checked)
            {
                price = 20;
                lblSize.Text = "Large";
            }
            else
            {
                price = 0;
                lblSize.Text = "Choose a Size";
            }
        }

        void update_WhereToEat()
        {
            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In";
            }
            else
            {
                lblWhereToEat.Text = "Take Away";
            }
        }

        void update_Crust()
        {
            if (rbThin.Checked)
            {
                lblCrust.Text = "Thin";
            }
            else if(rbThick.Checked)
            {
                price += 2;
                lblCrust.Text = "Thick";
            }
            else
            {
                lblCrust.Text = "Choose a crust";
            }
        }

        void calculate_Total_Price()
        {
            calculate_And_Update_Size();
            update_Crust();
            price += toppingPrice();
        }

        void update_Total_Price()
        {
            lblTotalPrice.Text = $"Price: {price}$";
        }

        public void Bill()
        {
            update_WhereToEat();
            calculate_Total_Price();
            update_Total_Price();
        }

        public float toppingPrice()
        {
            string toppings = "";
            int localPrice = 0;
            if (chkTomatoes.Checked)
            {
                localPrice += 2;
                toppings += "Tomatoes | ";
            }
            if (chkOnion.Checked)
            {
                localPrice += 3;
                toppings += "Onion | ";
            }
            if (chkGreenPeppers.Checked)
            {
                localPrice += 1;
                toppings += "GreebPeppers\n";
            }
            if (chkOlives.Checked)
            {
                localPrice += 2;
                toppings += "Olives | ";
            }
            if (chkMushrooms.Checked)
            {
                localPrice += 3;
                toppings += "Mushrooms | ";
            }
            if (chkExtraCheese.Checked)
            {
                localPrice += 4;
                toppings += "ExtraCheese";
            }
            if (toppings.Length > 0)
            {
                lblToppings.Text = toppings;
            }
            else
            {
                lblToppings.Text = "Nothing";
            }
            return localPrice;
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            Bill();
        }

        void disable_Groups()
        {
            gbCrust.Enabled = false;
            gbSize.Enabled = false;
            gbToppings.Enabled = false;
            gbWheteToEat.Enabled = false;
        }

        void enable_Groups()
        {
            gbCrust.Enabled = true;
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbWheteToEat.Enabled = true;
        }

        void default_Values()
        {
            rbEatIn.Checked = true;
            rbTakeAway.Checked = false;
            rbSmall.Checked = true;
            rbMedium.Checked = false;
            rbLarge.Checked = false;
            rbThin.Checked = true;
            rbThick.Checked = false;
            chkExtraCheese.Checked = false;
            chkMushrooms.Checked = false;
            chkGreenPeppers.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            enable_Groups();
            default_Values();
            price = 10;
            Bill();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                disable_Groups();
                Bill();
            }

        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            Bill();

        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            Bill();

        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            Bill();

        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            Bill();

        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            Bill();

        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            Bill();

        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            Bill();

        }

        private void chkGreebPeppers_CheckedChanged(object sender, EventArgs e)
        {
            Bill();

        }

        private void rbThink_CheckedChanged(object sender, EventArgs e)
        {
            Bill();

        }

        private void rbTakeAway_CheckedChanged(object sender, EventArgs e)
        {
            Bill();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            Bill();
        }
    }
}
