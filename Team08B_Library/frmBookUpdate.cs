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
using System.Text.RegularExpressions;

namespace Team08B_Library
{
    public partial class frmBookUpdate : Form
    {
        SA45_Team08B_LibraryEntities context;
        Book book;
        readonly string NO_BLANK = "This field cannot be blank";
        frmBookInfo f;

        //Select the get method from Book Information for the selected book
        short BookIDSelected;

        public frmBookUpdate()
        {
            InitializeComponent();
            
        }
        public frmBookUpdate(frmBookInfo f)
        {
            InitializeComponent();
            this.f = f;
            BookIDSelected = f.GetID;
        }

        private void BookInfo_Update_Load(object sender, EventArgs e)
        {
            statusStrip1.ForeColor = Color.White;
            context = new SA45_Team08B_LibraryEntities();

            lblAuthorValid.Text = lblBookTitleValid.Text = lblBookTypeValid.Text = lblPublisherValid.Text = lblTotalStockValid.Text = ""; 

            book = context.Books.Where(x => x.BookID == BookIDSelected).First();

            nudTotalStock.Value = (short)book.TotalStock;
            tbxAuthor.Text = book.Author;
            tbxBookID.Text = book.BookID.ToString();
            tbxBookTitle.Text = book.BookTitle;
            cbbBookType.Text = book.BookType;
            tbxNumberBorowed.Text = book.NumberBorrowed.ToString();
            tbxPublisher.Text = book.Publisher;
            //cbbRating.Text = book.Rating;
            //nudTotalStock.Maximum = 20;
            //nudTotalStock.Minimum = 1;
            checkChanges();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult r = new DialogResult();
            r = MessageBox.Show("Are you sure you want to update the information?", "Confirm update", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes) {
                using (TransactionScope ts = new TransactionScope()) {
                    book.Author = tbxAuthor.Text;
                    book.BookTitle = tbxBookTitle.Text;
                    book.BookType = cbbBookType.Text;
                    if ((nudTotalStock.Value > 20) || (nudTotalStock.Value < 1)) {
                        toolStripStatusLabel1.Text = "Total stock should be from 1 to 20 items.";
                        return;
                    }
                    else
                        book.TotalStock = (short)nudTotalStock.Value;
                    book.Publisher = tbxPublisher.Text;
                    //book.Rating = cbbRating.Text;
                    toolStripStatusLabel1.Text = $"Information of book ID number {BookIDSelected} was updated successfully.";
                    context.SaveChanges();
                    ts.Complete();
                }
            }
        }

        
        private void clickUpdateToUpdate()
        {
            toolStripStatusLabel1.Text = "Click Update button for saving changes.";
        }
        private void btnUpdate_Leave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void checkChanges()
        {
            if ((nudTotalStock.Value != (short)book.TotalStock||
            tbxAuthor.Text != book.Author||
            tbxBookTitle.Text != book.BookTitle||
            cbbBookType.Text != book.BookType||
            tbxPublisher.Text != book.Publisher/*||
            cbbRating.Text != book.Rating*/)&&
            (tbxAuthor.Text != "" &&
            tbxBookTitle.Text != "" &&
            cbbBookType.Text != "" &&
            tbxPublisher.Text != "")) {
                clickUpdateToUpdate();
                btnUpdate.Enabled = true;
            }
            else {
                toolStripStatusLabel1.Text = "";
                btnUpdate.Enabled = false;
            }
        }

        public void checkBlank(Control v1, Control v2)
        {
            if (v1.Text == "") {
                v2.Text = NO_BLANK;
            }
            else {
                v2.Text = "";
            }
        }

        private void tbxBookTitle_TextChanged(object sender, EventArgs e)
        {
            checkChanges();
            checkBlank(tbxBookTitle, lblBookTitleValid);
        }

        private void cbbBookType_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkChanges();
            checkBlank(cbbBookType, lblBookTypeValid);
        }

        private void cbbRating_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkChanges();
        }

        private void tbxPublisher_TextChanged(object sender, EventArgs e)
        {
            checkChanges();
            checkBlank(tbxPublisher, lblPublisherValid);
        }

        private void tbxAuthor_TextChanged(object sender, EventArgs e)
        {
            checkChanges();

            checkBlank(tbxAuthor, lblAuthorValid);
        }

        private void nudTotalStock_ValueChanged(object sender, EventArgs e)
        {
            checkChanges();
            if (nudTotalStock.Value > 20) {
                nudTotalStock.Value = 20;
                lblTotalStockValid.Text = "Total stock should be from 1 to 20 items.";
            } else if (nudTotalStock.Value < 1) {
                nudTotalStock.Value = 1;
                lblTotalStockValid.Text = "Total stock should be from 1 to 20 items.";
            }
            else {
                lblTotalStockValid.Text = "";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BookInfo_Update_Load(null, new EventArgs());
            lblBookTitleValid.Text = "";
            lblBookTypeValid.Text = "";
            lblPublisherValid.Text = "";
            lblTotalStockValid.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
