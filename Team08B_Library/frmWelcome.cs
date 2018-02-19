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
    public partial class frmWelcome : Form
    {
        Form f;
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
           
        }

        private void frmWelcome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmWelcome_Click(object sender, EventArgs e)
        {
            //hide welcome screen and show view book info screen
            this.Hide();
            f = new frmBookInfo("Guest");
            f.Show();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (f = new frmLogin())
            { 
                f.ShowDialog();
                if(IsCancelAbort(f)) return;   
            }
            f = new frmBorrowBook();
            f.Show();    
               
        }

        private bool IsCancelAbort(Form f)
        {
            if (f.DialogResult == DialogResult.Cancel)
            {
                this.Show();
                return true;
            }
            if (f.DialogResult == DialogResult.Abort)
            {
                this.Close();
                return true;
            }
            return false;
        }

    }
}
