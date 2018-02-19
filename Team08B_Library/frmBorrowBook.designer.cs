namespace Team08B_Library
{
    partial class frmBorrowBook
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
            this.components = new System.ComponentModel.Container();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblDD = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblMemberInfo = new System.Windows.Forms.Label();
            this.txtMemberInfo = new System.Windows.Forms.TextBox();
            this.lblBook = new System.Windows.Forms.Label();
            this.txtBookInfo = new System.Windows.Forms.TextBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdminMenu = new System.Windows.Forms.Button();
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnBorrowMenu = new System.Windows.Forms.Button();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.btnReportMenu = new System.Windows.Forms.Button();
            this.btnMemberInfoMenu = new System.Windows.Forms.Button();
            this.btnBookInfoMenu = new System.Windows.Forms.Button();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.cms.SuspendLayout();
            this.tlpMenu.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(39, 133);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(56, 16);
            this.lblBookID.TabIndex = 0;
            this.lblBookID.Text = "Book ID";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(39, 97);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(74, 16);
            this.lblMemberID.TabIndex = 1;
            this.lblMemberID.Text = "Member ID";
            // 
            // txtBookID
            // 
            this.txtBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.Location = new System.Drawing.Point(132, 130);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(173, 22);
            this.txtBookID.TabIndex = 1;
            this.txtBookID.TextChanged += new System.EventHandler(this.txtChanged);
            this.txtBookID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookID_KeyDown);
            this.txtBookID.Leave += new System.EventHandler(this.txtBookID_Leave);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberID.Location = new System.Drawing.Point(132, 94);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(173, 22);
            this.txtMemberID.TabIndex = 0;
            this.txtMemberID.TextChanged += new System.EventHandler(this.txtChanged);
            this.txtMemberID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMemberID_KeyDown);
            this.txtMemberID.Leave += new System.EventHandler(this.txtMemberID_Leave);
            this.txtMemberID.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBorrowMenu_MouseMove);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBook.Location = new System.Drawing.Point(311, 130);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(26, 21);
            this.btnSearchBook.TabIndex = 10;
            this.btnSearchBook.TabStop = false;
            this.btnSearchBook.Text = "...";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMember.Location = new System.Drawing.Point(311, 94);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(26, 21);
            this.btnSearchMember.TabIndex = 10;
            this.btnSearchMember.TabStop = false;
            this.btnSearchMember.Text = "...";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.Location = new System.Drawing.Point(39, 167);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(72, 16);
            this.lblIssueDate.TabIndex = 1;
            this.lblIssueDate.Text = "Issue Date";
            // 
            // lblDD
            // 
            this.lblDD.AutoSize = true;
            this.lblDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDD.Location = new System.Drawing.Point(39, 199);
            this.lblDD.Name = "lblDD";
            this.lblDD.Size = new System.Drawing.Size(65, 16);
            this.lblDD.TabIndex = 1;
            this.lblDD.Text = "Due Date";
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDate.Location = new System.Drawing.Point(132, 162);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(205, 22);
            this.dtpIssueDate.TabIndex = 2;
            this.dtpIssueDate.ValueChanged += new System.EventHandler(this.dtpIssueDate_ValueChanged);
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBorrow.Location = new System.Drawing.Point(201, 374);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(150, 30);
            this.btnBorrow.TabIndex = 5;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(39, 17);
            this.tssStatus.Text = "Status";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.Location = new System.Drawing.Point(39, 225);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(63, 16);
            this.lblRemarks.TabIndex = 1;
            this.lblRemarks.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(42, 250);
            this.txtRemarks.MaxLength = 255;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(309, 98);
            this.txtRemarks.TabIndex = 4;
            // 
            // lblMemberInfo
            // 
            this.lblMemberInfo.AutoSize = true;
            this.lblMemberInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberInfo.Location = new System.Drawing.Point(436, 94);
            this.lblMemberInfo.Name = "lblMemberInfo";
            this.lblMemberInfo.Size = new System.Drawing.Size(126, 16);
            this.lblMemberInfo.TabIndex = 1;
            this.lblMemberInfo.Text = "Member Information";
            // 
            // txtMemberInfo
            // 
            this.txtMemberInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberInfo.Location = new System.Drawing.Point(436, 115);
            this.txtMemberInfo.Multiline = true;
            this.txtMemberInfo.Name = "txtMemberInfo";
            this.txtMemberInfo.Size = new System.Drawing.Size(320, 77);
            this.txtMemberInfo.TabIndex = 11;
            this.txtMemberInfo.TabStop = false;
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.Location = new System.Drawing.Point(436, 225);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(108, 16);
            this.lblBook.TabIndex = 1;
            this.lblBook.Text = "Book Information";
            // 
            // txtBookInfo
            // 
            this.txtBookInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookInfo.Location = new System.Drawing.Point(436, 250);
            this.txtBookInfo.Multiline = true;
            this.txtBookInfo.Name = "txtBookInfo";
            this.txtBookInfo.Size = new System.Drawing.Size(320, 77);
            this.txtBookInfo.TabIndex = 11;
            this.txtBookInfo.TabStop = false;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(134, 199);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(65, 16);
            this.lblDueDate.TabIndex = 12;
            this.lblDueDate.Text = "Due Date";
            // 
            // cms
            // 
            this.cms.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.cms.Name = "contextMenuStrip2";
            this.cms.Size = new System.Drawing.Size(118, 48);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // btnAdminMenu
            // 
            this.btnAdminMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(200)))));
            this.btnAdminMenu.FlatAppearance.BorderSize = 0;
            this.btnAdminMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdminMenu.Location = new System.Drawing.Point(0, 1);
            this.btnAdminMenu.Name = "btnAdminMenu";
            this.btnAdminMenu.Size = new System.Drawing.Size(133, 58);
            this.btnAdminMenu.TabIndex = 85;
            this.btnAdminMenu.Text = "Hi Admin";
            this.btnAdminMenu.UseVisualStyleBackColor = false;
            this.btnAdminMenu.MouseEnter += new System.EventHandler(this.btnAdminMenu_MouseEnter);
            // 
            // tlpMenu
            // 
            this.tlpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(200)))));
            this.tlpMenu.ColumnCount = 5;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMenu.Controls.Add(this.btnBorrowMenu, 0, 0);
            this.tlpMenu.Controls.Add(this.btnReturnMenu, 1, 0);
            this.tlpMenu.Controls.Add(this.btnReportMenu, 4, 0);
            this.tlpMenu.Controls.Add(this.btnMemberInfoMenu, 3, 0);
            this.tlpMenu.Controls.Add(this.btnBookInfoMenu, 2, 0);
            this.tlpMenu.Location = new System.Drawing.Point(132, 1);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 1;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenu.Size = new System.Drawing.Size(668, 58);
            this.tlpMenu.TabIndex = 87;
            this.tlpMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBorrowMenu_MouseMove);
            // 
            // btnBorrowMenu
            // 
            this.btnBorrowMenu.BackColor = System.Drawing.Color.White;
            this.btnBorrowMenu.FlatAppearance.BorderSize = 0;
            this.btnBorrowMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowMenu.ForeColor = System.Drawing.Color.Black;
            this.btnBorrowMenu.Location = new System.Drawing.Point(3, 3);
            this.btnBorrowMenu.Name = "btnBorrowMenu";
            this.btnBorrowMenu.Size = new System.Drawing.Size(127, 52);
            this.btnBorrowMenu.TabIndex = 80;
            this.btnBorrowMenu.Text = "Borrow";
            this.btnBorrowMenu.UseVisualStyleBackColor = false;
            this.btnBorrowMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBorrowMenu_MouseMove);
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(200)))));
            this.btnReturnMenu.FlatAppearance.BorderSize = 0;
            this.btnReturnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturnMenu.Location = new System.Drawing.Point(136, 3);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(127, 52);
            this.btnReturnMenu.TabIndex = 79;
            this.btnReturnMenu.Text = "Return";
            this.btnReturnMenu.UseVisualStyleBackColor = false;
            this.btnReturnMenu.Click += new System.EventHandler(this.btnReturnMenu_Click);
            // 
            // btnReportMenu
            // 
            this.btnReportMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(200)))));
            this.btnReportMenu.FlatAppearance.BorderSize = 0;
            this.btnReportMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReportMenu.Location = new System.Drawing.Point(535, 3);
            this.btnReportMenu.Name = "btnReportMenu";
            this.btnReportMenu.Size = new System.Drawing.Size(130, 52);
            this.btnReportMenu.TabIndex = 76;
            this.btnReportMenu.Text = "Reports";
            this.btnReportMenu.UseVisualStyleBackColor = false;
            this.btnReportMenu.Click += new System.EventHandler(this.btnReportMenu_Click);
            // 
            // btnMemberInfoMenu
            // 
            this.btnMemberInfoMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(200)))));
            this.btnMemberInfoMenu.FlatAppearance.BorderSize = 0;
            this.btnMemberInfoMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberInfoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberInfoMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMemberInfoMenu.Location = new System.Drawing.Point(402, 3);
            this.btnMemberInfoMenu.Name = "btnMemberInfoMenu";
            this.btnMemberInfoMenu.Size = new System.Drawing.Size(127, 52);
            this.btnMemberInfoMenu.TabIndex = 77;
            this.btnMemberInfoMenu.Text = "Member Information";
            this.btnMemberInfoMenu.UseVisualStyleBackColor = false;
            this.btnMemberInfoMenu.Click += new System.EventHandler(this.btnMemberInfoMenu_Click);
            // 
            // btnBookInfoMenu
            // 
            this.btnBookInfoMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(200)))));
            this.btnBookInfoMenu.FlatAppearance.BorderSize = 0;
            this.btnBookInfoMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookInfoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookInfoMenu.ForeColor = System.Drawing.Color.White;
            this.btnBookInfoMenu.Location = new System.Drawing.Point(269, 3);
            this.btnBookInfoMenu.Name = "btnBookInfoMenu";
            this.btnBookInfoMenu.Size = new System.Drawing.Size(127, 52);
            this.btnBookInfoMenu.TabIndex = 78;
            this.btnBookInfoMenu.Text = "Book Information";
            this.btnBookInfoMenu.UseVisualStyleBackColor = false;
            this.btnBookInfoMenu.Click += new System.EventHandler(this.btnBookInfoMenu_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.Transparent;
            this.pnlAdmin.Controls.Add(this.btnLogout);
            this.pnlAdmin.Controls.Add(this.btnExit);
            this.pnlAdmin.Location = new System.Drawing.Point(0, 59);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(133, 71);
            this.pnlAdmin.TabIndex = 86;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(133, 35);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(0, 36);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 35);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmBorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Team08B_Library.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnAdminMenu);
            this.Controls.Add(this.tlpMenu);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.txtBookInfo);
            this.Controls.Add(this.txtMemberInfo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.btnSearchMember);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblDD);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.lblMemberInfo);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.lblBookID);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBorrowBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow Book";
            this.Load += new System.EventHandler(this.frmBorrowBook_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBorrowMenu_MouseMove);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cms.ResumeLayout(false);
            this.tlpMenu.ResumeLayout(false);
            this.pnlAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblDD;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblMemberInfo;
        private System.Windows.Forms.TextBox txtMemberInfo;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.TextBox txtBookInfo;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnAdminMenu;
        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private System.Windows.Forms.Button btnBorrowMenu;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.Button btnReportMenu;
        private System.Windows.Forms.Button btnMemberInfoMenu;
        private System.Windows.Forms.Button btnBookInfoMenu;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
    }
}

