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

namespace FinalProject
{
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            lblCost.Text = ("Total Cost " + ((customer.totalCost).ToString("C2")));
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                customer.cardName = txtCardName.Text;
                double check = double.Parse(txtCreditCardNumber.Text);
                if((txtCreditCardNumber.Text).Length == 16 && (txtCSV.Text).Length == 3)
                {
                    customer.confirmationNumber = customer.generateConfirmationNumber();
                    customer.creditCardNumber = (txtCreditCardNumber.Text);
                    customer.CSV = int.Parse(txtCSV.Text);
                    MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                    DialogResult result = MessageBox.Show("Can't wait to see you " + customer.name + "!\nSummary:\nAmount to be charged: " + customer.totalCost.ToString("C2") + "\nContact Email: " + customer.email + "\n\nWould you like to confirm your order?", "Confirmation", buttons);
                    if (result == DialogResult.Yes)
                    {
                        using (StreamWriter StreamWriter = new StreamWriter("CustomerData.txt", true))
                        {
                            StreamWriter.WriteLine(customer.name + " " + customer.age + " " + customer.email + " " + customer.creditCardNumber + " " + customer.cardName + " " + customer.CSV + " " + customer.lower + " " + customer.club + " " + customer.upper + " " + customer.totalCost + " " + customer.confirmationNumber);
                            MessageBox.Show("Your order has been placed.\nConfirmation number: "+customer.confirmationNumber, "Thank you!");
                            this.Close();
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("What are you waiting for?...");
                    }
                    else if(result == DialogResult.Cancel)
                    {
                        this.Close();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Invalid credit card number or CSV");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Credit Card Number and CSV must be in whole number format");
            }
        }
    }
}
