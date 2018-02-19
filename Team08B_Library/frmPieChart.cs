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
    public partial class frmPieChart : Form
    {
        public frmPieChart()
        {
            InitializeComponent();
        }

        private void frmPieChart_Load(object sender, EventArgs e)
        {
            LibrarySet ds = new LibrarySet();
            LibrarySetTableAdapters.BooksTableAdapter ta = new LibrarySetTableAdapters.BooksTableAdapter();
            ta.Fill(ds.Books);

            crPie  cr = new crPie ();

            cr.SetDataSource(ds);

            crvPieChart .ReportSource = cr;
        }
    }
}
