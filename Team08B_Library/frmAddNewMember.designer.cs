namespace Team08B_Library
{
    partial class frmAddNewMember
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
            this.btnAddMember = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBigTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAddressValid = new System.Windows.Forms.Label();
            this.lblIDValid = new System.Windows.Forms.Label();
            this.lblPlaceOfBirthValid = new System.Windows.Forms.Label();
            this.lblMemberNameValid = new System.Windows.Forms.Label();
            this.lblPhoneValid = new System.Windows.Forms.Label();
            this.lblEmailValid = new System.Windows.Forms.Label();
            this.lblPostalCodeValid = new System.Windows.Forms.Label();
            this.lblCityValid = new System.Windows.Forms.Label();
            this.cbbPlaceOfBirth = new System.Windows.Forms.ComboBox();
            this.cbbContactTitle = new System.Windows.Forms.ComboBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxPostalCode = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlaceOfBirth = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbxMemberName = new System.Windows.Forms.TextBox();
            this.lvlMemberName = new System.Windows.Forms.Label();
            this.tbxMemberID = new System.Windows.Forms.TextBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddMember
            // 
            this.btnAddMember.Enabled = false;
            this.btnAddMember.FlatAppearance.BorderSize = 0;
            this.btnAddMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.Location = new System.Drawing.Point(318, 397);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(150, 30);
            this.btnAddMember.TabIndex = 11;
            this.btnAddMember.Text = "Add new member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnAddMember.Leave += new System.EventHandler(this.btnUpdate_Leave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(37)))), ((int)(((byte)(117)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 67;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // lblBigTitle
            // 
            this.lblBigTitle.AutoSize = true;
            this.lblBigTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBigTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBigTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBigTitle.Location = new System.Drawing.Point(284, 28);
            this.lblBigTitle.Name = "lblBigTitle";
            this.lblBigTitle.Size = new System.Drawing.Size(183, 24);
            this.lblBigTitle.TabIndex = 72;
            this.lblBigTitle.Text = "Add A New Member";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(764, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(20, 20);
            this.btnCancel.TabIndex = 77;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(202)))), ((int)(((byte)(238)))));
            this.groupBox1.Controls.Add(this.lblAddressValid);
            this.groupBox1.Controls.Add(this.lblIDValid);
            this.groupBox1.Controls.Add(this.lblPlaceOfBirthValid);
            this.groupBox1.Controls.Add(this.lblMemberNameValid);
            this.groupBox1.Controls.Add(this.lblPhoneValid);
            this.groupBox1.Controls.Add(this.lblEmailValid);
            this.groupBox1.Controls.Add(this.lblPostalCodeValid);
            this.groupBox1.Controls.Add(this.lblCityValid);
            this.groupBox1.Controls.Add(this.cbbPlaceOfBirth);
            this.groupBox1.Controls.Add(this.cbbContactTitle);
            this.groupBox1.Controls.Add(this.tbxEmail);
            this.groupBox1.Controls.Add(this.tbxCity);
            this.groupBox1.Controls.Add(this.tbxPostalCode);
            this.groupBox1.Controls.Add(this.tbxAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblPlaceOfBirth);
            this.groupBox1.Controls.Add(this.lblPostalCode);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.tbxPhone);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.tbxMemberName);
            this.groupBox1.Controls.Add(this.lvlMemberName);
            this.groupBox1.Controls.Add(this.tbxMemberID);
            this.groupBox1.Controls.Add(this.lblMemberID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 327);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MemberInformation";
            // 
            // lblAddressValid
            // 
            this.lblAddressValid.AutoSize = true;
            this.lblAddressValid.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressValid.ForeColor = System.Drawing.Color.Red;
            this.lblAddressValid.Location = new System.Drawing.Point(133, 231);
            this.lblAddressValid.Name = "lblAddressValid";
            this.lblAddressValid.Size = new System.Drawing.Size(70, 13);
            this.lblAddressValid.TabIndex = 102;
            this.lblAddressValid.Text = "Address Error";
            // 
            // lblIDValid
            // 
            this.lblIDValid.AutoSize = true;
            this.lblIDValid.BackColor = System.Drawing.Color.Transparent;
            this.lblIDValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDValid.ForeColor = System.Drawing.Color.Red;
            this.lblIDValid.Location = new System.Drawing.Point(133, 52);
            this.lblIDValid.Name = "lblIDValid";
            this.lblIDValid.Size = new System.Drawing.Size(43, 13);
            this.lblIDValid.TabIndex = 101;
            this.lblIDValid.Text = "ID Error";
            // 
            // lblPlaceOfBirthValid
            // 
            this.lblPlaceOfBirthValid.AutoSize = true;
            this.lblPlaceOfBirthValid.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaceOfBirthValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceOfBirthValid.ForeColor = System.Drawing.Color.Red;
            this.lblPlaceOfBirthValid.Location = new System.Drawing.Point(412, 54);
            this.lblPlaceOfBirthValid.Name = "lblPlaceOfBirthValid";
            this.lblPlaceOfBirthValid.Size = new System.Drawing.Size(59, 13);
            this.lblPlaceOfBirthValid.TabIndex = 101;
            this.lblPlaceOfBirthValid.Text = "Place Error";
            // 
            // lblMemberNameValid
            // 
            this.lblMemberNameValid.AutoSize = true;
            this.lblMemberNameValid.BackColor = System.Drawing.Color.Transparent;
            this.lblMemberNameValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberNameValid.ForeColor = System.Drawing.Color.Red;
            this.lblMemberNameValid.Location = new System.Drawing.Point(219, 95);
            this.lblMemberNameValid.Name = "lblMemberNameValid";
            this.lblMemberNameValid.Size = new System.Drawing.Size(60, 13);
            this.lblMemberNameValid.TabIndex = 99;
            this.lblMemberNameValid.Text = "Name Error";
            // 
            // lblPhoneValid
            // 
            this.lblPhoneValid.AutoSize = true;
            this.lblPhoneValid.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneValid.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneValid.Location = new System.Drawing.Point(133, 141);
            this.lblPhoneValid.Name = "lblPhoneValid";
            this.lblPhoneValid.Size = new System.Drawing.Size(63, 13);
            this.lblPhoneValid.TabIndex = 98;
            this.lblPhoneValid.Text = "Phone Error";
            // 
            // lblEmailValid
            // 
            this.lblEmailValid.AutoSize = true;
            this.lblEmailValid.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailValid.ForeColor = System.Drawing.Color.Red;
            this.lblEmailValid.Location = new System.Drawing.Point(414, 141);
            this.lblEmailValid.Name = "lblEmailValid";
            this.lblEmailValid.Size = new System.Drawing.Size(57, 13);
            this.lblEmailValid.TabIndex = 97;
            this.lblEmailValid.Text = "Email Error";
            // 
            // lblPostalCodeValid
            // 
            this.lblPostalCodeValid.AutoSize = true;
            this.lblPostalCodeValid.BackColor = System.Drawing.Color.Transparent;
            this.lblPostalCodeValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCodeValid.ForeColor = System.Drawing.Color.Red;
            this.lblPostalCodeValid.Location = new System.Drawing.Point(514, 282);
            this.lblPostalCodeValid.Name = "lblPostalCodeValid";
            this.lblPostalCodeValid.Size = new System.Drawing.Size(61, 13);
            this.lblPostalCodeValid.TabIndex = 96;
            this.lblPostalCodeValid.Text = "Postal Error";
            // 
            // lblCityValid
            // 
            this.lblCityValid.AutoSize = true;
            this.lblCityValid.BackColor = System.Drawing.Color.Transparent;
            this.lblCityValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityValid.ForeColor = System.Drawing.Color.Red;
            this.lblCityValid.Location = new System.Drawing.Point(131, 282);
            this.lblCityValid.Name = "lblCityValid";
            this.lblCityValid.Size = new System.Drawing.Size(46, 13);
            this.lblCityValid.TabIndex = 100;
            this.lblCityValid.Text = "CC Error";
            // 
            // cbbPlaceOfBirth
            // 
            this.cbbPlaceOfBirth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbPlaceOfBirth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbPlaceOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPlaceOfBirth.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbbPlaceOfBirth.FormattingEnabled = true;
            this.cbbPlaceOfBirth.Items.AddRange(new object[] {
            "Brazil",
            "Canada",
            "France",
            "Germany",
            "Malaysia",
            "Singapore",
            "Sri Lanka",
            "Switzerland"});
            this.cbbPlaceOfBirth.Location = new System.Drawing.Point(415, 28);
            this.cbbPlaceOfBirth.Name = "cbbPlaceOfBirth";
            this.cbbPlaceOfBirth.Size = new System.Drawing.Size(284, 24);
            this.cbbPlaceOfBirth.TabIndex = 2;
            this.cbbPlaceOfBirth.Text = "eg. Brazil";
            this.cbbPlaceOfBirth.SelectedIndexChanged += new System.EventHandler(this.cbbPlaceOfBirth_SelectedIndexChanged);
            this.cbbPlaceOfBirth.TextChanged += new System.EventHandler(this.cbbCountryCode_TextChanged);
            this.cbbPlaceOfBirth.Click += new System.EventHandler(this.cbbPlaceOfBirth_Click);
            this.cbbPlaceOfBirth.Enter += new System.EventHandler(this.cbbPlaceOfBirth_Click);
            // 
            // cbbContactTitle
            // 
            this.cbbContactTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbContactTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbContactTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbContactTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbContactTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbbContactTitle.FormattingEnabled = true;
            this.cbbContactTitle.Items.AddRange(new object[] {
            "MS",
            "MR"});
            this.cbbContactTitle.Location = new System.Drawing.Point(134, 70);
            this.cbbContactTitle.Name = "cbbContactTitle";
            this.cbbContactTitle.Size = new System.Drawing.Size(82, 24);
            this.cbbContactTitle.TabIndex = 83;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbxEmail.Location = new System.Drawing.Point(415, 115);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(282, 22);
            this.tbxEmail.TabIndex = 6;
            this.tbxEmail.Text = "example@team8b.com";
            this.tbxEmail.Click += new System.EventHandler(this.tbxEmail_Click);
            this.tbxEmail.TextChanged += new System.EventHandler(this.tbxEmail_TextChanged);
            this.tbxEmail.Enter += new System.EventHandler(this.tbxEmail_Click);
            // 
            // tbxCity
            // 
            this.tbxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCity.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbxCity.Location = new System.Drawing.Point(134, 256);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(180, 22);
            this.tbxCity.TabIndex = 8;
            this.tbxCity.Text = "eg. Team 8B";
            this.tbxCity.Click += new System.EventHandler(this.tbxCity_Click);
            this.tbxCity.TextChanged += new System.EventHandler(this.tbxCity_TextChanged);
            this.tbxCity.Enter += new System.EventHandler(this.tbxCity_Click);
            // 
            // tbxPostalCode
            // 
            this.tbxPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPostalCode.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbxPostalCode.Location = new System.Drawing.Point(517, 256);
            this.tbxPostalCode.Name = "tbxPostalCode";
            this.tbxPostalCode.Size = new System.Drawing.Size(180, 22);
            this.tbxPostalCode.TabIndex = 9;
            this.tbxPostalCode.Text = "123456";
            this.tbxPostalCode.Click += new System.EventHandler(this.tbxPostalCode_Click);
            this.tbxPostalCode.TextChanged += new System.EventHandler(this.tbxPostalCode_TextChanged);
            this.tbxPostalCode.Enter += new System.EventHandler(this.tbxPostalCode_Click);
            // 
            // tbxAddress
            // 
            this.tbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbxAddress.Location = new System.Drawing.Point(134, 161);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(563, 67);
            this.tbxAddress.TabIndex = 7;
            this.tbxAddress.Text = "#08-B Team 8B Street ";
            this.tbxAddress.Click += new System.EventHandler(this.tbxAddress_Click);
            this.tbxAddress.TextChanged += new System.EventHandler(this.tbxAddress_TextChanged);
            this.tbxAddress.Enter += new System.EventHandler(this.tbxAddress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 90;
            this.label1.Text = "City";
            // 
            // lblPlaceOfBirth
            // 
            this.lblPlaceOfBirth.AutoSize = true;
            this.lblPlaceOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaceOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceOfBirth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPlaceOfBirth.Location = new System.Drawing.Point(321, 31);
            this.lblPlaceOfBirth.Name = "lblPlaceOfBirth";
            this.lblPlaceOfBirth.Size = new System.Drawing.Size(88, 16);
            this.lblPlaceOfBirth.TabIndex = 91;
            this.lblPlaceOfBirth.Text = "Place Of Birth";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.BackColor = System.Drawing.Color.Transparent;
            this.lblPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPostalCode.Location = new System.Drawing.Point(412, 259);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(80, 16);
            this.lblPostalCode.TabIndex = 92;
            this.lblPostalCode.Text = "Postal code";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmail.Location = new System.Drawing.Point(314, 119);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(95, 16);
            this.lblEmail.TabIndex = 93;
            this.lblEmail.Text = "Email address";
            // 
            // tbxPhone
            // 
            this.tbxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhone.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbxPhone.Location = new System.Drawing.Point(134, 116);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(140, 22);
            this.tbxPhone.TabIndex = 5;
            this.tbxPhone.Text = "1234567";
            this.tbxPhone.Click += new System.EventHandler(this.tbxPhone_Click);
            this.tbxPhone.TextChanged += new System.EventHandler(this.tbxPhone_TextChanged);
            this.tbxPhone.Enter += new System.EventHandler(this.tbxPhone_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddress.Location = new System.Drawing.Point(16, 164);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(59, 16);
            this.lblAddress.TabIndex = 94;
            this.lblAddress.Text = "Address";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPhone.Location = new System.Drawing.Point(16, 120);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(47, 16);
            this.lblPhone.TabIndex = 95;
            this.lblPhone.Text = "Phone";
            // 
            // tbxMemberName
            // 
            this.tbxMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMemberName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbxMemberName.Location = new System.Drawing.Point(222, 70);
            this.tbxMemberName.Name = "tbxMemberName";
            this.tbxMemberName.Size = new System.Drawing.Size(475, 22);
            this.tbxMemberName.TabIndex = 4;
            this.tbxMemberName.Text = "eg. Team Eight B";
            this.tbxMemberName.Click += new System.EventHandler(this.tbxMemberName_Click);
            this.tbxMemberName.TextChanged += new System.EventHandler(this.tbxMemberName_TextChanged);
            this.tbxMemberName.Enter += new System.EventHandler(this.tbxMemberName_Click);
            // 
            // lvlMemberName
            // 
            this.lvlMemberName.AutoSize = true;
            this.lvlMemberName.BackColor = System.Drawing.Color.Transparent;
            this.lvlMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlMemberName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvlMemberName.Location = new System.Drawing.Point(16, 73);
            this.lvlMemberName.Name = "lvlMemberName";
            this.lvlMemberName.Size = new System.Drawing.Size(95, 16);
            this.lvlMemberName.TabIndex = 88;
            this.lvlMemberName.Text = "Member name";
            // 
            // tbxMemberID
            // 
            this.tbxMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMemberID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbxMemberID.Location = new System.Drawing.Point(134, 27);
            this.tbxMemberID.Name = "tbxMemberID";
            this.tbxMemberID.Size = new System.Drawing.Size(140, 22);
            this.tbxMemberID.TabIndex = 1;
            this.tbxMemberID.Text = "eg.5473";
            this.tbxMemberID.Click += new System.EventHandler(this.tbxMemberID_Click);
            this.tbxMemberID.TextChanged += new System.EventHandler(this.tbxMemberID_TextChanged);
            this.tbxMemberID.Enter += new System.EventHandler(this.tbxMemberID_Click);
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.BackColor = System.Drawing.Color.Transparent;
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMemberID.Location = new System.Drawing.Point(16, 31);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(74, 16);
            this.lblMemberID.TabIndex = 89;
            this.lblMemberID.Text = "Member ID";
            // 
            // frmAddNewMember
            // 
            this.AcceptButton = this.btnAddMember;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::Team08B_Library.Properties.Resources.Background_purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblBigTitle);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAddMember);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddNewMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberInfo_UpdateDetails";
            this.Load += new System.EventHandler(this.MemberInfo_UpdateDetails_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lblBigTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAddressValid;
        private System.Windows.Forms.Label lblPlaceOfBirthValid;
        private System.Windows.Forms.Label lblMemberNameValid;
        private System.Windows.Forms.Label lblPhoneValid;
        private System.Windows.Forms.Label lblEmailValid;
        private System.Windows.Forms.Label lblPostalCodeValid;
        private System.Windows.Forms.Label lblCityValid;
        private System.Windows.Forms.ComboBox cbbPlaceOfBirth;
        private System.Windows.Forms.ComboBox cbbContactTitle;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxPostalCode;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlaceOfBirth;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbxMemberName;
        private System.Windows.Forms.Label lvlMemberName;
        private System.Windows.Forms.TextBox tbxMemberID;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblIDValid;
    }
}