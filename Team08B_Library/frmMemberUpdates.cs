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
    public partial class frmMemberUpdates : Form
    {
        static SA45_Team08B_LibraryEntities context;
        readonly string NO_BLANK = "This field cannot be blank";


        //Select the get method from Member Information for the selected member
        string MemberIDSelected;

        Member member;

        public frmMemberUpdates()
        {
            InitializeComponent();
        }
        public frmMemberUpdates(string id)
        {
            InitializeComponent();
            
            MemberIDSelected = id;
        }

        private void MemberInfo_UpdateDetails_Load(object sender, EventArgs e)
        {
            statusStrip1.ForeColor = Color.White;
            context = new SA45_Team08B_LibraryEntities();
            member = context.Members.Where(x => x.MemberID == MemberIDSelected).First();

            lblAddressValid.Text = lblCityValid.Text = lblEmailValid.Text = lblMemberNameValid.Text
                = lblPostalCodeValid.Text = lblPlaceOfBirthValid.Text = lblPhoneValid.Text = "";
            tbxAddress.Text = member.Address;
            tbxCity.Text = member.City;
            tbxMemberID.Text = member.MemberID;
            cbbContactTitle.Text = member.ContactTitle;
            cbbPlaceOfBirth.Text = member.PlaceOfBirth;
            tbxEmail.Text = member.EmailAddress;
            //cbbMemberCategory.Text = member.MemberCategory;
            tbxMemberName.Text = member.MemberName;
            tbxPhone.Text = member.PhoneNumber;
            tbxPostalCode.Text = member.PostalCode;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult r = new DialogResult();
            r = MessageBox.Show("Are you sure you want to update the information?", "Confirm update", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes) {
                using (TransactionScope ts = new TransactionScope()) {
                    member.Address = tbxAddress.Text;
                    member.City = tbxCity.Text;
                    member.City = tbxCity.Text;
                    member.ContactTitle = cbbContactTitle.Text;
                    member.PlaceOfBirth = cbbPlaceOfBirth.Text.ToUpper();
                    member.EmailAddress = tbxEmail.Text;
                    //member.MemberCategory = cbbMemberCategory.Text;
                    member.MemberName = tbxMemberName.Text;
                    member.PhoneNumber = tbxPhone.Text;
                    member.PostalCode = tbxPostalCode.Text;
                    context.SaveChanges();
                    toolStripStatusLabel1.Text = $"The information of Member with ID number {MemberIDSelected} was updated successfully.";
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
            if((tbxAddress.Text != member.Address ||
            tbxCity.Text != member.City ||
            cbbContactTitle.Text != member.ContactTitle || 
            cbbPlaceOfBirth.Text != member.PlaceOfBirth || 
            tbxEmail.Text != member.EmailAddress ||
            //cbbMemberCategory.Text != member.MemberCategory ||
            tbxMemberName.Text != member.MemberName ||
            tbxPhone.Text != member.PhoneNumber ||
            tbxPostalCode.Text != member.PostalCode) && 
            (lblAddressValid.Text == "" && lblCityValid.Text == "" && lblEmailValid.Text == "" 
                && lblPlaceOfBirthValid.Text=="" && lblMemberNameValid.Text=="" && lblPhoneValid.Text=="" && lblPostalCodeValid.Text=="") 
            //&&
            //(tbxAddress.Text != "" &&
            //tbxCity.Text != "" &&
            //cbbContactTitle.Text != "" &&
            //cbbCountryCode.Text != "" &&
            //tbxEmail.Text != "" &&
            //cbbMemberCategory.Text != "" &&
            //tbxMemberName.Text != "" &&
            //tbxPhone.Text != "" &&
            //tbxPostalCode.Text != "")
            ) {
                //label1.Text = lblMemberNameValid.Text;
                clickUpdateToUpdate();
                btnUpdate.Enabled = true;
            }
            else {
                toolStripStatusLabel1.Text = "";
                btnUpdate.Enabled = false;
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
    }
}
