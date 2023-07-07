using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void Resetlbl_Click(object sender, EventArgs e)
        {
            userNametxt.Text = "";
            Passwordtxt.Text = "";
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (userNametxt.Text == "" || Passwordtxt.Text == "")
            {
                MessageBox.Show("Missing Data !!!!");
            }
            else if (userNametxt.Text == "Admin" && Passwordtxt.Text == "Password")
            {
                Employee objemp = new Employee();
                objemp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password !!!!");
                userNametxt.Text = "";
                Passwordtxt.Text = "";
            }
        }
    }
}
