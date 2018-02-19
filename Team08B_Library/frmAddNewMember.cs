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
using System.Collections;
using System.Text.RegularExpressions;

namespace Team08B_Library
{
    public partial class frmAddNewMember : Form
    {
        static SA45_Team08B_LibraryEntities context;
        readonly string NO_BLANK = "This field cannot be blank";
        int countID = 0;
        int countAdd = 0;
        int countCity = 0;
        int countEmail = 0;
        int countMemberName = 0;
        int countPostalCod = 0;
        int countPOB = 0;
        int countPhone = 0;

        Form f;
            
        //Select the get method from Member Information for the selected member
        string MemberIDSelected;

        Member member;
        
        public frmAddNewMember()
        {
            InitializeComponent();
        }

        public frmAddNewMember(string id)
        {
            InitializeComponent();

           
            MemberIDSelected = id;
        }

        private void MemberInfo_UpdateDetails_Load(object sender, EventArgs e)
        {
            statusStrip1.ForeColor = Color.White;
            context = new SA45_Team08B_LibraryEntities();

            lblIDValid.Text=lblAddressValid.Text = lblCityValid.Text = lblEmailValid.Text = lblMemberNameValid.Text
                = lblPostalCodeValid.Text = lblPlaceOfBirthValid.Text = lblPhoneValid.Text = "";
            cbbContactTitle.Text = "MR";
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult r = new DialogResult();
            r = MessageBox.Show("Are you sure you want to add this new member?", "Confirm update", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes) {
                using (TransactionScope ts = new TransactionScope()) {
                    member = new Member();
                    member.MemberID = tbxMemberID.Text;
                    member.Address = tbxAddress.Text;
                    member.City = tbxCity.Text;
                    member.City = "Singapore";
                    member.ContactTitle = cbbContactTitle.Text;
                    member.PlaceOfBirth = cbbPlaceOfBirth.Text;
                    member.EmailAddress = tbxEmail.Text;
                    //member.MemberCategory = cbbMemberCategory.Text;
                    member.MemberName = tbxMemberName.Text;
                    member.PhoneNumber = tbxPhone.Text;
                    member.PostalCode = tbxPostalCode.Text;
                    context.Members.Add(member);
                    context.SaveChanges();
                    toolStripStatusLabel1.Text = $"The information of Member with ID number {member.MemberID} was updated successfully.";
                    ts.Complete();
                }
            }

        }

        private void clickUpdateToUpdate()
        {
            toolStripStatusLabel1.Text = "Click Add New Member button to create a new member.";
        }

        

        private void btnUpdate_Leave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void checkBlank(Control v1, Control v2)
        {
            if (v1.Text == "") {
                v2.Text = NO_BLANK;
            }
            else {
                v2.Text = "";
            }

        }

        private void checkChanges()
        {
            if(lblAddressValid.Text == "" && lblCityValid.Text == "" && lblEmailValid.Text == "" && lblPlaceOfBirthValid.Text=="" && lblMemberNameValid.Text=="" && lblPhoneValid.Text=="" && lblPostalCodeValid.Text=="" && tbxEmail.ForeColor==Color.Black && tbxAddress.ForeColor == Color.Black && tbxCity.ForeColor == Color.Black && tbxMemberID.ForeColor == Color.Black && tbxMemberName.ForeColor == Color.Black && tbxPhone.ForeColor == Color.Black && tbxPostalCode.ForeColor == Color.Black)
            
            {
                //label1.Text = lblMemberNameValid.Text;
                clickUpdateToUpdate();
                btnAddMember.Enabled = true;
            }
            else {
                toolStripStatusLabel1.Text = "";
                btnAddMember.Enabled = false;
            }
        }
        private void tbxPhone_TextChanged(object sender, EventArgs e)
        {
            Regex rxPhone = new Regex(@"^\d{7}$");
            if (!rxPhone.IsMatch(tbxPhone.Text)) {
                lblPhoneValid.Text = "You should enter a 7-digit phone number.";
            }
            else {
                lblPhoneValid.Text = "";
            }
            checkChanges();
        }

