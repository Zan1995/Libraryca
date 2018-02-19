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
    public partial class frmReport : Form
    {
        Form f;
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            pnlAdmin.Hide();
        }

        private void btnAdminMenu_MouseMove(object sender, MouseEventArgs e)
        {
            pnlAdmin.Show();
        }

        private void btnBorrowMenu_MouseMove(object sender, MouseEventArgs e)
        {
            pnlAdmin.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Logout from account?", "Logout", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                f = new frmWelcome();
                f.Show();
                this.Close();
            }
            else
            {
                pnlAdmin.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Exit Program?", "Exit", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                pnlAdmin.Hide();
            }
        }

        private void btnMemberInfoMenu_Click(object sender, EventArgs e)
        {
            f = new frmMemberInfo();
            f.Show();
            this.Hide();
        }

        private void btnBookInfoMenu_Click(object sender, EventArgs e)
        {
            f = new frmBookInfo();
            f.Show();
            this.Hide();
        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            f = new frmReturn();
            f.Show();
            this.Hide();
        }

        private void btnBorrowMenu_Click(object sender, EventArgs e)
        {
            f = new frmBorrowBook();
            f.Show();
            this.Hide();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            f = new frmGenerateReport();
            f.ShowDialog();
        }

        private void btnCrossTab_Click(object sender, EventArgs e)
        {
            f = new frmManagementReport();
            f.ShowDialog();
        }

        private void btnBookList_Click(object sender, EventArgs e)
        {
            f = new frmBookList();
            f.ShowDialog();
        }

        private void btnMemberInfo_Click(object sender, EventArgs e)
        {
            f = new frmPieChart();
            f.ShowDialog();
        }
    }
}
