using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        float PriceSize()
        {
            if (rdSmall.Checked)
            {
                return Convert.ToSingle(rdSmall.Tag);
            }
            if (rdMeduim.Checked)
            {
                return Convert.ToSingle(rdMeduim.Tag);
            }
            if (rdLarg.Checked)
            {
                return Convert.ToSingle(rdLarg.Tag);
            }
            return 0;

        }

        float PriceCrustType()
        {
            if (RadThinCrust.Checked)
            {
                return Convert.ToSingle(RadThinCrust.Tag);
            }
            else
            {
                return Convert.ToSingle(RadThinkCrust.Tag);
            }
        }

        float PriceToppings()
        {
            float totalprice = 0;

            if (checkBoxExtraChees.Checked)
            {
                totalprice += Convert.ToSingle(checkBoxExtraChees.Tag);
            }
            if (checkBoxMushrooms.Checked)
            {
                totalprice += Convert.ToSingle(checkBoxMushrooms.Tag);
            }
            if (checkBoxTomatoes.Checked)
            {
                totalprice += Convert.ToSingle(checkBoxTomatoes.Tag);
            }
            if (checkBoxOnion.Checked)
            {
                totalprice += Convert.ToSingle(checkBoxOnion.Tag);
            }
            if (checkBoxOlives.Checked)
            {
                totalprice += Convert.ToSingle(checkBoxOlives.Tag);
            }
            if (checkBoxGreenPappers.Checked)
            {
                totalprice += Convert.ToSingle(checkBoxGreenPappers.Tag);
            }
            return totalprice;
        }

        void UpdatePrice()
        {
            float TotalPrice = 0;

            TotalPrice = PriceSize() + PriceCrustType() + PriceToppings();
            
            labTotalPrice.Text = "$" + Convert.ToString(TotalPrice);
        }

        void UpdateSize()
        {

            UpdatePrice();

            if (rdSmall.Checked) 
            {
                LabSizeSummary.Text = "Small";
            }
            if (rdMeduim.Checked)
            {
                LabSizeSummary.Text = "Meduim";
            }
            if (rdLarg.Checked) 
            {
                LabSizeSummary.Text = "Larg";
            }

        }

        void UpdateCrustType()
        {
            UpdatePrice();

            if (RadThinCrust.Checked)
            {
                LabCrustSummary.Text = "Thin Crust";
            }
            else
            {
                LabCrustSummary.Text = "Think Crust";
            }

        }

        void UpdateToppings()
        {
            UpdatePrice();

            string toppings = "";

            if (checkBoxExtraChees.Checked)
            {
                toppings = "Extra Chees";
            }

            if (checkBoxMushrooms.Checked)
            {
                toppings += ", Mushrooms";
            }

            if (checkBoxTomatoes.Checked)
            {
                toppings += ", Tomatoes";
            }

            if (checkBoxOnion.Checked)
            {
                toppings += ", Onion";
            }

            if (checkBoxOlives.Checked)
            {
                toppings += ", Olives";
            }

            if (checkBoxGreenPappers.Checked)
            {
                toppings += ", Green Pappers";
            }

            if (toppings.StartsWith(","))
            {
                toppings = toppings.Substring(1, toppings.Length - 1).Trim();
            }

            if (toppings == "")
                toppings = "No toppings";

            LabToppingsSummay.Text = toppings;
        }

        void UpdatWhereToEat()
        {
            if (RadEatIn.Checked)
                LabWhereToEatSummary.Text = "Eat In";
            else
                LabWhereToEatSummary.Text = "Take out";
        }

        void UpdateOrdarSummary()
        {
            UpdateSize();
            UpdateCrustType();
            UpdateToppings();
            UpdatWhereToEat();
            UpdatePrice();
        }

        void ResetButton()
        {
            //restet panal
            panelSize.Enabled = true;
            panelToppings.Enabled = true;
            panelCrustType.Enabled = true;
            panelWhereToEat.Enabled = true;

            //reset Size
            rdSmall.Checked = true;

            //reset toppings
            checkBoxExtraChees.Checked = false;
            checkBoxMushrooms.Checked = false;
            checkBoxTomatoes.Checked = false;
            checkBoxOnion.Checked = false;
            checkBoxOlives.Checked = false;
            checkBoxGreenPappers.Checked = false;

            //reset where to eat
            RadEatIn.Checked = true;

            //reset crust type
            RadThinCrust.Checked = true;

            //reset botton
            ButtonOrederPizza.Enabled = true;   
        }

        void OrderButton()
        {
            if (MessageBox.Show("Confirm Order", "Confirm",
        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Confirm", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ButtonOrederPizza.Enabled = false;
                panelSize.Enabled = false;
                panelToppings.Enabled = false;
                panelCrustType.Enabled = false;
                panelWhereToEat.Enabled = false;
            }
            else
            {
                ResetButton();

            }
        }

        
        
        // groub Size....
        private void rdSmall_CheckedChanged(object sender, EventArgs e) => UpdateSize();
        private void rdMeduim_CheckedChanged(object sender, EventArgs e) => UpdateSize();
        private void rdLarg_CheckedChanged(object sender, EventArgs e) => UpdateSize();


        // groub Crust
        private void RadThinCrust_CheckedChanged(object sender, EventArgs e) => UpdateCrustType();
        private void RadThinkCrust_CheckedChanged(object sender, EventArgs e) => UpdateCrustType();

    

        // groub Toppings
        private void checkBoxExtraChees_CheckedChanged(object sender, EventArgs e) => UpdateToppings();
        private void checkBoxMushrooms_CheckedChanged(object sender, EventArgs e) => UpdateToppings();
        private void checkBoxTomatoes_CheckedChanged(object sender, EventArgs e) => UpdateToppings();
        private void checkBoxOnion_CheckedChanged(object sender, EventArgs e) => UpdateToppings();
        private void checkBoxOlives_CheckedChanged(object sender, EventArgs e) => UpdateToppings();
        private void checkBoxGreenPappers_CheckedChanged(object sender, EventArgs e) => UpdateToppings();
     
        
        // groub Where To Eat
        private void RadEatIn_CheckedChanged(object sender, EventArgs e) => UpdatWhereToEat();
        private void RadTakeOut_CheckedChanged(object sender, EventArgs e) => UpdatWhereToEat();



        private void buttonOrederPizza_Click(object sender, EventArgs e) => OrderButton();
    
        private void buttonResetForm_Click(object sender, EventArgs e) => ResetButton();
       
        private void MainMenu_Load(object sender, EventArgs e) => UpdateOrdarSummary();










    }
}
