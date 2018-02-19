namespace Team08B_Library
{
    partial class frmBookInfo
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
            if (disposing && (components != null))
            {
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
            this.grpBookInfo = new System.Windows.Forms.GroupBox();
            this.txtNumberBorrow = new System.Windows.Forms.TextBox();
            this.lblNumberBorrow = new System.Windows.Forms.Label();
            this.txtBookType = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.txtTotalStock = new System.Windows.Forms.TextBox();
            this.lblBookType = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblTotalStock = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblBook = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslDelete = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnReportMenu = new System.Windows.Forms.Button();
            this.btnMemberInfoMenu = new System.Windows.Forms.Button();
            this.btnBookInfoMenu = new System.Windows.Forms.Button();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.btnBorrowMenu = new System.Windows.Forms.Button();
            this.btnAdminMenu = new System.Windows.Forms.Button();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnBorrowHistory = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblValid = new System.Windows.Forms.Label();
            this.lblAvailDate = new System.Windows.Forms.Label();
            this.txtAvailDate = new System.Windows.Forms.TextBox();
            this.grpBookInfo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.tlpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBookInfo
            // 
            this.grpBookInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(200)))));
            this.grpBookInfo.Controls.Add(this.txtAvailDate);
            this.grpBookInfo.Controls.Add(this.lblAvailDate);
            this.grpBookInfo.Controls.Add(this.txtNumberBorrow);
            this.grpBookInfo.Controls.Add(this.lblNumberBorrow);
            this.grpBookInfo.Controls.Add(this.txtBookType);
            this.grpBookInfo.Controls.Add(this.lblBookTitle);
            this.grpBookInfo.Controls.Add(this.txtBookTitle);
            this.grpBookInfo.Controls.Add(this.txtTotalStock);
            this.grpBookInfo.Controls.Add(this.lblBookType);
            this.grpBookInfo.Controls.Add(this.txtAuthor);
            this.grpBookInfo.Controls.Add(this.lblPublisher);
            this.grpBookInfo.Controls.Add(this.lblTotalStock);
            this.grpBookInfo.Controls.Add(this.txtPublisher);
            this.grpBookInfo.Controls.Add(this.lblAuthor);
            this.grpBookInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookInfo.ForeColor = System.Drawing.Color.White;
            this.grpBookInfo.Location = new System.Drawing.Point(44, 184);
            this.grpBookInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpBookInfo.Name = "grpBookInfo";
            this.grpBookInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpBookInfo.Size = new System.Drawing.Size(712, 225);
            this.grpBookInfo.TabIndex = 68;
            this.grpBookInfo.TabStop = false;
            this.grpBookInfo.Text = "Book Information";
            // 
            // txtNumberBorrow
            // 
            this.txtNumberBorrow.Location = new System.Drawing.Point(594, 143);
            this.txtNumberBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumberBorrow.Name = "txtNumberBorrow";
            this.txtNumberBorrow.ReadOnly = true;
            this.txtNumberBorrow.Size = new System.Drawing.Size(93, 23);
            this.txtNumberBorrow.TabIndex = 63;
            // 
            // lblNumberBorrow
            // 
            this.lblNumberBorrow.AutoSize = true;
            this.lblNumberBorrow.Location = new System.Drawing.Point(444, 146);
            this.lblNumberBorrow.Name = "lblNumberBorrow";
            this.lblNumberBorrow.Size = new System.Drawing.Size(122, 17);
            this.lblNumberBorrow.TabIndex = 62;
            this.lblNumberBorrow.Text = "Number Borrowed";
            // 
            // txtBookType
            // 
            this.txtBookType.Location = new System.Drawing.Point(529, 28);
            this.txtBookType.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookType.Name = "txtBookType";
            this.txtBookType.ReadOnly = true;
            this.txtBookType.Size = new System.Drawing.Size(158, 23);
            this.txtBookType.TabIndex = 61;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(11, 31);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(66, 17);
            this.lblBookTitle.TabIndex = 50;
            this.lblBookTitle.Text = "Book title";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(99, 31);
            this.txtBookTitle.Multiline = true;
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.ReadOnly = true;
            this.txtBookTitle.Size = new System.Drawing.Size(322, 109);
            this.txtBookTitle.TabIndex = 52;
            // 
            // txtTotalStock
            // 
            this.txtTotalStock.Location = new System.Drawing.Point(594, 89);
            this.txtTotalStock.Name = "txtTotalStock";
            this.txtTotalStock.ReadOnly = true;
            this.txtTotalStock.Size = new System.Drawing.Size(93, 23);
            this.txtTotalStock.TabIndex = 58;
            // 
            // lblBookType
            // 
            this.lblBookType.AutoSize = true;
            this.lblBookType.Location = new System.Drawing.Point(444, 31);
            this.lblBookType.Name = "lblBookType";
            this.lblBookType.Size = new System.Drawing.Size(71, 17);
            this.lblBookType.TabIndex = 57;
            this.lblBookType.Text = "Book type";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(99, 178);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(322, 23);
            this.txtAuthor.TabIndex = 59;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(11, 149);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(67, 17);
            this.lblPublisher.TabIndex = 56;
            this.lblPublisher.Text = "Publisher";
            // 
            // lblTotalStock
            // 
            this.lblTotalStock.AutoSize = true;
            this.lblTotalStock.Location = new System.Drawing.Point(444, 92);
            this.lblTotalStock.Name = "lblTotalStock";
            this.lblTotalStock.Size = new System.Drawing.Size(79, 17);
            this.lblTotalStock.TabIndex = 54;
            this.lblTotalStock.Text = "Total Stock";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(99, 146);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.ReadOnly = true;
            this.txtPublisher.Size = new System.Drawing.Size(322, 23);
            this.txtPublisher.TabIndex = 60;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(11, 178);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(50, 17);
            this.lblAuthor.TabIndex = 55;
            this.lblAuthor.Text = "Author";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(606, 414);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 30);
            this.btnUpdate.TabIndex = 66;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBook
            // 
            this.txtBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBook.Location = new System.Drawing.Point(165, 86);
            this.txtBook.Margin = new System.Windows.Forms.Padding(2);
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(204, 23);
            this.txtBook.TabIndex = 69;
            this.txtBook.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBook_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(382, 86);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 23);
            this.btnSearch.TabIndex = 70;
            this.btnSearch.Text = "...";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.BackColor = System.Drawing.Color.Transparent;
            this.lblBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.Location = new System.Drawing.Point(86, 89);
            this.lblBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(57, 17);
            this.lblBook.TabIndex = 71;
            this.lblBook.Text = "Book ID";
            this.lblBook.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmBookInfo_MouseMove);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(606, 150);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 30);
            this.btnAdd.TabIndex = 73;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslDelete});
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 74;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sslDelete
            // 
            this.sslDelete.Name = "sslDelete";
            this.sslDelete.Size = new System.Drawing.Size(0, 17);
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
            this.btnBookInfoMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBookInfoMenu.FlatAppearance.BorderSize = 0;
            this.btnBookInfoMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookInfoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookInfoMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBookInfoMenu.Location = new System.Drawing.Point(269, 3);
            this.btnBookInfoMenu.Name = "btnBookInfoMenu";
            this.btnBookInfoMenu.Size = new System.Drawing.Size(127, 52);
            this.btnBookInfoMenu.TabIndex = 78;
            this.btnBookInfoMenu.Text = "Book Information";
            this.btnBookInfoMenu.UseVisualStyleBackColor = false;
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
            // btnBorrowMenu
            // 
            this.btnBorrowMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(200)))));
            this.btnBorrowMenu.FlatAppearance.BorderSize = 0;
            this.btnBorrowMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBorrowMenu.Location = new System.Drawing.Point(3, 3);
            this.btnBorrowMenu.Name = "btnBorrowMenu";
            this.btnBorrowMenu.Size = new System.Drawing.Size(127, 52);
            this.btnBorrowMenu.TabIndex = 80;
            this.btnBorrowMenu.Text = "Borrow";
            this.btnBorrowMenu.UseVisualStyleBackColor = false;
            this.btnBorrowMenu.Click += new System.EventHandler(this.btnBorrowMenu_Click);
            this.btnBorrowMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmBookInfo_MouseMove);
            // 
            // btnAdminMenu
            // 
            this.btnAdminMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(200)))));
            this.btnAdminMenu.FlatAppearance.BorderSize = 0;
            this.btnAdminMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdminMenu.Location = new System.Drawing.Point(0, 0);
            this.btnAdminMenu.Name = "btnAdminMenu";
            this.btnAdminMenu.Size = new System.Drawing.Size(133, 58);
            this.btnAdminMenu.TabIndex = 81;
            this.btnAdminMenu.Text = "Hi Admin";
            this.btnAdminMenu.UseVisualStyleBackColor = false;
            this.btnAdminMenu.MouseEnter += new System.EventHandler(this.btnAdminMenu_MouseEnter);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.Transparent;
            this.pnlAdmin.Controls.Add(this.btnLogout);
            this.pnlAdmin.Controls.Add(this.btnExit);
            this.pnlAdmin.Location = new System.Drawing.Point(0, 58);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(133, 71);
            this.pnlAdmin.TabIndex = 82;
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
            // tlpMenu
            // 
            this.tlpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(200)))));
            this.tlpMenu.ColumnCount = 5;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMenu.Controls.Add(this.btnBorrowMenu, 0, 0);
            this.tlpMenu.Controls.Add(this.btnReturnMenu, 1, 0);
            this.tlpMenu.Controls.Add(this.btnReportMenu, 4, 0);
            this.tlpMenu.Controls.Add(this.btnMemberInfoMenu, 3, 0);
            this.tlpMenu.Controls.Add(this.btnBookInfoMenu, 2, 0);
            this.tlpMenu.Location = new System.Drawing.Point(132, 0);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 1;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenu.Size = new System.Drawing.Size(668, 58);
            this.tlpMenu.TabIndex = 84;
            this.tlpMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmBookInfo_MouseMove);
            // 
            // btnBorrowHistory
            // 
            this.btnBorrowHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnBorrowHistory.FlatAppearance.BorderSize = 0;
            this.btnBorrowHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowHistory.ForeColor = System.Drawing.Color.White;
            this.btnBorrowHistory.Location = new System.Drawing.Point(44, 414);
            this.btnBorrowHistory.Name = "btnBorrowHistory";
            this.btnBorrowHistory.Size = new System.Drawing.Size(150, 30);
            this.btnBorrowHistory.TabIndex = 85;
            this.btnBorrowHistory.Text = "Borrow History";
            this.btnBorrowHistory.UseVisualStyleBackColor = false;
            this.btnBorrowHistory.Click += new System.EventHandler(this.btnBorrowHistory_Click);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnGo.FlatAppearance.BorderSize = 0;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.Location = new System.Drawing.Point(165, 126);
            this.btnGo.Margin = new System.Windows.Forms.Padding(2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(150, 30);
            this.btnGo.TabIndex = 70;
            this.btnGo.Text = "Retrieve Book";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblValid
            // 
            this.lblValid.AutoSize = true;
            this.lblValid.BackColor = System.Drawing.Color.Transparent;
            this.lblValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValid.Location = new System.Drawing.Point(162, 111);
            this.lblValid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(57, 13);
            this.lblValid.TabIndex = 71;
            this.lblValid.Text = "Valid Entry";
            this.lblValid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmBookInfo_MouseMove);
            // 
            // lblAvailDate
            // 
            this.lblAvailDate.AutoSize = true;
            this.lblAvailDate.Location = new System.Drawing.Point(444, 178);
            this.lblAvailDate.Name = "lblAvailDate";
            this.lblAvailDate.Size = new System.Drawing.Size(99, 17);
            this.lblAvailDate.TabIndex = 62;
            this.lblAvailDate.Text = "Available Date";
            // 
            // txtAvailDate
            // 
            this.txtAvailDate.Location = new System.Drawing.Point(594, 175);
            this.txtAvailDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtAvailDate.Name = "txtAvailDate";
            this.txtAvailDate.ReadOnly = true;
            this.txtAvailDate.Size = new System.Drawing.Size(93, 23);
            this.txtAvailDate.TabIndex = 63;
            // 
            // frmBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Team08B_Library.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnBorrowHistory);
            this.Controls.Add(this.btnAdminMenu);
            this.Controls.Add(this.tlpMenu);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBook);
            this.Controls.Add(this.grpBookInfo);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblValid);
            this.Controls.Add(this.lblBook);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBookInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Information";
            this.Load += new System.EventHandler(this.frmBookInfo_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmBookInfo_MouseMove);
            this.grpBookInfo.ResumeLayout(false);
            this.grpBookInfo.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlAdmin.ResumeLayout(false);
            this.tlpMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBookInfo;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtTotalStock;
        private System.Windows.Forms.Label lblBookType;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblTotalStock;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtNumberBorrow;
        private System.Windows.Forms.Label lblNumberBorrow;
        private System.Windows.Forms.TextBox txtBookType;
        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslDelete;
        private System.Windows.Forms.Button btnReportMenu;
        private System.Windows.Forms.Button btnMemberInfoMenu;
        private System.Windows.Forms.Button btnBookInfoMenu;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.Button btnBorrowMenu;
        private System.Windows.Forms.Button btnAdminMenu;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private System.Windows.Forms.Button btnBorrowHistory;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblValid;
        private System.Windows.Forms.TextBox txtAvailDate;
        private System.Windows.Forms.Label lblAvailDate;
    }
}