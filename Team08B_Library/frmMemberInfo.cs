using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace Team08B_Library
{
    public partial class frmMemberInfo : Form
    {
        SA45_Team08B_LibraryEntities context;
        Form f;
        public frmMemberInfo()
        {
            InitializeComponent();
        }

        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //context = new LibraryEntities();
            //var qry = from x in context.Members
            //          where txtMemberID.Text == x.MemberID || txtMemberName.Text == x.MemberName select x;
            //dgv.DataSource = qry.ToList();
            using (frmSearchMember f = new frmSearchMember())
            {
                context = new SA45_Team08B_LibraryEntities();
                f.ShowDialog();
                if (f.DialogResult == DialogResult.OK)
                {
                    txtMemberID.Text = f.GetID;
                    btnGo_Click(sender, e);
                }
            }

        }

        private string GetID
        {
            get { return txtMemberID.Text; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNewMember f = new frmAddNewMember(GetID);
            f.ShowDialog();            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmMemberUpdates f = new frmMemberUpdates(GetID);
            f.ShowDialog();
        }

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    context = new SA45_Team08B_LibraryEntities();
        //    DialogResult dr = MessageBox.Show("Are you sure to delete the member", "Confirm", MessageBoxButtons.YesNo);
        //    if (dr == DialogResult.Yes)
        //    {
        //        using (TransactionScope ts = new TransactionScope())
        //        {
        //            try
        //            {
        //               string mID = Convert.ToString(txtMemberID.Text);
        //                Member mb = context.Members.Where(x => x.MemberID == mID).First() ;
        //                context.Members.Remove(mb);
        //                context.SaveChanges();
        //                ts.Complete();
        //            }
        //            catch
        //            {
        //                MessageBox.Show("Delete success");
        //            }

        //        }
        //    }           
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            lblValid.Text = "";
            lblValid.ForeColor = Color.Red;
            this.CenterToScreen();
            pnlAdmin.Hide();
            EnableButtons(false);
        }


        private void EnableButtons(bool enable)
        {
            btnUpdate.Enabled = enable;
            btnBorrowHistory.Enabled = enable;

        }

        //private void btnBorrows_Click(object sender, EventArgs e)
        //{
        //    context = new SA45_Team08B_LibraryEntities();
        //    var qry = from x in context.IssueTrans
        //              where txtMemberID.Text == x.MemberID
        //              select x;
        //    //dgv.DataSource = qry.ToList();
        //}
        

        private void btnReportMenu_Click(object sender, EventArgs e)
        {
            f = new frmReport();
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

        private void btnAdminMenu_MouseMove(object sender, MouseEventArgs e)
        {
            pnlAdmin.Show();
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

        private void btnBorrowMenu_MouseMove(object sender, MouseEventArgs e)
        {
            pnlAdmin.Hide();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (txtMemberID.Text == "")
            {
                lblValid.Text = "Please enter Member ID";
                EnableButtons(false);
                return;
            }
            String ID = Convert.ToString(txtMemberID.Text);
            int testId;
            Member m = new Member();
            if (!int.TryParse(txtMemberID.Text, out testId))
            {
                lblValid.Text = "Member ID should only contain numbers";
                EnableButtons(false);
                return;
            }

            try
            {
                m = context.Members.Where(x => x.MemberID == ID).First();
            }
            catch (Exception ex)
            {
                lblValid.Text = "Invalid Member ID";
                EnableButtons(false);
                return;
            }

            txtMemberName.Text = m.MemberName;
            txtAddress.Text = m.Address;
            txtPhone.Text = m.PhoneNumber;
            txtEmail.Text = m.EmailAddress;
            //txtMemberCategory.Text= m.MemberCategory;
            txtPostalcode.Text = m.PostalCode;
            lblValid.Text = "";
            EnableButtons(true);
        }

        private void txtMemberID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnGo_Click(sender, e);
            }
        }

        private void btnBorrowHistory_Click(object sender, EventArgs e)
        {
            f = new frmBorrowHistory("member", Convert.ToInt32(txtMemberID.Text));
            f.ShowDialog();
        }
    }
}
