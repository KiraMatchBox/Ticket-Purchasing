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
    public partial class AccountCreation : Form
    {
        
        public AccountCreation()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtNameCreate.Text;
                int age = int.Parse(txtAgeCreate.Text);
                String email = txtEmailCreate.Text;
                String password = txtPasswordCreate.Text;
                Boolean taken = false;
                //
                String[] Accounts = File.ReadAllLines("LoginData.txt");

                var registeredAccounts = from line in Accounts
                                         let AccountIndex = line.Split(' ')
                                         let takenEmail = AccountIndex[2]
                                         select new { takenEmail };
                foreach (var info in registeredAccounts)
                {
                    if (email == info.takenEmail)
                    {
                        taken = true;
                    }
                }
                //
                if (taken == true)
                {
                    MessageBox.Show("That email has already been registered");
                    taken = false;
                }
                else
                {
                    if(age < 16)
                    {
                        MessageBox.Show("Concert too strong for baby");
                    }
                    else
                    {
                        customer.name = name;
                        customer.email = email;
                        customer.age = age;
                        using (StreamWriter StreamWriter = new StreamWriter("LoginData.txt", true))
                        {
                            StreamWriter.WriteLine(name + " " + age + " " + email + " " + password);
                        }

                        this.Hide();
                        Login emailLogin = new Login();
                        emailLogin.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter age in whole number format");
            }
        }

        private void lblShow_Click(object sender, EventArgs e)
        {
            txtPasswordCreate.UseSystemPasswordChar = false;
        }

        private void lblHide_Click(object sender, EventArgs e)
        {
            txtPasswordCreate.UseSystemPasswordChar = true;
        }
    }
}
