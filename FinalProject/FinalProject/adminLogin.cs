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
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if(txtAdminPassword.Text != "BACS287" || txtAdminUsername.Text != "admin")
            {
                MessageBox.Show("Incorrect username or password");
            }
            else if(txtAdminPassword.Text == "BACS287" && txtAdminUsername.Text == "admin")
            {
                this.Hide();
                Admin admin = new Admin();
                admin.ShowDialog();
                this.Close();
            }
        }
    }
}
