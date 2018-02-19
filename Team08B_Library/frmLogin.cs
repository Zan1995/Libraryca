using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team08B_Library
{
    public partial class frmLogin : Form
    {
        int countUser = 0;
        int countUserClick = 0;
        int countPassword = 0;

        int[] tbCount;

        public frmLogin()
        {
            InitializeComponent();
            tbCount = new int[] { 0, 0 };
            
        }

        public void ClearDefault(object sender, EventArgs e)
        {
            TextBox t;

            if (sender is TextBox)
            {
                t = (TextBox)sender;
                if (t.Name == "tbxUsername" && tbCount[t.TabIndex] == 0)
                {
                    return;
                }
                else if (tbCount[t.TabIndex] < 1)
                {
                    t.Text = "";
                    t.ForeColor = Color.Black;
                    tbCount[t.TabIndex]++;
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tbxUsername.Text = "Username";
            tbxUsername.ForeColor= Color.Gray;
            tbxPassword.Text = "Password";
            tbxPassword.ForeColor = Color.Gray;
        }

        private void tbxUsername_Click(object sender, EventArgs e)
        {
            countUserClick++; countUser++;
            tbxUsername.ForeColor = Color.Black;

            if (countUserClick == 1) {
                tbxUsername.Text = "";
            }
        }

        private void tbxPassword_Click(object sender, EventArgs e)
        {
            countPassword++;
            tbxPassword.ForeColor = Color.Black;

            if (countPassword == 1) {
                tbxPassword.Text = "";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text.ToLower() == "admin" && tbxPassword.Text == "team8b") {
                DialogResult = DialogResult.OK;
            }
            else if (tbxUsername.Text == "" && tbxPassword.Text == "") {
                lblLoginStatus.Text = "Please enter your username and password.";
            } else if (tbxUsername.Text == "") {
                lblLoginStatus.Text = "Please enter your username.";
            } else if (tbxPassword.Text == "") {
                lblLoginStatus.Text = "Please enter your password.";
            }
            else {
                lblLoginStatus.Text = "Wrong username or password.";
            }
        }

        private void tbxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            lblLoginStatus.Text = "";
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {
            countUser++;
        }

        private void tbxUsername_Enter(object sender, EventArgs e)
        {
            countUser++;
            tbxUsername.ForeColor = Color.Black;

            if (countUser == 2) {
                tbxUsername.Text = "";
            }
        }

        private void tbxUsername_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ActiveControl = tbxPassword;
        }

        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void tbxUsername_TextChanged_1(object sender, EventArgs e)
        {
            tbxUsername.ForeColor = Color.Black;
        }
    }
}
