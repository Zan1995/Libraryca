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
    public partial class frmBookList : Form
    {
        public frmBookList()
        {
            InitializeComponent();
        }

        private void frmReport1_Load(object sender, EventArgs e)
        {
            LibrarySet  ds = new LibrarySet ();
            LibrarySetTableAdapters.BooksTableAdapter  ta = new LibrarySetTableAdapters.BooksTableAdapter();
            ta.Fill(ds.Books );

            crBookList cr = new crBookList();

            cr.SetDataSource(ds);

            crvBookList.ReportSource = cr;
            
        }
    }
}
