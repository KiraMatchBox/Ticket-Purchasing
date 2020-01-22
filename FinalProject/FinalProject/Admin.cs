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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            //fills out data grid
            String[] Accounts = File.ReadAllLines("CustomerData.txt");

            var AccountInfo = from line in Accounts
                                let AccountIndex = line.Split(' ')
                                let name = AccountIndex[0]
                                let email = AccountIndex[2]
                                let totalCost = AccountIndex[9]
                                let conNum = AccountIndex[10]
                                let lowerLevel = AccountIndex[6]
                                let clubLevel = AccountIndex[7]
                                let upperDeck = AccountIndex[8]
                                select new {name, email, totalCost, conNum, lowerLevel, clubLevel, upperDeck};
            foreach (var info in AccountInfo)
            {
                dataGridView1.Rows.Add(info.name,info.email,info.totalCost,info.conNum,info.lowerLevel,info.clubLevel,info.upperDeck);
            }
            //Populates labels with correct info
            lblTotalSales.Text = ("Total Sales: " + customer.getTotalSales().ToString("c2"));
            lblLowerCount.Text = customer.getLowerLevelRemaining().ToString();
            lblClubCount.Text = customer.getClubLevelRemaining().ToString();
            lblUpperCount.Text = customer.getUpperDeckRemaining().ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            
            String search = txtConfirmationNumber.Text;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                String[] Accounts = File.ReadAllLines("CustomerData.txt");
                var AccountInfo = from line in Accounts
                                  let AccountIndex = line.Split(' ')
                                  let name = AccountIndex[0]
                                  let email = AccountIndex[2]
                                  let totalCost = AccountIndex[9]
                                  let conNum = AccountIndex[10]
                                  let lowerLevel = AccountIndex[6]
                                  let clubLevel = AccountIndex[7]
                                  let upperDeck = AccountIndex[8]
                                  select new { name, email, totalCost, conNum, lowerLevel, clubLevel, upperDeck };
                foreach (var info in AccountInfo)
                {
                    if(info.conNum == search)
                    {
                        MessageBox.Show("Found confirmation number: " + info.conNum + "\nName: " + info.name + "\nTotal charge: $" + info.totalCost);
                    }
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[3].Value.ToString().Equals(search))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Invalid confirmation number.");
            }
        }
    }
}
