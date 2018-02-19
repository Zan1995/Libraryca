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
    public partial class frmSearchMember : Form
    {
        SA45_Team08B_LibraryEntities context;
        List<Member> m;

        public frmSearchMember()
        {
            InitializeComponent();
            context = new SA45_Team08B_LibraryEntities();
        }

        private void frmSearchMember_Load(object sender, EventArgs e)
        {
            statusStrip1.ForeColor = Color.White;
            m = context.Members.ToList();
            dgvSearch.DataSource = m;

            dgvSearch.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            cboSearch.Items.Add("Name");
            cboSearch.Items.Add("Phone Number");
            cboSearch.Items.Add("Place of Birth");
            RecordsFound();
            cboSearch.SelectedIndex = 0;
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
            switch (cboSearch.SelectedIndex)
            {
                case 0:
                    m = context.Members.Where(x => x.MemberName.Contains(txtSearch.Text)).ToList();
                    break;
                case 1:
                    m = context.Members.Where(x => x.PhoneNumber.Contains(txtSearch.Text)).ToList();
                    break;
                default:
                    m = context.Members.Where(x => x.PlaceOfBirth.Contains(txtSearch.Text)).ToList();
                    break;
            }

            dgvSearch.DataSource = m;
            dgvSearch.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            RecordsFound();
        }

        private void RecordsFound()
        {
            tssSearch.Text = "Records found: ";
            tssSearch.Text += dgvSearch.Rows.Count;
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
    }
}
