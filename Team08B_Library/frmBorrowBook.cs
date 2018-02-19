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
    public partial class frmBorrowBook : Form
    {
        Book b;
        Member m;
        SA45_Team08B_LibraryEntities context;

        Form f;

        public frmBorrowBook()
        {
            InitializeComponent();
            context = new SA45_Team08B_LibraryEntities();
            b = null;
            m = null;
        }

        private void frmBorrowBook_Load(object sender, EventArgs e)
        {            
            ClearEntries();
            tssStatus.Text = "";
            ActiveControl = btnSearchMember;
            //menuStrip1.ForeColor = Color.White;
        }

        public short GetTransID
        {
            get { return 1; }
        }
        private void ClearEntries()
        {
            b = null;
            m = null;
            txtBookID.Text = "";
            txtMemberID.Text = "";
            txtRemarks.Text = "";
            dtpIssueDate.Value = DateTime.Now;
            UpdateDueDate();
            EnableControl();
        }

        private void dtpIssueDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateDueDate();
        }

        private void UpdateDueDate()
        {
             DateTime due = dtpIssueDate.Value.AddDays(14);
            lblDueDate.Text = due.ToString("dd-MMM-yyyy");
        }

        private void CheckBookID()
        {
            try
            {
                short s = Convert.ToInt16(txtBookID.Text);
                b = context.Books.Where(x => x.BookID == s).First();
                FillBookInfo();
                txtBookID.BackColor = Color.White;
            }
            catch (Exception e)
            {
                b = null;
                tssStatus.Text = "Book ID not found";
                txtBookID.BackColor = Color.LightSalmon;
            }
            finally
            {
                EnableControl();
                CheckStock();
            }
        }

        private void CheckMemberID()
        {
            try
            {
                m = context.Members.Where(x => x.MemberID == txtMemberID.Text).First();
                FillMemberInfo();
                txtMemberID.BackColor = Color.White;

            }
            catch (Exception e)
            {
                m = null;
                tssStatus.Text = "Member ID not found";
                txtMemberID.BackColor = Color.LightSalmon;         
            }
            finally
            {
                EnableControl();
                CheckStock();
            }

        }

        private void FillMemberInfo()
        {
            try
            {
                txtMemberInfo.Text = string.Format
                    ("Name: {0}. {1}" + Environment.NewLine +
                    "Address: {2}, {3} {4}" + Environment.NewLine +
                    "Place of Birth: {5}" + Environment.NewLine +
                    "Phone Number: {6}", m.ContactTitle, m.MemberName,
                                        m.Address, m.City, m.PostalCode, m.PlaceOfBirth, m.PhoneNumber);
            }
            catch (NullReferenceException e)
            {
                throw e;
            }
        }
        private void FillBookInfo()
        {
            try
            {
                txtBookInfo.Text = string.Format
                    ("Title: {0}" + Environment.NewLine +
                    "Genre: {1}" + Environment.NewLine +
                    "Author: {2}" + Environment.NewLine +
                    "Publisher: {3}", b.BookTitle, b.BookType, b.Author, b.Publisher);
            }
            catch
            {
                throw new Exception();
            }
        }

        
        private void txtMemberID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                CheckMemberID(); 
            }            
        }

        private void txtBookID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckBookID();
            }
        }

        private void txtChanged(object sender, EventArgs e)
        {
            if(ActiveControl == txtMemberID || ActiveControl == txtBookID )
                ActiveControl.BackColor = Color.White;
            //tssStatus.Text = "";
        }

        private void txtMemberID_Leave(object sender, EventArgs e)
        {
            CheckMemberID();
            if (!txtMemberInfo.Enabled) btnSearchMember.Focus();
            else if (!txtBookInfo.Enabled) txtBookID.Focus();
            else if (dtpIssueDate.Enabled) dtpIssueDate.Focus();
        }

        private void txtBookID_Leave(object sender, EventArgs e)
        {
            CheckBookID();
            if (!txtBookInfo.Enabled) btnSearchBook.Focus();
            else if (!txtMemberInfo.Enabled) txtMemberID.Focus();
            else if (dtpIssueDate.Enabled) dtpIssueDate.Focus();            
        }

        private void CheckStock()
        {
            if(b!=null)
            { 
                if (b.TotalStock == b.NumberBorrowed)
                {
                    tssStatus.Text = "Out of Stock";
                    btnBorrow.Enabled = false;
                    dtpIssueDate.Enabled = txtRemarks.Enabled = false;
                }
                else
                {
                    tssStatus.Text = "Stock Available";
                    if (m != null)
                    {
                        btnBorrow.Enabled = true;
                        btnBorrow.BackColor = Color.FromArgb(103,58,183);
                        dtpIssueDate.Enabled = txtRemarks.Enabled = true;
                    }
                }
            }
        }

        private void EnableControl()
        {
            txtMemberID.Enabled = true;
            txtBookID.Enabled = true;

            if (m == null && b == null)
            {
                btnBorrow.Enabled = false;
                dtpIssueDate.Enabled = txtRemarks.Enabled = false;
                txtBookInfo.Enabled = txtMemberInfo.Enabled = false;
                txtBookInfo.Text = txtMemberInfo.Text = "";
            }
            else if (b == null)
            {
                btnBorrow.Enabled = false;
                dtpIssueDate.Enabled = txtRemarks.Enabled = false;
                txtBookInfo.Enabled = false;
                txtMemberInfo.Enabled = true;
                txtMemberInfo.ReadOnly = true;
                txtBookInfo.Text = "";
            }
            else if (m == null)
            {
                btnBorrow.Enabled = false;
                dtpIssueDate.Enabled = txtRemarks.Enabled = false;
                txtMemberInfo.Enabled = false;
                txtBookInfo.Enabled = true;
                txtBookInfo.ReadOnly = true;
                txtMemberInfo.Text = "";
            }
            else
            {
                btnBorrow.Enabled = true;
                dtpIssueDate.Enabled = txtRemarks.Enabled = true;
                txtBookInfo.Enabled = true;
                txtBookInfo.ReadOnly = true;
                txtMemberInfo.Enabled = true;
                txtMemberInfo.ReadOnly = true;
            }
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            tssStatus.Text = "Search Member";
            using (frmSearchMember f = new frmSearchMember())
            {
                f.ShowDialog();
                if (f.DialogResult == DialogResult.OK)
                {
                    txtMemberID.Text = f.GetID;
                }

                txtMemberID_Leave(sender, e);
            }
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            tssStatus.Text = "Search Book";
            using (frmSearchBook f = new frmSearchBook())
            {
                f.ShowDialog();
                if(f.DialogResult == DialogResult.OK)
                {
                    txtBookID.Text = f.GetID;
                }

                txtBookID_Leave(sender, e);
                //CheckBookID();

            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            //if (b.TotalStock == b.NumberBorrowed)
            //{
            //    tssStatus.Text = "Out of Stock";
            //    return;
            //}
            DialogResult r = MessageBox.Show("Confirm Borrow?" + Environment.NewLine
                            + "Member ID: " + m.MemberID + Environment.NewLine
                             + "Member Name: " + m.MemberName + Environment.NewLine
                            + "Book ID: " + b.BookID + Environment.NewLine
                            + "Book Title: " + b.BookTitle + Environment.NewLine,
                            "Borrow", MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
                return;            
            try
            {
                IssueTran trans = new IssueTran();
                using (TransactionScope ts = new TransactionScope())
                {                    
                    trans.BookID = b.BookID;
                    trans.MemberID = m.MemberID;
                    trans.DateIssue = dtpIssueDate.Value.Date;
                    trans.DateDue = DateTime.Parse(lblDueDate.Text);
                    trans.Remarks = txtRemarks.Text;
                    b.NumberBorrowed += 1;
                    trans.BorrowStatus = "OUT";
                    context.IssueTrans.Add(trans);
                    context.SaveChanges();
                    ts.Complete();
                }
                tssStatus.Text = "Borrow Successful!";
                DialogResult print = MessageBox.Show("Would you like to print borrow receipt?", "Print receipt", 
                    MessageBoxButtons.YesNo);
                if (print==DialogResult.Yes)
                {
                    frmGenerateReport fReceipt = new frmGenerateReport(trans.TransactionID);
                    fReceipt.ShowDialog();
                }
                
                ClearEntries();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        

        private void btnAdminMenu_MouseEnter(object sender, EventArgs e)
        {
            pnlAdmin.Show();
        }

        private void btnBorrowMenu_MouseMove(object sender, MouseEventArgs e)
        {
            pnlAdmin.Hide();
        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            f = new frmReturn();
            f.Show();
            this.Close();
        }

        private void btnBookInfoMenu_Click(object sender, EventArgs e)
        {
            f = new frmBookInfo();
            f.Show();
            this.Close();
        }

        private void btnMemberInfoMenu_Click(object sender, EventArgs e)
        {
            f = new frmMemberInfo();
            f.Show();
            this.Close();
        }

        private void btnReportMenu_Click(object sender, EventArgs e)
        {
            f = new frmReport();
            f.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Logout from account?", "Logout", MessageBoxButtons.YesNo);
            if (r==DialogResult.Yes)
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
    }
}
