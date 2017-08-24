using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodResturantSystem
{
    public partial class FastFoodResturantUI : Form
    {
        const double Price_Fries = 35;
        const double Price_Salad = 25;
        const double Price_HumBurger = 80;
        const double Price_OnionRings = 32;
        const double Price_ChickenSalad = 45;
        const double Price_FishSandwitch = 85;
        const double Price_ChickenSandwitch = 90;
        const double Price_CheeseSandwitch = 48;
        const double Price_HashBrown = 45;
        const double Price_ToastedBagel = 24;
        const double Price_PineappleStick = 30;
        const double Price_ChocklateMuffin = 75;
        const double Price_PancakeSyrup = 60;
        const double Price_Tea = 10;
        const double Price_Cola = 18;
        const double Price_Coffee = 25;
        const double Price_Orange = 30;
        const double Price_BottleWater = 30;
        const double Price_VanillaCone = 45;
        const double Price_VanillaShake = 75;
        const double Price_StrawberryShake = 120;
        const double Price_ChocklateMilkShake = 150;
        const double Tax_Rate = 7;

        private double iTax, iSubTotal, iTotal;

        public FastFoodResturantUI()
        {
            InitializeComponent();
        }
        //===================================Exit=================================
        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Are You Sure Want to Exit?","Fast Food",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        //===================================ResetTextBoxes()=================================
        private void ResetTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        //===================================ResetCheckBoxes()=================================
        private void ResetCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        public void ResetOther()
        {
            changeButton.Text = "";
            taxButton.Text = "";
            subtotalButton.Text = "";
            ttlButton.Text = "";
            paymentComboBox.SelectedIndex = 0;
        }
        //===================================EnableTextBoxes()=================================
        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        //===================================resetButton_Click=================================
        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetTextBoxes();
            ResetCheckBoxes();
            ResetOther();
        }
        //===================================Form1_Load=================================
        private void Form1_Load(object sender, EventArgs e)
        {
            paymentComboBox.Items.Add(" ");
            paymentComboBox.Items.Add("Cash");
            paymentComboBox.Items.Add("Master Card");
            paymentComboBox.Items.Add("Visa Card");
            paymentComboBox.Items.Add("Debit Card");

            EnableTextBoxes();
        }

        private void friesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (friesCheckBox.Checked == true)
            {
                friesTextBox.Enabled = true;
                friesTextBox.Text = "";
                friesTextBox.Focus();
            }
            else
            {
                friesTextBox.Enabled = false;
                friesTextBox.Text = "0";
            }
        }

        private void saladCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (saladCheckBox.Checked == true)
            {
                saladTextBox.Enabled = true;
                saladTextBox.Text = "";
                saladTextBox.Focus();
            }
            else
            {
                saladTextBox.Enabled = false;
                saladTextBox.Text = "0";
            }
        }

        private void humburgerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (humburgerCheckBox.Checked == true)
            {
                humburgerTextBox.Enabled = true;
                humburgerTextBox.Text = "";
                humburgerTextBox.Focus();
            }
            else
            {
                humburgerTextBox.Enabled = false;
                humburgerTextBox.Text = "0";
            }
        }

        private void onionringsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (onionringsCheckBox.Checked == true)
            {
                onionringsTextBox.Enabled = true;
                onionringsTextBox.Text = "";
                onionringsTextBox.Focus();
            }
            else
            {
                onionringsTextBox.Enabled = false;
                onionringsTextBox.Text = "0";
            }
        }

        private void chickensaladCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (chickensaladCheckBox.Checked == true)
            {
                chickensaladTextBox.Enabled = true;
                chickensaladTextBox.Text = "";
                chickensaladTextBox.Focus();
            }
            else
            {
                chickensaladTextBox.Enabled = false;
                chickensaladTextBox.Text = "0";
            }
        }

        private void fishsandwichCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fishsandwichCheckBox.Checked == true)
            {
                fishsandwichTextBox.Enabled = true;
                fishsandwichTextBox.Text = "";
                fishsandwichTextBox.Focus();
            }
            else
            {
                fishsandwichTextBox.Enabled = false;
                fishsandwichTextBox.Text = "0";
            }
        }

        private void cheesesandwichCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cheesesandwichCheckBox.Checked == true)
            {
                cheesesandwichTextBox.Enabled = true;
                cheesesandwichTextBox.Text = "";
                cheesesandwichTextBox.Focus();
            }
            else
            {
                cheesesandwichTextBox.Enabled = false;
                cheesesandwichTextBox.Text = "0";
            }
        }

        private void chickensandwichCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (chickensandwichCheckBox.Checked == true)
            {
                chickensandwichTextBox.Enabled = true;
                chickensandwichTextBox.Text = "";
                chickensandwichTextBox.Focus();
            }
            else
            {
                chickensandwichTextBox.Enabled = false;
                chickensandwichTextBox.Text = "0";
            }
        }

        private void hashbrownCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hashbrownCheckBox.Checked == true)
            {
                hashbrownTextBox.Enabled = true;
                hashbrownTextBox.Text = "";
                hashbrownTextBox.Focus();
            }
            else
            {
                hashbrownTextBox.Enabled = false;
                hashbrownTextBox.Text = "0";
            }
        }

        private void ToastedbagelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ToastedbagelCheckBox.Checked == true)
            {
                ToastedbagelTextBox.Enabled = true;
                ToastedbagelTextBox.Text = "";
                ToastedbagelTextBox.Focus();
            }
            else
            {
                ToastedbagelTextBox.Enabled = false;
                ToastedbagelTextBox.Text = "0";
            }
        }

        private void pineapplestickCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pineapplestickCheckBox.Checked == true)
            {
                pineapplestickTextBox.Enabled = true;
                pineapplestickTextBox.Text = "";
                pineapplestickTextBox.Focus();
            }
            else
            {
                pineapplestickTextBox.Enabled = false;
                pineapplestickTextBox.Text = "0";
            }
        }

        private void ChocklatemuffinCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ChocklatemuffinCheckBox.Checked == true)
            {
                ChocklatemuffinTextBox.Enabled = true;
                ChocklatemuffinTextBox.Text = "";
                ChocklatemuffinTextBox.Focus();
            }
            else
            {
                ChocklatemuffinTextBox.Enabled = false;
                ChocklatemuffinTextBox.Text = "0";
            }
        }

        private void pancakesyrupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pancakesyrupCheckBox.Checked == true)
            {
                pancakesyrupTextBox.Enabled = true;
                pancakesyrupTextBox.Text = "";
                pancakesyrupTextBox.Focus();
            }
            else
            {
                pancakesyrupTextBox.Enabled = false;
                pancakesyrupTextBox.Text = "0";
            }
        }

        private void teaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (teaCheckBox.Checked == true)
            {
                teaTextBox.Enabled = true;
                teaTextBox.Text = "";
                teaTextBox.Focus();
            }
            else
            {
                teaTextBox.Enabled = false;
                teaTextBox.Text = "0";
            }
        }

        private void colaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (colaCheckBox.Checked == true)
            {
                colaTextBox.Enabled = true;
                colaTextBox.Text = "";
                colaTextBox.Focus();
            }
            else
            {
                colaTextBox.Enabled = false;
                colaTextBox.Text = "0";
            }
        }

        private void coffeeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (coffeeCheckBox.Checked == true)
            {
                coffeeTextBox.Enabled = true;
                coffeeTextBox.Text = "";
                coffeeTextBox.Focus();
            }
            else
            {
                coffeeTextBox.Enabled = false;
                coffeeTextBox.Text = "0";
            }
        }

        private void orangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (orangeCheckBox.Checked == true)
            {
                orangeTextBox.Enabled = true;
                orangeTextBox.Text = "";
                orangeTextBox.Focus();
            }
            else
            {
                orangeTextBox.Enabled = false;
                orangeTextBox.Text = "0";
            }
        }

        private void bottlewaterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bottlewaterCheckBox.Checked == true)
            {
                bottlewaterTextBox.Enabled = true;
                bottlewaterTextBox.Text = "";
                bottlewaterTextBox.Focus();
            }
            else
            {
                bottlewaterTextBox.Enabled = false;
                bottlewaterTextBox.Text = "0";
            }
        }

        private void vanillaconeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (vanillaconeCheckBox.Checked == true)
            {
                vanillaconeTextBox.Enabled = true;
                vanillaconeTextBox.Text = "";
                vanillaconeTextBox.Focus();
            }
            else
            {
                vanillaconeTextBox.Enabled = false;
                vanillaconeTextBox.Text = "0";
            }
        }

        private void vanillashakeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (vanillashakeCheckBox.Checked == true)
            {
                vanillashakeTextBox.Enabled = true;
                vanillashakeTextBox.Text = "";
                vanillashakeTextBox.Focus();
            }
            else
            {
                vanillashakeTextBox.Enabled = false;
                vanillashakeTextBox.Text = "0";
            }
        }

        private void strawberryshakeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (strawberryshakeCheckBox.Checked == true)
            {
                strawberryshakeTextBox.Enabled = true;
                strawberryshakeTextBox.Text = "";
                strawberryshakeTextBox.Focus();
            }
            else
            {
                strawberryshakeTextBox.Enabled = false;
                strawberryshakeTextBox.Text = "0";
            }
        }

        private void choklatemilkshakeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (choklatemilkshakeCheckBox.Checked == true)
            {
                choklatemilkshakeTextBox.Enabled = true;
                choklatemilkshakeTextBox.Text = "";
                choklatemilkshakeTextBox.Focus();
            }
            else
            {
                choklatemilkshakeTextBox.Enabled = false;
                choklatemilkshakeTextBox.Text = "0";
            }
        }
        //=================================ComboBox Payment============================================
        private void paymentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (paymentComboBox.Text == "Cash")
            {
                paymentTextBox.Enabled = true;
                paymentTextBox.Text = "0";
                paymentTextBox.Focus();
            }
            else
            {
                paymentTextBox.Enabled = false;
                paymentTextBox.Text = "0";
            }
        }
        //======================================Total Button=============================================
        private void totalButton_Click(object sender, EventArgs e)
        {
            double[] itemCost = new double[22];

            itemCost[0] = Convert.ToDouble(friesTextBox.Text) * Price_Fries;
            itemCost[1] = Convert.ToDouble(saladTextBox.Text) * Price_Salad;
            itemCost[2] = Convert.ToDouble(humburgerTextBox.Text) * Price_HumBurger;
            itemCost[3] = Convert.ToDouble(onionringsTextBox.Text) * Price_OnionRings;
            itemCost[4] = Convert.ToDouble(chickensaladTextBox.Text) * Price_ChickenSalad;
            itemCost[5] = Convert.ToDouble(fishsandwichTextBox.Text) * Price_FishSandwitch;
            itemCost[6] = Convert.ToDouble(cheesesandwichTextBox.Text) * Price_CheeseSandwitch;
            itemCost[7] = Convert.ToDouble(chickensandwichTextBox.Text) * Price_ChickenSandwitch;
            itemCost[8] = Convert.ToDouble(hashbrownTextBox.Text) * Price_HashBrown;
            itemCost[9] = Convert.ToDouble(ToastedbagelTextBox.Text) * Price_ToastedBagel;
            itemCost[10] = Convert.ToDouble(pineapplestickTextBox.Text) * Price_PineappleStick;
            itemCost[11] = Convert.ToDouble(ChocklatemuffinTextBox.Text) * Price_ChocklateMuffin;
            itemCost[12] = Convert.ToDouble(pancakesyrupTextBox.Text) * Price_PancakeSyrup;
            itemCost[13] = Convert.ToDouble(teaTextBox.Text) * Price_Tea;
            itemCost[14] = Convert.ToDouble(colaTextBox.Text) * Price_Cola;
            itemCost[15] = Convert.ToDouble(coffeeTextBox.Text) * Price_Coffee;
            itemCost[16] = Convert.ToDouble(orangeTextBox.Text) * Price_Orange;
            itemCost[17] = Convert.ToDouble(bottlewaterTextBox.Text) * Price_BottleWater;
            itemCost[18] = Convert.ToDouble(vanillaconeTextBox.Text) * Price_VanillaCone;
            itemCost[19] = Convert.ToDouble(vanillashakeTextBox.Text) * Price_VanillaShake;
            itemCost[20] = Convert.ToDouble(strawberryshakeTextBox.Text) * Price_StrawberryShake;
            itemCost[21] = Convert.ToDouble(choklatemilkshakeTextBox.Text) * Price_ChocklateMilkShake;


            double cost = 0, iChange;
            if (paymentComboBox.Text == "")
            {
                MessageBox.Show("Please Enter Cash or Card!", "Warning!", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (paymentComboBox.Text == "Cash")
            {
                iSubTotal = itemCost[0] + itemCost[1] + itemCost[2] + itemCost[3] + itemCost[4] + itemCost[5] +
                            itemCost[6] +
                            itemCost[7] + itemCost[8] + itemCost[9] + itemCost[10] + itemCost[11] + itemCost[12] +
                            itemCost[13] + itemCost[14] +
                            itemCost[15] + itemCost[16] + itemCost[17] + itemCost[18] + itemCost[19] + 
                            itemCost[20] + itemCost[21];


                subtotalButton.Text = Convert.ToString(iSubTotal);
                iTax = (iSubTotal*Tax_Rate)/100;
                taxButton.Text = Convert.ToString(iTax);
                iTotal = iSubTotal + iTax;
                ttlButton.Text = Convert.ToString(iTotal);


                iChange = Convert.ToDouble(paymentTextBox.Text);
                if (iChange > 0)
                {
                    cost = iChange - iTotal;
                    changeButton.Text = Convert.ToString(cost);

                    changeButton.Text = string.Format("{0:C}", cost);
                }

                taxButton.Text = string.Format("{0:C}", iTax);
                subtotalButton.Text = string.Format("{0:C}", iSubTotal);
                ttlButton.Text = string.Format("{0:C}", iTotal);

            }
            else
            {
                iSubTotal = itemCost[0] + itemCost[1] + itemCost[2] + itemCost[3] + itemCost[4] + itemCost[5] +
                            itemCost[6] +
                            itemCost[7] + itemCost[8] + itemCost[9] + itemCost[10] + itemCost[11] + itemCost[12] +
                            itemCost[13] + itemCost[14] +
                            itemCost[15] + itemCost[16] + itemCost[17] + itemCost[18] + itemCost[19] +
                            itemCost[20] + itemCost[21];


                subtotalButton.Text = Convert.ToString(iSubTotal);
                iTax = (iSubTotal * Tax_Rate) / 100;
                taxButton.Text = Convert.ToString(iTax);
                iTotal = iSubTotal + iTax;
                ttlButton.Text = Convert.ToString(iTotal);

                taxButton.Text = string.Format("{0:C}", iTax);
                subtotalButton.Text = string.Format("{0:C}", iSubTotal);
                ttlButton.Text = string.Format("{0:C}", iTotal);
            }

        }
    }
}
