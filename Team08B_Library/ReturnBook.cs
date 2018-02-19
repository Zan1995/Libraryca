using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Transactions;

namespace Team08B_Library
{
    public partial class frmReturn : Form
    {
        SA45_Team08B_LibraryEntities context;     
        IssueTran it;
        string getTransId;

        Form f;

        public frmReturn()
        {
            InitializeComponent();
            //timer1.Tick += new EventHandler(timer1_tick);
           
            context = new SA45_Team08B_LibraryEntities();
            
            //lblDateReturn.Text = DateTime.Today.ToString(); //shows the time today for return
            MaximizeBox = false;
            MinimizeBox = false;
            btnSubmit.Enabled = false;
            rbMemberID.Checked=true;
        }

        //to update the status bar at the bottom
        private void UpdateStatusBarText(string text) 
        {
            StatusStrip.Text = text;
            tssReturn.Invalidate();
            tssReturn.Refresh();
        }

        // Show list button functionality
        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchBook sb = new frmSearchBook();
            frmSearchMember sm = new frmSearchMember();

            if (rbBookID.Checked)
            {
                mtxtID.Clear();
                UpdateStatusBarText("Book ID search initiated");
                using (sb)
                {
                    sb.ShowDialog();
                    if (sb.DialogResult == DialogResult.OK)
                    {
                        mtxtID.Text = sb.GetID;
                        
                    }
                }
            }
            else if (rbMemberID.Checked)
            {
                mtxtID.Clear();
                UpdateStatusBarText("Member ID search initiated");
                using (sm)
                {
                    sm.ShowDialog();
                    if (sm.DialogResult == DialogResult.OK)
                    {
                        mtxtID.Text = sm.GetID;
                    }
                }
            }

        }

        private void ShowInfo(bool show)
        {
            txtBookInfo.Visible = show;
            txtMemberInfo.Visible = show;

        }

        private void frmReturn_Load(object sender, EventArgs e)
        {
            dgvTransaction.Enabled = false;
            dateTimePicker1.MaxDate = DateTime.Now;
            pnlAdmin.Hide();
            ShowInfo(false);
        }
    


        //private void btnShowList_Click(object sender, EventArgs e)
        //{
        //    context = new SA45_Team08B_LibraryEntities();

        //    if (rbBookID.Checked == true && TxtCheck(mtxtID)==false)
        //    {
        //        int userVal = int.Parse(mtxtID.Text);
        //        dgvTransaction.DataSource = context.IssueTrans.Where(x => x.BookID == userVal && x.BorrowStatus == "OUT")
        //        .Select(y => new
        //        {
        //            y.TransactionID,
        //            y.MemberID,
        //            y.BookID,
        //            y.DateIssue,
        //            y.DateDue,
        //            y.BorrowStatus
        //        }).ToList();
        //        UpdateStatusBarText("Transactions Propogated via BookID Search");
                
        //    }           
        //    else if (rbMemberID.Checked == true && TxtCheck(mtxtID) == false)
        //    {
        //        dgvTransaction.DataSource = context.IssueTrans.Where(x => x.MemberID == mtxtID.Text.ToString() && x.BorrowStatus == "OUT")
        //        .Select(y => new
        //        {
        //            y.TransactionID,
        //            y.MemberID,
        //            y.BookID,
        //            y.DateIssue,
        //            y.DateDue,
        //            y.BorrowStatus
        //        }).ToList();
        //        UpdateStatusBarText("Transactions Propogated via MemberID Search");
        //    }
       
            
        //}
        

        private bool TxtCheck(MaskedTextBox box)
        {
            if (string.IsNullOrWhiteSpace(box.Text))
            {
                UpdateStatusBarText("Please Key in ID.");
                return true;
            }
            return false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult r =
            MessageBox.Show("Confirm Return?","Confirm",MessageBoxButtons.YesNo);
            
            short s = Convert.ToInt16(dgvTransaction.CurrentRow.Cells[0].Value.ToString());
            DateTime returndate = this.dateTimePicker1.Value.Date;

            if (r==DialogResult.Yes)
            {
                using (TransactionScope ts = new TransactionScope())
                {                   
                    it = context.IssueTrans.Where(x => x.TransactionID == s).First();
                    it.BorrowStatus = "IN";
                    it.DateActualReturn = returndate;
                    context.SaveChanges();
                    ts.Complete();
                    UpdateStatusBarText("Return of book completed");                    
                }
                mtxtID_TextChanged(sender, e);
            }
            else if(r==DialogResult.No)
            {
                UpdateStatusBarText("Please select Transaction");
            }

            
        }

