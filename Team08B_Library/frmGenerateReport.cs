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
    public partial class frmGenerateReport : Form
    {
        frmBorrowBook f;
        short getid;
        public frmGenerateReport()
        {
            InitializeComponent();
            getid = 1;
        }

        public frmGenerateReport(short transId)
        {
            InitializeComponent();
            getid = transId;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
            
            
            LibrarySet ds = new LibrarySet();
            LibrarySetTableAdapters.IssueTranTableAdapter itta = new LibrarySetTableAdapters.IssueTranTableAdapter();
            LibrarySetTableAdapters.MembersTableAdapter mtta = new LibrarySetTableAdapters.MembersTableAdapter();
            LibrarySetTableAdapters.BooksTableAdapter btta = new LibrarySetTableAdapters.BooksTableAdapter();
            ////To Generate Receipt from crReceipt
            itta.FillBy(ds.IssueTran, getid);
            mtta.Fill(ds.Members);
            btta.Fill(ds.Books);
            crReceipt mit = new crReceipt();
            mit.SetDataSource(ds);
            //To Generate Receipt from crManagement Report
            //itta.Fill(ds.IssueTran);
            //mtta.Fill(ds.Members);
            //btta.Fill(ds.Books);
            //crManagementReport mit = new crManagementReport();
            //mit.SetDataSource(ds);
            crystalReportViewer1.ReportSource = mit;



        }
    }
}
