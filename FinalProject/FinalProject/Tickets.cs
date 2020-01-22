using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Tickets : Form
    {
        public Tickets()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numLowerLevel.Text) > customer.getLowerLevelRemaining())
            {
                MessageBox.Show("Sorry there are only " + (customer.getLowerLevelRemaining()).ToString() + " lower level seats avaliable.");
            }
            else if (Convert.ToInt32(numClubLevel.Text) > customer.getClubLevelRemaining())
            {
                MessageBox.Show("Sorry there are only " + (customer.getClubLevelRemaining()).ToString() + " club level seats avaliable.");
            }
            else if (Convert.ToInt32(numUpperDeck.Text) > customer.getUpperDeckRemaining())
            {
                MessageBox.Show("Sorry there are only " + (customer.getUpperDeckRemaining()).ToString() + " upper deck seats avaliable.");
            }
            else
            {
                customer.lower = Convert.ToInt32(numLowerLevel.Text);
                customer.club = Convert.ToInt32(numClubLevel.Text);
                customer.upper = Convert.ToInt32(numUpperDeck.Text);
                customer.totalCost = ((customer.lower * 125) + (customer.club * 75) + (customer.upper * 50));
                this.Hide();
                Purchase purchase = new Purchase();
                purchase.ShowDialog();
                this.Close();
            }
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            int lower = customer.getLowerLevelRemaining();
            int club = customer.getClubLevelRemaining();
            int upper = customer.getUpperDeckRemaining();
            
            if(lower == 0)
            {
                lblLowerLevel.Text = ("Sold Out!");
            }
            if (club == 0)
            {
                lblClubLevel.Text = ("Sold Out!");
            }
            if (upper == 0)
            {
                lblUpperDeck.Text = ("Sold Out!");
            }
        }
    }
}
