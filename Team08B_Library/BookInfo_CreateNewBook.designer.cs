namespace Team08B_Library
{
    partial class frmAddNewBook
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hiGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBorrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.txtTotalStock = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblTotalStock = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblBookType = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.txtBID = new System.Windows.Forms.TextBox();
            this.lblBID = new System.Windows.Forms.Label();
            this.grpBookInfo = new System.Windows.Forms.GroupBox();
            this.cmbBookType = new System.Windows.Forms.ComboBox();
            this.sspAdd = new System.Windows.Forms.StatusStrip();
            this.sslAdd = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblErrorID = new System.Windows.Forms.Label();
            this.lblErrorTitle = new System.Windows.Forms.Label();
            this.lblErrorType = new System.Windows.Forms.Label();
            this.lblErrorPublisher = new System.Windows.Forms.Label();
            this.lblErrorAuthor = new System.Windows.Forms.Label();
            this.lblErrorStock = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpBookInfo.SuspendLayout();
            this.sspAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiGuestToolStripMenuItem,
            this.searchBorrowToolStripMenuItem,
            this.memberInformationToolStripMenuItem,
            this.bookInformationToolStripMenuItem,
            this.returnBookToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(998, 35);
            this.menuStrip1.TabIndex = 64;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hiGuestToolStripMenuItem
            // 
            this.hiGuestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem});
            this.hiGuestToolStripMenuItem.Name = "hiGuestToolStripMenuItem";
            this.hiGuestToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.hiGuestToolStripMenuItem.Text = "Hi, Guest";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(145, 30);
            this.logInToolStripMenuItem.Text = "Log in";
            // 
            // searchBorrowToolStripMenuItem
            // 
            this.searchBorrowToolStripMenuItem.Name = "searchBorrowToolStripMenuItem";
            this.searchBorrowToolStripMenuItem.Size = new System.Drawing.Size(143, 29);
            this.searchBorrowToolStripMenuItem.Text = "Search & Borrow";
            // 
            // memberInformationToolStripMenuItem
            // 
            this.memberInformationToolStripMenuItem.Name = "memberInformationToolStripMenuItem";
            this.memberInformationToolStripMenuItem.Size = new System.Drawing.Size(190, 29);
            this.memberInformationToolStripMenuItem.Text = "Member Information";
            // 
            // bookInformationToolStripMenuItem
            // 
            this.bookInformationToolStripMenuItem.Name = "bookInformationToolStripMenuItem";
            this.bookInformationToolStripMenuItem.Size = new System.Drawing.Size(164, 29);
            this.bookInformationToolStripMenuItem.Text = "Book Information";
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(122, 29);
            this.returnBookToolStripMenuItem.Text = "Return book";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.Location = new System.Drawing.Point(369, 451);
            this.btnAddNewBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(194, 35);
            this.btnAddNewBook.TabIndex = 63;
            this.btnAddNewBook.Text = "Add";
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTotalStock
            // 
            this.txtTotalStock.Location = new System.Drawing.Point(605, 260);
            this.txtTotalStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalStock.Name = "txtTotalStock";
            this.txtTotalStock.Size = new System.Drawing.Size(312, 26);
            this.txtTotalStock.TabIndex = 58;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(605, 157);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(312, 26);
            this.txtAuthor.TabIndex = 59;
            // 
            // lblTotalStock
            // 
            this.lblTotalStock.AutoSize = true;
            this.lblTotalStock.Location = new System.Drawing.Point(491, 264);
            this.lblTotalStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalStock.Name = "lblTotalStock";
            this.lblTotalStock.Size = new System.Drawing.Size(89, 20);
            this.lblTotalStock.TabIndex = 54;
            this.lblTotalStock.Text = "Total Stock";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(605, 82);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(312, 26);
            this.txtPublisher.TabIndex = 60;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(491, 163);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(57, 20);
            this.lblAuthor.TabIndex = 55;
            this.lblAuthor.Text = "Author";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(491, 88);
            this.lblPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(74, 20);
            this.lblPublisher.TabIndex = 56;
            this.lblPublisher.Text = "Publisher";
            // 
            // lblBookType
            // 
            this.lblBookType.AutoSize = true;
            this.lblBookType.Location = new System.Drawing.Point(16, 264);
            this.lblBookType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookType.Name = "lblBookType";
            this.lblBookType.Size = new System.Drawing.Size(80, 20);
            this.lblBookType.TabIndex = 57;
            this.lblBookType.Text = "Book type";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(130, 157);
            this.txtBookTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBookTitle.Multiline = true;
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBookTitle.Size = new System.Drawing.Size(312, 65);
            this.txtBookTitle.TabIndex = 52;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(16, 162);
            this.lblBookTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(75, 20);
            this.lblBookTitle.TabIndex = 50;
            this.lblBookTitle.Text = "Book title";
            // 
            // txtBID
            // 
            this.txtBID.Location = new System.Drawing.Point(130, 82);
            this.txtBID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBID.MaxLength = 6;
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(312, 26);
            this.txtBID.TabIndex = 53;
            this.txtBID.TextChanged += new System.EventHandler(this.txtBID_TextChanged);
            this.txtBID.Leave += new System.EventHandler(this.txtBID_Leave);
            // 
            // lblBID
            // 
            this.lblBID.AutoSize = true;
            this.lblBID.Location = new System.Drawing.Point(16, 88);
            this.lblBID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBID.Name = "lblBID";
            this.lblBID.Size = new System.Drawing.Size(67, 20);
            this.lblBID.TabIndex = 51;
            this.lblBID.Text = "Book ID";
            // 
            // grpBookInfo
            // 
            this.grpBookInfo.Controls.Add(this.lblErrorStock);
            this.grpBookInfo.Controls.Add(this.lblErrorAuthor);
            this.grpBookInfo.Controls.Add(this.lblErrorPublisher);
            this.grpBookInfo.Controls.Add(this.lblErrorType);
            this.grpBookInfo.Controls.Add(this.lblErrorTitle);
            this.grpBookInfo.Controls.Add(this.lblErrorID);
            this.grpBookInfo.Controls.Add(this.cmbBookType);
            this.grpBookInfo.Controls.Add(this.lblBID);
            this.grpBookInfo.Controls.Add(this.txtBID);
            this.grpBookInfo.Controls.Add(this.lblBookTitle);
            this.grpBookInfo.Controls.Add(this.txtBookTitle);
            this.grpBookInfo.Controls.Add(this.txtTotalStock);
            this.grpBookInfo.Controls.Add(this.lblBookType);
            this.grpBookInfo.Controls.Add(this.txtAuthor);
            this.grpBookInfo.Controls.Add(this.lblPublisher);
            this.grpBookInfo.Controls.Add(this.lblTotalStock);
            this.grpBookInfo.Controls.Add(this.txtPublisher);
            this.grpBookInfo.Controls.Add(this.lblAuthor);
            this.grpBookInfo.Location = new System.Drawing.Point(22, 82);
            this.grpBookInfo.Name = "grpBookInfo";
            this.grpBookInfo.Size = new System.Drawing.Size(940, 350);
            this.grpBookInfo.TabIndex = 65;
            this.grpBookInfo.TabStop = false;
            this.grpBookInfo.Text = "Book Information";
            // 
            // cmbBookType
            // 
            this.cmbBookType.FormattingEnabled = true;
            this.cmbBookType.Items.AddRange(new object[] {
            "Action",
            "Sci-fi",
            "Adventure",
            "Comedy",
            "Drama",
            "Animated"});
            this.cmbBookType.Location = new System.Drawing.Point(130, 261);
            this.cmbBookType.Name = "cmbBookType";
            this.cmbBookType.Size = new System.Drawing.Size(312, 28);
            this.cmbBookType.TabIndex = 61;
            // 
            // sspAdd
            // 
            this.sspAdd.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.sspAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslAdd});
            this.sspAdd.Location = new System.Drawing.Point(0, 601);
            this.sspAdd.Name = "sspAdd";
            this.sspAdd.Size = new System.Drawing.Size(998, 22);
            this.sspAdd.TabIndex = 66;
            this.sspAdd.Text = "statusStrip1";
            // 
            // sslAdd
            // 
            this.sslAdd.Name = "sslAdd";
            this.sslAdd.Size = new System.Drawing.Size(0, 25);
            // 
            // lblErrorID
            // 
            this.lblErrorID.AutoSize = true;
            this.lblErrorID.Location = new System.Drawing.Point(131, 120);
            this.lblErrorID.Name = "lblErrorID";
            this.lblErrorID.Size = new System.Drawing.Size(0, 20);
            this.lblErrorID.TabIndex = 62;
            // 
            // lblErrorTitle
            // 
            this.lblErrorTitle.AutoSize = true;
            this.lblErrorTitle.Location = new System.Drawing.Point(131, 227);
            this.lblErrorTitle.Name = "lblErrorTitle";
            this.lblErrorTitle.Size = new System.Drawing.Size(0, 20);
            this.lblErrorTitle.TabIndex = 63;
            // 
            // lblErrorType
            // 
            this.lblErrorType.AutoSize = true;
            this.lblErrorType.Location = new System.Drawing.Point(131, 302);
            this.lblErrorType.Name = "lblErrorType";
            this.lblErrorType.Size = new System.Drawing.Size(0, 20);
            this.lblErrorType.TabIndex = 64;
            // 
            // lblErrorPublisher
            // 
            this.lblErrorPublisher.AutoSize = true;
            this.lblErrorPublisher.Location = new System.Drawing.Point(610, 120);
            this.lblErrorPublisher.Name = "lblErrorPublisher";
            this.lblErrorPublisher.Size = new System.Drawing.Size(0, 20);
            this.lblErrorPublisher.TabIndex = 65;
            // 
            // lblErrorAuthor
            // 
            this.lblErrorAuthor.AutoSize = true;
            this.lblErrorAuthor.Location = new System.Drawing.Point(610, 202);
            this.lblErrorAuthor.Name = "lblErrorAuthor";
            this.lblErrorAuthor.Size = new System.Drawing.Size(0, 20);
            this.lblErrorAuthor.TabIndex = 66;
            // 
            // lblErrorStock
            // 
            this.lblErrorStock.AutoSize = true;
            this.lblErrorStock.Location = new System.Drawing.Point(582, 302);
            this.lblErrorStock.Name = "lblErrorStock";
            this.lblErrorStock.Size = new System.Drawing.Size(17, 20);
            this.lblErrorStock.TabIndex = 67;
            this.lblErrorStock.Text = "c";
            // 
            // frmAddNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 623);
            this.Controls.Add(this.sspAdd);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAddNewBook);
            this.Controls.Add(this.grpBookInfo);
            this.Name = "frmAddNewBook";
            this.Text = "BookInfo_AddNewBook";
            this.Load += new System.EventHandler(this.frmAddNewBook_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBookInfo.ResumeLayout(false);
            this.grpBookInfo.PerformLayout();
            this.sspAdd.ResumeLayout(false);
            this.sspAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hiGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBorrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.TextBox txtTotalStock;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblTotalStock;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblBookType;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox txtBID;
        private System.Windows.Forms.Label lblBID;
        private System.Windows.Forms.GroupBox grpBookInfo;
        private System.Windows.Forms.StatusStrip sspAdd;
        private System.Windows.Forms.ToolStripStatusLabel sslAdd;
        private System.Windows.Forms.ComboBox cmbBookType;
        private System.Windows.Forms.Label lblErrorStock;
        private System.Windows.Forms.Label lblErrorAuthor;
        private System.Windows.Forms.Label lblErrorPublisher;
        private System.Windows.Forms.Label lblErrorType;
        private System.Windows.Forms.Label lblErrorTitle;
        private System.Windows.Forms.Label lblErrorID;
    }
}