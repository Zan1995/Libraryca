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
        public frmBookInfo()
        {
            InitializeComponent();
        }

        private void grpBookInfo_Enter(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SA45_Team08B_LibraryEntities context = new SA45_Team08B_LibraryEntities();
            frmSearchBook f = new frmSearchBook();
            DialogResult r = f.ShowDialog();
            if (r == DialogResult.OK)
            {
                txtBook.Text = f.GetID;
                int id = Convert.ToInt16(txtBook.Text);
                Book b = new Book();
                b = context.Books.Where(x => x.BookID == id).First();
                
                txtBookType.Text = b.BookType;
                txtBookTitle.Text = b.BookTitle;
                txtPublisher.Text = b.Publisher;
                txtTotalStock.Text = b.TotalStock.ToString();
                txtNumberBorrow.Text = b.NumberBorrowed.ToString();
                txtAuthor.Text = b.Author;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNewBook f = new frmAddNewBook();
            f.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SA45_Team08B_LibraryEntities context = new SA45_Team08B_LibraryEntities();
            DialogResult r = MessageBox.Show("Are you sure to delete the record?", "Confirm", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    Book b = new Book();
                    int id = Convert.ToInt16(txtBook .Text); 
                    var q = from x in context.Books where x.BookID == id select x;
                    b = q.First();
                    context.Books.Remove(b);
                    context.SaveChanges();
                    ts.Complete();
                }
                sslDelete.Text = "You have deleted the record successfully.";
            }
        }

        private void txtBookTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            SA45_Team08B_LibraryEntities context = new SA45_Team08B_LibraryEntities();
            int id = Convert.ToInt16(txtBook.Text);
            Book b = new Book();
            b = context.Books.Where(x => x.BookID == id).First();

            txtBookType.Text = b.BookType;
            txtBookTitle.Text = b.BookTitle;
            txtPublisher.Text = b.Publisher;
            txtTotalStock.Text = b.TotalStock.ToString();
            txtNumberBorrow.Text = b.NumberBorrowed.ToString();
            txtAuthor.Text = b.Author;




        }
    }
}
