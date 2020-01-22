using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Basic code for switching forms
this.Hide();
Login emailLogin = new Login();
emailLogin.ShowDialog();
this.Close();
*/

namespace FinalProject
{
    public partial class GetTickets : Form
    {
        public GetTickets()
        {
            InitializeComponent();
        }

        private void LblAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminLogin login = new adminLogin();
            login.ShowDialog();
            this.Close();
        }

        private void BtnGetTickets_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login emailLogin = new Login();
            emailLogin.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