        private void dgvTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSubmit.Enabled = true;
        }

        private void dgvTransaction_SelectionChanged(object sender, EventArgs e)
        {
            dgvTransaction_Click(sender, e);
        }

        private void mtxtID_TextChanged(object sender, EventArgs e)
        {
            short s=0;
            bool isNum = Int16.TryParse(mtxtID.Text,out s);
            if (!isNum)
            return;
            if (rbBookID.Checked)
            {
                dgvTransaction.DataSource = context.IssueTrans.
                    Where(x => x.BookID == s && x.BorrowStatus == "OUT").ToList();
                dgvTransaction.Columns["Book"].Visible = false;
                dgvTransaction.Columns["Member"].Visible = false;
                dgvTransaction.Columns["DateActualReturn"].Visible = false;
            }
            else
            {
                dgvTransaction.DataSource = context.IssueTrans.
                    Where(x => x.MemberID == mtxtID.Text && x.BorrowStatus == "OUT").ToList();
                dgvTransaction.Columns["Book"].Visible = false;
                dgvTransaction.Columns["Member"].Visible = false;
                dgvTransaction.Columns["DateActualReturn"].Visible = false;
            }
            if (dgvTransaction.Rows.Count != 0)
            {
                dgvTransaction.Enabled = true;
                btnSubmit.Enabled = true;
                ShowInfo(true);
            }
            else
            {
                dgvTransaction.Enabled = false;
                btnSubmit.Enabled = false;
                ShowInfo(false);
            }

        }

        private void dgvTransaction_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
            short s = Convert.ToInt16(dgvTransaction.CurrentRow.Cells[2].Value.ToString());
            string t = dgvTransaction.CurrentRow.Cells[1].Value.ToString();
            Book b = context.Books.Where(x => x.BookID == s).First();
            Member m = context.Members.Where(x => x.MemberID == t).First();

            txtMemberInfo.Text = string.Format
                ("Name: {0}. {1}" + Environment.NewLine +
                "Address: {2}" + Environment.NewLine +
                "Country: {3}" + Environment.NewLine +
                "Phone Number: {4}", m.ContactTitle.ToUpper(), m.MemberName,
                                    m.Address, m.PlaceOfBirth, m.PhoneNumber);
            txtBookInfo.Text = string.Format
                   ("Title: {0}" + Environment.NewLine +
                   "Genre: {1}" + Environment.NewLine +
                   "Author: {2}" + Environment.NewLine +
                   "Publisher: {3}", b.BookTitle, b.BookType, b.Author, b.Publisher);

            ShowInfo(true);
        }

        private void mtxtID_Enter(object sender, EventArgs e)
        {
           
        }

        private void mtxtID_Click(object sender, EventArgs e)
        {
            mtxtID.SelectionStart = mtxtID.Text.Length;
        }

        private void rbBookID_CheckedChanged(object sender, EventArgs e)
        {
            UpdateStatusBarText("Book ID selected");
            mtxtID.Clear();
            dgvTransaction.DataSource=null;            
            ActiveControl = mtxtID;
            ShowInfo(false);
        }

        private void rbMemberID_CheckedChanged(object sender, EventArgs e)
        {
            UpdateStatusBarText("Member ID selected");
            mtxtID.Clear();
            dgvTransaction.DataSource=null;
            ActiveControl = mtxtID;
            ShowInfo(false);

        }



        private void btnAdminMenu_MouseEnter(object sender, EventArgs e)
        {
            pnlAdmin.Show();
        }

        
        private void btnBorrowMenu_Click(object sender, EventArgs e)
        {
            f = new frmBorrowBook();
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

        private void frmReturn_MouseMove(object sender, MouseEventArgs e)
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
        
    }
}
