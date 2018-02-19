namespace Team08B_Library
{
    partial class frmMemberUpdates
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxMemberName = new System.Windows.Forms.TextBox();
            this.lvlMemberName = new System.Windows.Forms.Label();
            this.tbxMemberID = new System.Windows.Forms.TextBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hiGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBorrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCity = new System.Windows.Forms.Label();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.lblCountryCode = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.tbxPostalCode = new System.Windows.Forms.TextBox();
            this.lblMemberCategory = new System.Windows.Forms.Label();
            this.lblContactTitle = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbbContactTitle = new System.Windows.Forms.ComboBox();
            this.cbbCountryCode = new System.Windows.Forms.ComboBox();
            this.cbbMemberCategory = new System.Windows.Forms.ComboBox();
            this.lblCountryCodeValid = new System.Windows.Forms.Label();
            this.lblPostalCodeValid = new System.Windows.Forms.Label();
            this.lblCityValid = new System.Windows.Forms.Label();
            this.lblAddressValid = new System.Windows.Forms.Label();
            this.lblEmailValid = new System.Windows.Forms.Label();
            this.lblPhoneValid = new System.Windows.Forms.Label();
            this.lblMemberNameValid = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxMemberName
            // 
            this.tbxMemberName.Location = new System.Drawing.Point(102, 84);
            this.tbxMemberName.Name = "tbxMemberName";
            this.tbxMemberName.Size = new System.Drawing.Size(209, 20);
            this.tbxMemberName.TabIndex = 2;
            this.tbxMemberName.TextChanged += new System.EventHandler(this.tbxMemberName_TextChanged);
            // 
            // lvlMemberName
            // 
            this.lvlMemberName.AutoSize = true;
            this.lvlMemberName.Location = new System.Drawing.Point(12, 88);
            this.lvlMemberName.Name = "lvlMemberName";
            this.lvlMemberName.Size = new System.Drawing.Size(74, 13);
            this.lvlMemberName.TabIndex = 14;
            this.lvlMemberName.Text = "Member name";
            // 
            // tbxMemberID
            // 
            this.tbxMemberID.Enabled = false;
            this.tbxMemberID.Location = new System.Drawing.Point(102, 39);
            this.tbxMemberID.Name = "tbxMemberID";
            this.tbxMemberID.Size = new System.Drawing.Size(209, 20);
            this.tbxMemberID.TabIndex = 1;
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(12, 43);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(59, 13);
            this.lblMemberID.TabIndex = 15;
            this.lblMemberID.Text = "Member ID";
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(102, 173);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(209, 20);
            this.tbxPhone.TabIndex = 4;
            this.tbxPhone.TextChanged += new System.EventHandler(this.tbxPhone_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 177);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 19;
            this.lblPhone.Text = "Phone";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(384, 88);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 19;
            this.lblAddress.Text = "Address";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(460, 84);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(209, 20);
            this.tbxAddress.TabIndex = 7;
            this.tbxAddress.TextChanged += new System.EventHandler(this.tbxAddress_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 224);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 13);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email address";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(102, 220);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(209, 20);
            this.tbxEmail.TabIndex = 5;
            this.tbxEmail.TextChanged += new System.EventHandler(this.tbxEmail_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(490, 271);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.Leave += new System.EventHandler(this.btnUpdate_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiGuestToolStripMenuItem,
            this.searchBorrowToolStripMenuItem,
            this.memberInformationToolStripMenuItem,
            this.bookInformationToolStripMenuItem,
            this.returnBookToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hiGuestToolStripMenuItem
            // 
            this.hiGuestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem});
            this.hiGuestToolStripMenuItem.Name = "hiGuestToolStripMenuItem";
            this.hiGuestToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.hiGuestToolStripMenuItem.Text = "Hi, Guest";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.logInToolStripMenuItem.Text = "Log in";
            // 
            // searchBorrowToolStripMenuItem
            // 
            this.searchBorrowToolStripMenuItem.Name = "searchBorrowToolStripMenuItem";
            this.searchBorrowToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.searchBorrowToolStripMenuItem.Text = "Search & Borrow";
            // 
            // memberInformationToolStripMenuItem
            // 
            this.memberInformationToolStripMenuItem.Name = "memberInformationToolStripMenuItem";
            this.memberInformationToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.memberInformationToolStripMenuItem.Text = "Member Information";
            // 
            // bookInformationToolStripMenuItem
            // 
            this.bookInformationToolStripMenuItem.Name = "bookInformationToolStripMenuItem";
            this.bookInformationToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.bookInformationToolStripMenuItem.Text = "Book Information";
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.returnBookToolStripMenuItem.Text = "Return book";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(384, 133);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 19;
            this.lblCity.Text = "City";
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(460, 129);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(209, 20);
            this.tbxCity.TabIndex = 8;
            this.tbxCity.TextChanged += new System.EventHandler(this.tbxCity_TextChanged);
            // 
            // lblCountryCode
            // 
            this.lblCountryCode.AutoSize = true;
            this.lblCountryCode.Location = new System.Drawing.Point(384, 222);
            this.lblCountryCode.Name = "lblCountryCode";
            this.lblCountryCode.Size = new System.Drawing.Size(70, 13);
            this.lblCountryCode.TabIndex = 19;
            this.lblCountryCode.Text = "Country code";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(384, 178);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(63, 13);
            this.lblPostalCode.TabIndex = 19;
            this.lblPostalCode.Text = "Postal code";
            // 
            // tbxPostalCode
            // 
            this.tbxPostalCode.Location = new System.Drawing.Point(460, 174);
            this.tbxPostalCode.Name = "tbxPostalCode";
            this.tbxPostalCode.Size = new System.Drawing.Size(209, 20);
            this.tbxPostalCode.TabIndex = 9;
            this.tbxPostalCode.TextChanged += new System.EventHandler(this.tbxPostalCode_TextChanged);
            // 
            // lblMemberCategory
            // 
            this.lblMemberCategory.AutoSize = true;
            this.lblMemberCategory.Location = new System.Drawing.Point(12, 132);
            this.lblMemberCategory.Name = "lblMemberCategory";
            this.lblMemberCategory.Size = new System.Drawing.Size(89, 13);
            this.lblMemberCategory.TabIndex = 14;
            this.lblMemberCategory.Text = "Member category";
            // 
            // lblContactTitle
            // 
            this.lblContactTitle.AutoSize = true;
            this.lblContactTitle.Location = new System.Drawing.Point(384, 44);
            this.lblContactTitle.Name = "lblContactTitle";
            this.lblContactTitle.Size = new System.Drawing.Size(63, 13);
            this.lblContactTitle.TabIndex = 19;
            this.lblContactTitle.Text = "Contact title";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 361);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(687, 22);
            this.statusStrip1.TabIndex = 67;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // cbbContactTitle
            // 
            this.cbbContactTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbContactTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbContactTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbContactTitle.FormattingEnabled = true;
            this.cbbContactTitle.Items.AddRange(new object[] {
            "MS",
            "MR"});
            this.cbbContactTitle.Location = new System.Drawing.Point(460, 39);
            this.cbbContactTitle.Name = "cbbContactTitle";
            this.cbbContactTitle.Size = new System.Drawing.Size(121, 21);
            this.cbbContactTitle.TabIndex = 6;
            // 
            // cbbCountryCode
            // 
            this.cbbCountryCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbCountryCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCountryCode.FormattingEnabled = true;
            this.cbbCountryCode.Items.AddRange(new object[] {
            "BRA",
            "CAN",
            "FRA",
            "GER",
            "MAL",
            "SIN",
            "SLR",
            "SWZ"});
            this.cbbCountryCode.Location = new System.Drawing.Point(460, 220);
            this.cbbCountryCode.Name = "cbbCountryCode";
            this.cbbCountryCode.Size = new System.Drawing.Size(121, 21);
            this.cbbCountryCode.TabIndex = 10;
            this.cbbCountryCode.TextChanged += new System.EventHandler(this.cbbCountryCode_TextChanged);
            // 
            // cbbMemberCategory
            // 
            this.cbbMemberCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbMemberCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbMemberCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMemberCategory.FormattingEnabled = true;
            this.cbbMemberCategory.Items.AddRange(new object[] {
            "A",
            "AA",
            "B",
            "C",
            "D"});
            this.cbbMemberCategory.Location = new System.Drawing.Point(102, 128);
            this.cbbMemberCategory.Name = "cbbMemberCategory";
            this.cbbMemberCategory.Size = new System.Drawing.Size(121, 21);
            this.cbbMemberCategory.TabIndex = 3;
            this.cbbMemberCategory.SelectedIndexChanged += new System.EventHandler(this.cbbMemberCategory_SelectedIndexChanged);
            // 
            // lblCountryCodeValid
            // 
            this.lblCountryCodeValid.AutoSize = true;
            this.lblCountryCodeValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryCodeValid.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCountryCodeValid.Location = new System.Drawing.Point(459, 245);
            this.lblCountryCodeValid.Name = "lblCountryCodeValid";
            this.lblCountryCodeValid.Size = new System.Drawing.Size(0, 13);
            this.lblCountryCodeValid.TabIndex = 69;
            // 
            // lblPostalCodeValid
            // 
            this.lblPostalCodeValid.AutoSize = true;
            this.lblPostalCodeValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCodeValid.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPostalCodeValid.Location = new System.Drawing.Point(457, 197);
            this.lblPostalCodeValid.Name = "lblPostalCodeValid";
            this.lblPostalCodeValid.Size = new System.Drawing.Size(0, 13);
            this.lblPostalCodeValid.TabIndex = 69;
            // 
            // lblCityValid
            // 
            this.lblCityValid.AutoSize = true;
            this.lblCityValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityValid.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCityValid.Location = new System.Drawing.Point(457, 152);
            this.lblCityValid.Name = "lblCityValid";
            this.lblCityValid.Size = new System.Drawing.Size(0, 13);
            this.lblCityValid.TabIndex = 69;
            // 
            // lblAddressValid
            // 
            this.lblAddressValid.AutoSize = true;
            this.lblAddressValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressValid.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAddressValid.Location = new System.Drawing.Point(457, 107);
            this.lblAddressValid.Name = "lblAddressValid";
            this.lblAddressValid.Size = new System.Drawing.Size(0, 13);
            this.lblAddressValid.TabIndex = 69;
            // 
            // lblEmailValid
            // 
            this.lblEmailValid.AutoSize = true;
            this.lblEmailValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailValid.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEmailValid.Location = new System.Drawing.Point(101, 243);
            this.lblEmailValid.Name = "lblEmailValid";
            this.lblEmailValid.Size = new System.Drawing.Size(0, 13);
            this.lblEmailValid.TabIndex = 69;
            // 
            // lblPhoneValid
            // 
            this.lblPhoneValid.AutoSize = true;
            this.lblPhoneValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneValid.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPhoneValid.Location = new System.Drawing.Point(101, 196);
            this.lblPhoneValid.Name = "lblPhoneValid";
            this.lblPhoneValid.Size = new System.Drawing.Size(0, 13);
            this.lblPhoneValid.TabIndex = 69;
            // 
            // lblMemberNameValid
            // 
            this.lblMemberNameValid.AutoSize = true;
            this.lblMemberNameValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberNameValid.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMemberNameValid.Location = new System.Drawing.Point(101, 107);
            this.lblMemberNameValid.Name = "lblMemberNameValid";
            this.lblMemberNameValid.Size = new System.Drawing.Size(0, 13);
            this.lblMemberNameValid.TabIndex = 69;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(593, 271);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 70;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(387, 271);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 70;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "label1";
            // 
            // frmMemberUpdates
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(687, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblMemberNameValid);
            this.Controls.Add(this.lblPhoneValid);
            this.Controls.Add(this.lblEmailValid);
            this.Controls.Add(this.lblAddressValid);
            this.Controls.Add(this.lblCityValid);
            this.Controls.Add(this.lblPostalCodeValid);
            this.Controls.Add(this.lblCountryCodeValid);
            this.Controls.Add(this.cbbCountryCode);
            this.Controls.Add(this.cbbMemberCategory);
            this.Controls.Add(this.cbbContactTitle);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxPostalCode);
            this.Controls.Add(this.tbxCity);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.lblCountryCode);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblContactTitle);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblMemberCategory);
            this.Controls.Add(this.tbxMemberName);
            this.Controls.Add(this.lvlMemberName);
            this.Controls.Add(this.tbxMemberID);
            this.Controls.Add(this.lblMemberID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMemberUpdates";
            this.Text = "MemberInfo_UpdateDetails";
            this.Load += new System.EventHandler(this.MemberInfo_UpdateDetails_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxMemberName;
        private System.Windows.Forms.Label lvlMemberName;
        private System.Windows.Forms.TextBox tbxMemberID;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hiGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBorrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Label lblCountryCode;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.TextBox tbxPostalCode;
        private System.Windows.Forms.Label lblMemberCategory;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox cbbContactTitle;
        private System.Windows.Forms.ComboBox cbbCountryCode;
        private System.Windows.Forms.ComboBox cbbMemberCategory;
        private System.Windows.Forms.Label lblCountryCodeValid;
        private System.Windows.Forms.Label lblPostalCodeValid;
        private System.Windows.Forms.Label lblCityValid;
        private System.Windows.Forms.Label lblAddressValid;
        private System.Windows.Forms.Label lblEmailValid;
        private System.Windows.Forms.Label lblPhoneValid;
        private System.Windows.Forms.Label lblMemberNameValid;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
    }
}