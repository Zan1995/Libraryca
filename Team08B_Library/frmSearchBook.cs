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
    public partial class frmSearchBook : Form
    {
        SA45_Team08B_LibraryEntities context;
        List<Book> b;

        public frmSearchBook()
        {
            InitializeComponent();
            context = new SA45_Team08B_LibraryEntities();

        }

        private void frmSearchBook_Load(object sender, EventArgs e)
        {
            rbtAll.Checked = true;

            b = BookList();
            dgvSearch.DataSource = b;
            dgvSearch.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            cboSearch.Items.Add("Title");
            cboSearch.Items.Add("Genre");
            cboSearch.Items.Add("Author");
            cboSearch.Items.Add("Publisher");
            RecordsFound();
            cboSearch.SelectedIndex = 0;
            statusStrip1.ForeColor = Color.White;
        }

        public string GetID
        {
            get { return dgvSearch.CurrentRow.Cells[0].Value.ToString(); }
        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            this.ActiveControl = txtSearch;
        }

        private void dgvSearch_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            b = BookList();
            dgvSearch.DataSource = b;
            dgvSearch.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            RecordsFound();
            
        }        

        private void RecordsFound()
        {
            tssSearch.Text = "Records found: ";
            tssSearch.Text += dgvSearch.Rows.Count;
        }

        private List<Book> BookList()
        {

            if (rbtAll.Checked)
            {
                switch (cboSearch.SelectedIndex)
                {
                    case 0:
                        return context.Books.Where(x => x.BookTitle.Contains(txtSearch.Text)).ToList();
                        
                    case 1:
                        return context.Books.Where(x => x.BookType.Contains(txtSearch.Text)).ToList();
                        
                    case 2:
                        return context.Books.Where(x => x.Author.Contains(txtSearch.Text)).ToList();
                        
                    default:
                        return context.Books.Where(x => x.Publisher.Contains(txtSearch.Text)).ToList();
                        
                }
            }
            else if (rbtInStock.Checked)
            {
                switch (cboSearch.SelectedIndex)
                {
                    case 0:
                        return context.Books.Where(x => x.BookTitle.Contains(txtSearch.Text) 
                            && x.NumberBorrowed != x.TotalStock ).ToList();
                        
                    case 1:
                        return context.Books.Where(x => x.BookType.Contains(txtSearch.Text)
                            && x.NumberBorrowed != x.TotalStock).ToList();
                        
                    case 2:
                        return context.Books.Where(x => x.Author.Contains(txtSearch.Text) 
                            && x.NumberBorrowed != x.TotalStock).ToList();
                        
                    default:
                        return context.Books.Where(x => x.Publisher.Contains(txtSearch.Text)
                            && x.NumberBorrowed != x.TotalStock).ToList();
                        
                }
            }
            else
            {
                switch (cboSearch.SelectedIndex)
                {
                    case 0:
                        return context.Books.Where(x => x.BookTitle.Contains(txtSearch.Text)
                            && x.NumberBorrowed == x.TotalStock).ToList();
                        
                    case 1:
                        return context.Books.Where(x => x.BookType.Contains(txtSearch.Text)
                            && x.NumberBorrowed == x.TotalStock).ToList();
                       
                    case 2:
                        return context.Books.Where(x => x.Author.Contains(txtSearch.Text)
                            && x.NumberBorrowed == x.TotalStock).ToList();
                       
                    default:
                        return context.Books.Where(x => x.Publisher.Contains(txtSearch.Text)
                            && x.NumberBorrowed == x.TotalStock).ToList();                        
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }



        //private void dgvSearch_Scroll(object sender, ScrollEventArgs e)
        //{
        //    dgvSearch.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        //    dgvSearch.Refresh();
        //}

        //private void RadioChange()
        //{         

        //    if (txtSearch.Text == "")
        //    {

        //    }

        //}

        //private int RadioSelection
        //{
        //    get
        //    {
        //        if (rbtAll.Checked) return 0;
        //        if (rbtInStock.Checked) return 1;
        //        return 2;
        //    }
        //}
    }
}