        private void tbxPostalCode_TextChanged(object sender, EventArgs e)
        {
            Regex rxPostal = new Regex(@"^\d{6}$");

            if (!rxPostal.IsMatch(tbxPostalCode.Text)) {
                lblPostalCodeValid.Text = "You should enter a 6-digit postal code.";
                checkChanges();
            }
            else {
                lblPostalCodeValid.Text = "";
            }
            checkChanges();

        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {
            Regex rx = new Regex(
            @"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");

            if (!rx.IsMatch(tbxEmail.Text)) {
                lblEmailValid.Text = "You should enter a valid email address.";
                checkChanges();
            }
            else {
                lblEmailValid.Text = "";
            }
            checkChanges();

        }
        private void tbxMemberName_TextChanged(object sender, EventArgs e)
        {
            Regex rxName = new Regex(@"^([ \u00c0-\u01ffa-zA-Z'\-])+$");

            if (!rxName.IsMatch(tbxMemberName.Text)) {
                lblMemberNameValid.Text = "You should enter a valid name";
                checkChanges();
            }
            else {
                lblMemberNameValid.Text = "";
            }
            checkChanges();

        }

        private void tbxAddress_TextChanged(object sender, EventArgs e)
        {
            checkBlank(tbxAddress, lblAddressValid);
            checkChanges();

        }

        private void tbxCity_TextChanged(object sender, EventArgs e)
        {
            checkBlank(tbxCity, lblCityValid);
            checkChanges();

        }


        private void cbbCountryCode_TextChanged(object sender, EventArgs e)
        {
            checkBlank(cbbPlaceOfBirth, lblPlaceOfBirthValid);
            checkChanges();
        }

        private void cbbMemberCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkChanges();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MemberInfo_UpdateDetails_Load(null, new EventArgs());
            lblAddressValid.Text = "";
            lblPostalCodeValid.Text = "";
            lblPhoneValid.Text = "";
            lblMemberNameValid.Text = "";
            lblEmailValid.Text = "";
            lblPlaceOfBirthValid.Text = "";
            lblCityValid.Text = "";
            lblAddressValid.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbxMemberID_TextChanged(object sender, EventArgs e)
        {
            Regex rxID = new Regex("^[0-9]*$");

            try {
                member = context.Members.Where(x => x.MemberID == tbxMemberID.Text).First();
                lblIDValid.Text = "This member ID exists. Please enter another one.";

            }
            catch (Exception e1) {
                if (!rxID.IsMatch(tbxMemberID.Text)) {
                    lblIDValid.Text = "You should enter a valid member ID.";
                    checkChanges();
                }
                else {
                    lblIDValid.Text = "";
                }
            }
            

            
            

            checkChanges();


        }

        private void tbxMemberID_Click(object sender, EventArgs e)
        {
            countID++;
            tbxMemberID.ForeColor = Color.Black;
            if (countID == 1) {
                tbxMemberID.Text = "";
            }
        }

        private void cbbPlaceOfBirth_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tbxMemberName_Click(object sender, EventArgs e)
        {
            countMemberName++;
            tbxMemberName.ForeColor = Color.Black;
            if (countMemberName == 1) {
                tbxMemberName.Text = "";
            }
        }

        private void tbxPhone_Click(object sender, EventArgs e)
        {
            countPhone++;
            tbxPhone.ForeColor = Color.Black;
            if (countPhone == 1) {
                tbxPhone.Text = "";
            }
        }

        private void tbxEmail_Click(object sender, EventArgs e)
        {
            countEmail++;
            tbxEmail.ForeColor = Color.Black;
            if (countEmail == 1) {
                tbxEmail.Text = "";
            }
        }

        private void tbxAddress_Click(object sender, EventArgs e)
        {
            countAdd++;
            tbxAddress.ForeColor = Color.Black;
            if (countAdd == 1) {
                tbxAddress.Text = "";
            }
        }

        private void tbxCity_Click(object sender, EventArgs e)
        {
            countCity++;
            tbxCity.ForeColor = Color.Black;
            if (countCity == 1) {
                tbxCity.Text = "";
            }
        }

        private void tbxPostalCode_Click(object sender, EventArgs e)
        {
            countPostalCod++;
            tbxPostalCode.ForeColor = Color.Black;
            if (countPostalCod == 1) {
                tbxPostalCode.Text = "";
            }
        }

        private void cbbPlaceOfBirth_Click(object sender, EventArgs e)
        {
            countPOB++;
            cbbPlaceOfBirth.ForeColor = Color.Black;
            if (countPOB == 1) {
                cbbPlaceOfBirth.Text = "";
            }
        }
    }
}
