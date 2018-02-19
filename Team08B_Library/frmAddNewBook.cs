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
    public partial class frmAddNewBook : Form
    {
        int[] tbCount;


        public frmAddNewBook()
        {
            InitializeComponent();
            tbCount = new int[] { 0, 0, 0, 0, 0, 0 };
        }

        public void ClearDefault(TextBox t)
        {
            if (tbCount[t.TabIndex] < 0)
            {
                t.Text = "";
                t.ForeColor = Color.Black;
                tbCount[t.TabIndex]++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SA45_Team08B_LibraryEntities context = new SA45_Team08B_LibraryEntities();     

            short bkID;
            int testId;
            short bkStock; 
            bool valid = true; 
            Book b; 
            if (!Int16.TryParse(txtBID.Text, out bkID))
            {
                if (int.TryParse(txtBID.Text, out testId))
                {
                    lblErrorID.Text = "Select an ID less than 32768";
                }
                else
                {
                    lblErrorID.Text = "Book ID should only contain numbers";
                }
                valid = false;
            }
            else
            {
                try
                {
                    b = context.Books.Where(x => x.BookID == bkID).First();
                   //no error means book is already inside database
                    lblErrorID.Text = "Book ID in use. Please enter another ID";
                    valid = false;
                }
                catch (Exception ex)
                {
                    lblErrorID.Text = "";
                }
            }
            

            if (txtBookTitle.Text == "")
            {
                lblErrorTitle.Text = "Title field cannot be empty";
                valid = false;
            }
            else
            {
                lblErrorTitle.Text = "";
            }

            if (cmbBookType.Text == "")
            {
                lblErrorType.Text = "Please select a book type";
                valid = false;
            }
            else
            {
                lblErrorType.Text = "";
            }

            if (txtPublisher.Text == "")
            {
                lblErrorPublisher.Text = "Publisher field cannot be empty";
                valid = false;
            }
            else
            {
                lblErrorPublisher.Text = "";
            }
            if (txtAuthor.Text == "")
            {
                lblErrorAuthor.Text = "Author field cannot be empty";
                valid = false;
            }
            else
            {
                lblErrorAuthor.Text = "";
            }
            if (!Int16.TryParse(txtTotalStock.Text, out bkStock))
            {
                lblErrorStock.Text = "Please enter a number";
                valid = false;
            }
            else
            {
                lblErrorStock.Text = "";
            }

            if (valid)
            { 
                DialogResult r = MessageBox.Show("Are you sure to add the book?", "Confirm", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    using (TransactionScope ts = new TransactionScope())
                    {
                            Book bk = new Book();
                            bk.BookID = Convert.ToInt16(txtBID.Text);
                            bk.BookTitle = txtBookTitle.Text;
                            bk.BookType = cmbBookType.Text;
                            bk.Author = txtAuthor.Text;
                            bk.Publisher = txtPublisher.Text;
                            bk.TotalStock = Convert.ToInt16(txtTotalStock.Text);
                        
                            context.Books.Add(bk);

                            context.SaveChanges();

                            ts.Complete();
                            sslAdd.Text = "You have added the book successfully!";                        
                    }
                }
                
            }
        }

        private void frmAddNewBook_Load(object sender, EventArgs e)
        {
            sspAdd.ForeColor = Color.White;
            lblErrorStock.Text = "";
            lblErrorAuthor.Text = "";
            lblErrorID.Text = "";
            lblErrorPublisher.Text = "";
            lblErrorType.Text = "";
            lblErrorTitle.Text = "";
        }

        private void txtBID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtBID_Leave(object sender, EventArgs e)
        {
            //SA45_Team08B_LibraryEntities context = new SA45_Team08B_LibraryEntities();

            //long  bkID;
            //if (!Int64.TryParse(txtBID.Text, out bkID ))
            //{
            //    lblErrorID.Text = "Only integer numbers are allowed";
            //    return;
            //}
            //else if (bkID > 32767)
            //{
            //    lblErrorID.Text = "This number is not allowed :must be short integer";
            //}

            //else
            //{
            //    try
            //    {
            //        bkID = Convert.ToInt16(txtBID.Text);
            //        Book bk = context.Books.Where(x => x.BookID == bkID).First();
            //        lblErrorID.Text = "This ID has existed";
            //    }

                
            //    catch (Exception ex)
            //    {
            //        lblErrorID.Text = "ID is available";

            //    }
            //}


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public void ClearDefault(object sender, EventArgs e)
        {
            TextBox t;
            ComboBox c;
            if (sender is TextBox)
            {
                t = (TextBox)sender;
                if (tbCount[t.TabIndex] < 1)
                {
                    t.Text = "";
                    t.ForeColor = Color.Black;
                    tbCount[t.TabIndex]++;
                }
            }
            if (sender is ComboBox)
            {
                c = (ComboBox) sender;
                if (tbCount[c.TabIndex] < 1)
                {
                    c.Text = "";
                    c.ForeColor = Color.Black;
                    tbCount[c.TabIndex]++;
                }
            }
        
        }
    }
}
