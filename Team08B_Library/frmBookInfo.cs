using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Transactions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team08B_Library
{
    public partial class frmBookInfo : Form
    {
        SA45_Team08B_LibraryEntities context;
        Form f;
        public frmBookInfo()
        {
            InitializeComponent();
            btnBookInfoMenu.Visible = true;            
            btnBorrowMenu.Visible = true;
            btnMemberInfoMenu.Visible = true;
            btnReportMenu.Visible = true;
            btnReturnMenu.Visible = true;
            btnUpdate.Visible = true;
            btnAdd.Visible = true;
            btnBorrowHistory.Visible = true;

            btnAdminMenu.Text = "Hi Admin";
            btnLogout.Text = "Logout";
        }

        public frmBookInfo(string admin)
        {            
            InitializeComponent();
            btnBookInfoMenu.Visible = false;
            btnBorrowMenu.Visible = false;
            btnMemberInfoMenu.Visible = false;
            btnReportMenu.Visible = false;
            btnReturnMenu.Visible = false;
            btnUpdate.Visible = false;
            btnAdd.Visible = false;
            btnBorrowHistory.Visible = false;

            btnAdminMenu.Text = "Hi Guest";
            btnLogout.Text = "Home";
        }

        public short GetID
        {
            get { return Convert.ToInt16(txtBook.Text); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            f = new frmBookUpdate(this);
            f.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SA45_Team08B_LibraryEntities context = new SA45_Team08B_LibraryEntities();
            frmSearchBook f = new frmSearchBook();
            DialogResult r = f.ShowDialog();
            if (r == DialogResult.OK)
            {
                txtBook.Text = f.GetID;
                btnGo_Click(sender, e);
                //int id = Convert.ToInt16(txtBook.Text);
                //Book b = new Book();
                //b = context.Books.Where(x => x.BookID == id).First();
                
                //txtBookType.Text = b.BookType;
                //txtBookTitle.Text = b.BookTitle;
                //txtPublisher.Text = b.Publisher;
                //txtTotalStock.Text = b.TotalStock.ToString();
                //txtNumberBorrow.Text = b.NumberBorrowed.ToString();
                //txtAuthor.Text = b.Author;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNewBook f = new frmAddNewBook();
            f.ShowDialog();
        }

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    DialogResult r = MessageBox.Show("Are you sure to delete the record?", "Confirm", MessageBoxButtons.YesNo);
        //    if (r == DialogResult.Yes)
        //    {
        //        using (TransactionScope ts = new TransactionScope())
        //        {
        //            Book b = new Book();
        //            int id = Convert.ToInt16(txtBook .Text); 
        //            var q = from x in context.Books where x.BookID == id select x;
        //            b = q.First();
        //            context.Books.Remove(b);
        //            context.SaveChanges();
        //            ts.Complete();
        //        }
        //        sslDelete.Text = "You have deleted the record successfully.";
        //    }
        //}
        private void EnableButtons(bool enable)
        {
            btnUpdate.Enabled = enable;
            btnBorrowHistory.Enabled = enable;

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (txtBook.Text == "")
            {
                lblValid.Text = "Please enter Book ID";
                EnableButtons(false);
                return;
            }
            short id;
            int testId;
            if(!short.TryParse(txtBook.Text, out id))
            {
                if (int.TryParse(txtBook.Text, out testId))
                {
                    lblValid.Text = "Book ID should be number less than 32768";
                }
                else
                {
                    lblValid.Text = "Book ID should only contain numbers";
                    EnableButtons(false);
                }
                return;
            }
            
            Book b = new Book();
            try
            {
                b = context.Books.Where(x => x.BookID == id).First();
            }
            catch (Exception ex)
            {
                lblValid.Text = "Invalid Book ID";
                EnableButtons(false);
                return;
            }

            txtBookType.Text = b.BookType;
            txtBookTitle.Text = b.BookTitle;
            txtPublisher.Text = b.Publisher;
            txtTotalStock.Text = b.TotalStock.ToString();
            txtNumberBorrow.Text = b.NumberBorrowed.ToString();
            txtAuthor.Text = b.Author;

            if(b.TotalStock == b.NumberBorrowed && b.TotalStock!=0)
            {
                ShowAvailDate(true);
                IssueTran it = new IssueTran();
                it = context.IssueTrans.Where(x => x.BookID == id && x.BorrowStatus == "OUT")
                    .OrderBy(x => x.DateDue).First();
                DateTime due = Convert.ToDateTime(it.DateDue);
                txtAvailDate.Text = due.ToString("dd-MMM-yyyy");

            }
            else
            {
                ShowAvailDate(false);
            }

            lblValid.Text = "";
            EnableButtons(true);
        }

        private void btnBorrowMenu_Click(object sender, EventArgs e)
        {
            f = new frmBorrowBook();
            f.Show();
            this.Close();
        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            f = new frmReturn();
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

        private void btnAdminMenu_MouseEnter(object sender, EventArgs e)
        {
            pnlAdmin.Show();
        }        

        private void frmBookInfo_Load(object sender, EventArgs e)
        {
            context = new SA45_Team08B_LibraryEntities();
            pnlAdmin.Hide();
            EnableButtons(false);
            lblValid.Text = "";
            lblValid.ForeColor = Color.Red;
            ShowAvailDate(false);
        }

        private void ShowAvailDate(bool show)
        {
            txtAvailDate.Visible = show;
            lblAvailDate.Visible = show;
        }

        private void frmBookInfo_MouseMove(object sender, MouseEventArgs e)
        {
            pnlAdmin.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult r;
            if (btnLogout.Text == "Home")
                r = DialogResult.Yes;
            else
                r = MessageBox.Show("Logout from account?", "Logout", MessageBoxButtons.YesNo);

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

        private void btnBorrowHistory_Click(object sender, EventArgs e)
        {
            f = new frmBorrowHistory("book",Convert.ToInt32(txtBook.Text));
            f.ShowDialog();
        }

        private void txtBook_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnGo_Click(sender, e);
            }
        }
    }
}
