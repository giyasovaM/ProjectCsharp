// Programmer: Madinakhon Giyasova
// Project: Assignment 3
// Date:04.09.2021
// Description: Order summary form 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giyasova_3_
{
    public partial class Form1 : Form
    {
        // declaring and assigning global variables to the price labels

        private const decimal TAX_RATE = 0.07m;
        private const decimal EXTRAS_PRICE = 9.5m;
        private const decimal MESSAGE_CARD_PRICE = 2.5m;
        private const decimal HOME_DELIVERY = 7.5m;

        private const decimal SINGLE_PRICE = 9.95m;
        private const decimal HALF_DOZEN_PRICE = 35.95m;
        private const decimal DOZEN_PRICE = 65.95m;
        private const string V = "";
        private readonly int propertyPrice;

        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void singleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void deliveryInfoGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void baloonsPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void stateLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void extrasListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Assigning currency to the variables 
            // Declaring Custom Methods 
            PopulateBoxes();

            messageLabel.Text = MESSAGE_CARD_PRICE.ToString("c");
            extraPriceLabel.Text = EXTRAS_PRICE.ToString("c");
            homeLabel.Text = HOME_DELIVERY.ToString("c");
            singleLabel.Text = SINGLE_PRICE.ToString("c");
            halfLabel.Text = HALF_DOZEN_PRICE.ToString("c");
            dozenLabel.Text = DOZEN_PRICE.ToString("c");

            deliveryDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");

            UpdateTotals();
            ResetForm();
        
        }

        //Custom method to reset the form
        private void ResetForm()
        {
            //Clear button commands to clear the form
            deliveryDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            streetTextBox.Text = "";
            cityTextBox.Text = "";
            stateTextBox.Text = "";
            zipCodeMaskedTextBox.Text = "";
            occasionsComboBox.SelectedIndex = -1;
            titleComboBox.Text = "";
            otherTitleTextBox.Text = "";
            otherLabel.Enabled = false;
            storePickUpRadioButton.Checked = true;
            singleRadioButton.Checked = true;
            phoneNumberMaskedTextBox.Text = ("__/__/____");
            extrasListBox.ClearSelected();
            messageTextBox.Text = "";
            messageCardCheckBox.Checked = false;
            messageTextBox.Enabled = false;
            maxWordsLabel.Enabled = false;
            firstNameTextBox.Focus();
            UpdateTotals();



        }
        private void UpdateTotals()
        {
            decimal subTotal = 0;

            if (singleRadioButton.Checked)
            {
               subTotal = SINGLE_PRICE;
            } else if (halfDozenRadioButton.Checked)
            {
               subTotal = HALF_DOZEN_PRICE;
            } else if (dozenRadioButton.Checked)
            {
               subTotal = DOZEN_PRICE;
            }

            foreach (Object item in extrasListBox.SelectedItems)
            {
                subTotal = subTotal + EXTRAS_PRICE;
            }
           
            if (messageCardCheckBox.Checked)
            {
                subTotal = subTotal + MESSAGE_CARD_PRICE;
            }

            if (homeDeliveryRadioButton.Checked)
            {
                subTotal = subTotal + HOME_DELIVERY;
            }

            decimal tax = subTotal * TAX_RATE;

            subtotalLabel.Text = subTotal.ToString("c");
            taxLabel.Text = tax.ToString("c");
            totalLabel.Text = (tax + subTotal).ToString("c");
        }

        private void PopulateBoxes()
        {
            try
            {
                string line;
                StreamReader streamReader = new StreamReader("Extras.txt");

                while ((line = streamReader.ReadLine()) != null)
                {
                    extrasListBox.Items.Add(line);
                }
                streamReader.Close();

                
                StreamReader streamOccasionsReader = new StreamReader("Occasions.txt");

                while ((line = streamOccasionsReader.ReadLine()) != null)
                {
                    occasionsComboBox.Items.Add(line);
                }
                streamOccasionsReader.Close();

            }
            catch (Exception ex)
            {
                //Display Message if smth goes wrong in the operation system
                MessageBox.Show(ex.Message);
                this.Close();
            }


        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void messageCardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (messageCardCheckBox.Checked)
            {
                messageTextBox.Enabled = true;
                maxWordsLabel.Enabled = true;
            } else
            {
                messageTextBox.Text = "";
                messageTextBox.Enabled = false;
                maxWordsLabel.Enabled = false;
            }

            UpdateTotals();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void homeDeliveryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void halfDozenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void dozenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }


        /*
         * 
         * */
        private void displayButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameTextBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text))
            { 
                    MessageBox.Show("You must enter your first name, ore last name!",
                        "Blank Value Entered",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            if (!(phoneNumberMaskedTextBox.MaskCompleted))
            {
                MessageBox.Show("You must enter your phone number!",
                           "Blank Value Entered",
                           MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }


            string deliveryType = storePickUpRadioButton.Text;
            if (homeDeliveryRadioButton.Checked)
            {
                deliveryType = homeDeliveryRadioButton.Text;
            }

            string bundleSize = singleRadioButton.Text;
            if (halfDozenRadioButton.Checked)
            {
                bundleSize = halfDozenRadioButton.Text;
            } else if (dozenRadioButton.Checked)
            {
                bundleSize = dozenRadioButton.Text;
            }

            string message = "";
            if (messageCardCheckBox.Checked)
            {
                message = messageTextBox.Text;
            }
           

            string title = "Bonnie's Balloons";

            string extras = "";
            foreach (var item in extrasListBox.SelectedItems)
            {
                extras += "\t-" + item.ToString() + "\n";
            }

            // Displaying confirmation message 
            MessageBox.Show(
               "First and Last Name: " + titleComboBox.Text + " " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n" +
                "Street: " + streetTextBox.Text + "\n" +
                "City: " + cityTextBox.Text + " " + stateTextBox.Text + " " + zipCodeMaskedTextBox.Text + "\n" +
                "Phone Number: " + phoneNumberMaskedTextBox.Text + "\n" +
                "Delivery Date: "  + deliveryDateMaskedTextBox.Text + "\n" +
                "Delivery Type: " + deliveryType + "\n" +
                "Bundle size: " + bundleSize + "\n" +
                "Occasion: " + occasionsComboBox.Text + "\n" +
                "Extras: " + extras +
                "Message: " + message + "\n" +
                "Order subtotal: " + subtotalLabel.Text + "\n" +
                "Sales tax amount: " + taxLabel.Text + "\n" +
                "Order total: " + totalLabel.Text


                , title);
            ResetForm();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you wish to quit?";
            string title = "Exit form";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        //Clearng the form and returning to the original apper
        private void clearButton_Click(object sender, EventArgs e)
        {
            ResetForm();

        }

        private void customerInfoGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void occasionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void titleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string val = titleComboBox.SelectedItem.ToString();

            if (val == "Other")
            {
                otherLabel.Enabled = true;
                otherTitleTextBox.Enabled = true;
            }
            else
            {
                otherTitleTextBox.Text = "";
                otherLabel.Enabled = false;
                otherTitleTextBox.Enabled = false;
            }
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
