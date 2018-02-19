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
    public partial class frmManagementReport : Form
    {
        public frmManagementReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            LibrarySet ds = new LibrarySet();
            LibrarySetTableAdapters.IssueTranTableAdapter itta = new LibrarySetTableAdapters.IssueTranTableAdapter();
            LibrarySetTableAdapters.MembersTableAdapter mtta = new LibrarySetTableAdapters.MembersTableAdapter();
            LibrarySetTableAdapters.BooksTableAdapter btta = new LibrarySetTableAdapters.BooksTableAdapter();
            itta.Fill(ds.IssueTran);
            mtta.Fill(ds.Members);
            btta.Fill(ds.Books);

            crManagementReport mit = new crManagementReport();
            mit.SetDataSource(ds);
            crystalReportViewer1.ReportSource = mit;
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
