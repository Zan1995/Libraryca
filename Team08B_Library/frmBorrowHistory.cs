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
    public partial class frmBorrowHistory : Form
    {
        int id;
        string type;
        SA45_Team08B_LibraryEntities context = new SA45_Team08B_LibraryEntities();
        
        public frmBorrowHistory(string type, int id)
        {
            InitializeComponent();
            this.id = id;
            this.type = type;
        }

        private void frmBorrowDetails_Load(object sender, EventArgs e)
        {

            if (type.ToLower() == "book") {
                lblID.Text = "Book ID";
                lblName.Text = "Book Title";
                Book book = context.Books.Where(x => x.BookID == id).First();
                tbxID.Text = book.BookID.ToString();
                tbxName.Text = book.BookTitle.ToString();
                dataGridView1.DataSource = context.IssueTrans.Where(x => x.BookID == id).Select(x => new { x.TransactionID ,x.MemberID, x.Member.MemberName, x.BorrowStatus, x.DateIssue, x.DateDue, x.DateActualReturn }).OrderBy(x=>x.MemberID).OrderBy(x => x.DateIssue).ToList();
                if(context.IssueTrans.Where(x => x.BookID == id).Count() == 0) {
                    lblBorrowAvai.Visible = true;
                }
            }
            if (type.ToLower() == "member") {
                lblID.Text = "Member ID";
                lblName.Text = "Member name";
                Member member = context.Members.Where(x => x.MemberID == id.ToString()).First();
                tbxID.Text = member.MemberID;
                tbxName.Text = member.MemberName;
                dataGridView1.DataSource = context.IssueTrans.Where(x => x.MemberID == id.ToString()).Select(x => new { x.TransactionID, x.BookID, x.Book.BookTitle, x.BorrowStatus, x.DateIssue, x.DateDue, x.DateActualReturn }).OrderBy(x => x.BookID).OrderBy(x => x.DateIssue).ToList();
                if (context.IssueTrans.Where(x => x.MemberID == id.ToString()).Count() == 0) {
                    lblBorrowAvai.Visible = true;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
