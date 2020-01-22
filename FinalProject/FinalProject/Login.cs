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
    public partial class Login : Form
    {   
        public Login()
        {
            InitializeComponent();
        }

        private void lblCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountCreation account = new AccountCreation();
            account.ShowDialog();
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            String[] Accounts = File.ReadAllLines("LoginData.txt");

            var EmailPassword = from line in Accounts
                             let AccountIndex = line.Split(' ')
                             let name = AccountIndex[0]
                             let age = AccountIndex[1]
                             let email = AccountIndex[2]
                             let password = AccountIndex[3]
                             select new { email, password, name, age };
            foreach (var info in EmailPassword)
            {
                if(txtEmail.Text == info.email)
                {
                    if(txtPassword.Text == info.password)
                    {
                        customer.name = info.name;
                        customer.age = int.Parse(info.age);
                        customer.email = info.email;

                        this.Hide();
                        Tickets getTickets = new Tickets();
                        getTickets.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password");
                    }
                }
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void lblShow_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void lblHide_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
