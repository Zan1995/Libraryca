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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslDelete = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnGo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReportMenu = new System.Windows.Forms.Button();
            this.btnMemberInfoMenu = new System.Windows.Forms.Button();
            this.btnBookInfoMenu = new System.Windows.Forms.Button();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.btnBorrowMenu = new System.Windows.Forms.Button();
            this.btnAdminMenu = new System.Windows.Forms.Button();
            this.grpBookInfo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBookInfo
            // 
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
            this.grpBookInfo.Location = new System.Drawing.Point(72, 155);
            this.grpBookInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBookInfo.Name = "grpBookInfo";
            this.grpBookInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBookInfo.Size = new System.Drawing.Size(668, 196);
            this.grpBookInfo.TabIndex = 68;
            this.grpBookInfo.TabStop = false;
            this.grpBookInfo.Text = "Book Information";
            this.grpBookInfo.Enter += new System.EventHandler(this.grpBookInfo_Enter);
            // 
            // txtNumberBorrow
            // 
            this.txtNumberBorrow.Location = new System.Drawing.Point(109, 142);
            this.txtNumberBorrow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumberBorrow.Name = "txtNumberBorrow";
            this.txtNumberBorrow.ReadOnly = true;
            this.txtNumberBorrow.Size = new System.Drawing.Size(209, 20);
            this.txtNumberBorrow.TabIndex = 63;
            // 
            // lblNumberBorrow
            // 
            this.lblNumberBorrow.AutoSize = true;
            this.lblNumberBorrow.Location = new System.Drawing.Point(12, 142);
            this.lblNumberBorrow.Name = "lblNumberBorrow";
            this.lblNumberBorrow.Size = new System.Drawing.Size(92, 13);
            this.lblNumberBorrow.TabIndex = 62;
            this.lblNumberBorrow.Text = "Number Borrowed";
            // 
            // txtBookType
            // 
            this.txtBookType.Location = new System.Drawing.Point(109, 103);
            this.txtBookType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBookType.Name = "txtBookType";
            this.txtBookType.ReadOnly = true;
            this.txtBookType.Size = new System.Drawing.Size(209, 20);
            this.txtBookType.TabIndex = 61;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(11, 71);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(51, 13);
            this.lblBookTitle.TabIndex = 50;
            this.lblBookTitle.Text = "Book title";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(109, 67);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.ReadOnly = true;
            this.txtBookTitle.Size = new System.Drawing.Size(209, 20);
            this.txtBookTitle.TabIndex = 52;
            this.txtBookTitle.TextChanged += new System.EventHandler(this.txtBookTitle_TextChanged);
            // 
            // txtTotalStock
            // 
            this.txtTotalStock.Location = new System.Drawing.Point(436, 142);
            this.txtTotalStock.Name = "txtTotalStock";
            this.txtTotalStock.ReadOnly = true;
            this.txtTotalStock.Size = new System.Drawing.Size(209, 20);
            this.txtTotalStock.TabIndex = 58;
            // 
            // lblBookType
            // 
            this.lblBookType.AutoSize = true;
            this.lblBookType.Location = new System.Drawing.Point(11, 103);
            this.lblBookType.Name = "lblBookType";
            this.lblBookType.Size = new System.Drawing.Size(55, 13);
            this.lblBookType.TabIndex = 57;
            this.lblBookType.Text = "Book type";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(436, 101);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(209, 20);
            this.txtAuthor.TabIndex = 59;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(360, 71);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(50, 13);
            this.lblPublisher.TabIndex = 56;
            this.lblPublisher.Text = "Publisher";
            // 
            // lblTotalStock
            // 
            this.lblTotalStock.AutoSize = true;
            this.lblTotalStock.Location = new System.Drawing.Point(360, 146);
            this.lblTotalStock.Name = "lblTotalStock";
            this.lblTotalStock.Size = new System.Drawing.Size(62, 13);
            this.lblTotalStock.TabIndex = 54;
            this.lblTotalStock.Text = "Total Stock";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(436, 67);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.ReadOnly = true;
            this.txtPublisher.Size = new System.Drawing.Size(209, 20);
            this.txtPublisher.TabIndex = 60;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(360, 106);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 55;
            this.lblAuthor.Text = "Author";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(109, 396);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 23);
            this.btnUpdate.TabIndex = 66;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBook
            // 
            this.txtBook.Location = new System.Drawing.Point(182, 112);
            this.txtBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(154, 20);
            this.txtBook.TabIndex = 69;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(413, 109);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 23);
            this.btnSearch.TabIndex = 70;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(86, 112);
            this.lblBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(46, 13);
            this.lblBook.TabIndex = 71;
            this.lblBook.Text = "Book ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(341, 396);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 23);
            this.btnDelete.TabIndex = 72;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(531, 396);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 23);
            this.btnAdd.TabIndex = 73;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
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
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(305, 136);
            this.btnGo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(29, 23);
            this.btnGo.TabIndex = 75;
            this.btnGo.Text = "go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Location = new System.Drawing.Point(7, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 71);
            this.panel2.TabIndex = 82;
            this.panel2.Visible = false;
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
            this.btnLogout.Size = new System.Drawing.Size(139, 35);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Visible = false;
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
            this.btnExit.Size = new System.Drawing.Size(139, 35);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            // 
            // btnReportMenu
            // 
            this.btnReportMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(200)))));
            this.btnReportMenu.FlatAppearance.BorderSize = 0;
            this.btnReportMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReportMenu.Location = new System.Drawing.Point(669, 0);
            this.btnReportMenu.Name = "btnReportMenu";
            this.btnReportMenu.Size = new System.Drawing.Size(134, 58);
            this.btnReportMenu.TabIndex = 76;
            this.btnReportMenu.Text = "Reports";
            this.btnReportMenu.UseVisualStyleBackColor = false;
            // 
            // btnMemberInfoMenu
            // 
            this.btnMemberInfoMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(200)))));
            this.btnMemberInfoMenu.FlatAppearance.BorderSize = 0;
            this.btnMemberInfoMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberInfoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberInfoMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMemberInfoMenu.Location = new System.Drawing.Point(535, 0);
            this.btnMemberInfoMenu.Name = "btnMemberInfoMenu";
            this.btnMemberInfoMenu.Size = new System.Drawing.Size(134, 58);
            this.btnMemberInfoMenu.TabIndex = 77;
            this.btnMemberInfoMenu.Text = "Member Information";
            this.btnMemberInfoMenu.UseVisualStyleBackColor = false;
            // 
            // btnBookInfoMenu
            // 
            this.btnBookInfoMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBookInfoMenu.FlatAppearance.BorderSize = 0;
            this.btnBookInfoMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookInfoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookInfoMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBookInfoMenu.Location = new System.Drawing.Point(401, 0);
            this.btnBookInfoMenu.Name = "btnBookInfoMenu";
            this.btnBookInfoMenu.Size = new System.Drawing.Size(134, 58);
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
            this.btnReturnMenu.Location = new System.Drawing.Point(267, 0);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(134, 58);
            this.btnReturnMenu.TabIndex = 79;
            this.btnReturnMenu.Text = "Return";
            this.btnReturnMenu.UseVisualStyleBackColor = false;
            // 
            // btnBorrowMenu
            // 
            this.btnBorrowMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(200)))));
            this.btnBorrowMenu.FlatAppearance.BorderSize = 0;
            this.btnBorrowMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBorrowMenu.Location = new System.Drawing.Point(133, 0);
            this.btnBorrowMenu.Name = "btnBorrowMenu";
            this.btnBorrowMenu.Size = new System.Drawing.Size(134, 58);
            this.btnBorrowMenu.TabIndex = 80;
            this.btnBorrowMenu.Text = "Borrow";
            this.btnBorrowMenu.UseVisualStyleBackColor = false;
            // 
            // btnAdminMenu
            // 
            this.btnAdminMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(200)))));
            this.btnAdminMenu.FlatAppearance.BorderSize = 0;
            this.btnAdminMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdminMenu.Location = new System.Drawing.Point(-1, 0);
            this.btnAdminMenu.Name = "btnAdminMenu";
            this.btnAdminMenu.Size = new System.Drawing.Size(134, 58);
            this.btnAdminMenu.TabIndex = 81;
            this.btnAdminMenu.Text = "Hi Admin";
            this.btnAdminMenu.UseVisualStyleBackColor = false;
            // 
            // frmBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnReportMenu);
            this.Controls.Add(this.btnMemberInfoMenu);
            this.Controls.Add(this.btnBookInfoMenu);
            this.Controls.Add(this.btnReturnMenu);
            this.Controls.Add(this.btnBorrowMenu);
            this.Controls.Add(this.btnAdminMenu);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBook);
            this.Controls.Add(this.grpBookInfo);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBookInfo";
            this.Text = "Book Information";
            this.grpBookInfo.ResumeLayout(false);
            this.grpBookInfo.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslDelete;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReportMenu;
        private System.Windows.Forms.Button btnMemberInfoMenu;
        private System.Windows.Forms.Button btnBookInfoMenu;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.Button btnBorrowMenu;
        private System.Windows.Forms.Button btnAdminMenu;
    }
}