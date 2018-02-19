namespace Team08B_Library
{
    partial class frmReturn
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rbBookID = new System.Windows.Forms.RadioButton();
            this.rbMemberID = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tssReturn = new System.Windows.Forms.StatusStrip();
            this.StatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.mtxtID = new System.Windows.Forms.MaskedTextBox();
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.txtMemberInfo = new System.Windows.Forms.TextBox();
            this.txtBookInfo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdminMenu = new System.Windows.Forms.Button();
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnBookInfoMenu = new System.Windows.Forms.Button();
            this.btnBorrowMenu = new System.Windows.Forms.Button();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.btnReportMenu = new System.Windows.Forms.Button();
            this.btnMemberInfoMenu = new System.Windows.Forms.Button();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tssReturn.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.tlpMenu.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(606, 437);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 30);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Transaction Details:";
            // 
            // rbBookID
            // 
            this.rbBookID.AutoSize = true;
            this.rbBookID.Location = new System.Drawing.Point(235, 16);
            this.rbBookID.Margin = new System.Windows.Forms.Padding(2);
            this.rbBookID.Name = "rbBookID";
            this.rbBookID.Size = new System.Drawing.Size(71, 21);
            this.rbBookID.TabIndex = 26;
            this.rbBookID.TabStop = true;
            this.rbBookID.Text = "BookID";
            this.rbBookID.UseVisualStyleBackColor = true;
            this.rbBookID.CheckedChanged += new System.EventHandler(this.rbBookID_CheckedChanged);
            // 
            // rbMemberID
            // 
            this.rbMemberID.AutoSize = true;
            this.rbMemberID.Location = new System.Drawing.Point(92, 16);
            this.rbMemberID.Margin = new System.Windows.Forms.Padding(2);
            this.rbMemberID.Name = "rbMemberID";
            this.rbMemberID.Size = new System.Drawing.Size(90, 21);
            this.rbMemberID.TabIndex = 27;
            this.rbMemberID.TabStop = true;
            this.rbMemberID.Text = "MemberID";
            this.rbMemberID.UseVisualStyleBackColor = true;
            this.rbMemberID.CheckedChanged += new System.EventHandler(this.rbMemberID_CheckedChanged);
            this.rbMemberID.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmReturn_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "ID Type";
            // 
            // tssReturn
            // 
            this.tssReturn.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tssReturn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStrip});
            this.tssReturn.Location = new System.Drawing.Point(0, 478);
            this.tssReturn.Name = "tssReturn";
            this.tssReturn.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.tssReturn.Size = new System.Drawing.Size(800, 22);
            this.tssReturn.TabIndex = 7;
            this.tssReturn.Text = "statusStrip1";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(39, 17);
            this.StatusStrip.Text = "Status";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(337, 18);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(64, 17);
            this.lblID.TabIndex = 30;
            this.lblID.Text = "Key in ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.rbMemberID);
            this.panel1.Controls.Add(this.mtxtID);
            this.panel1.Controls.Add(this.rbBookID);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(34, 79);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 51);
            this.panel1.TabIndex = 31;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmReturn_MouseMove);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Location = new System.Drawing.Point(521, 14);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(34, 25);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // mtxtID
            // 
            this.mtxtID.Location = new System.Drawing.Point(414, 15);
            this.mtxtID.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtID.Mask = "0000";
            this.mtxtID.Name = "mtxtID";
            this.mtxtID.PromptChar = ' ';
            this.mtxtID.Size = new System.Drawing.Size(103, 23);
            this.mtxtID.TabIndex = 32;
            this.mtxtID.Click += new System.EventHandler(this.mtxtID_Click);
            this.mtxtID.TextChanged += new System.EventHandler(this.mtxtID_TextChanged);
            this.mtxtID.Enter += new System.EventHandler(this.mtxtID_Enter);
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Location = new System.Drawing.Point(34, 151);
            this.dgvTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.ReadOnly = true;
            this.dgvTransaction.RowTemplate.Height = 24;
            this.dgvTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransaction.Size = new System.Drawing.Size(722, 132);
            this.dgvTransaction.TabIndex = 32;
            this.dgvTransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaction_CellContentClick);
            this.dgvTransaction.SelectionChanged += new System.EventHandler(this.dgvTransaction_SelectionChanged);
            this.dgvTransaction.Click += new System.EventHandler(this.dgvTransaction_Click);
            // 
            // txtMemberInfo
            // 
            this.txtMemberInfo.BackColor = System.Drawing.Color.White;
            this.txtMemberInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemberInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberInfo.ForeColor = System.Drawing.Color.Black;
            this.txtMemberInfo.Location = new System.Drawing.Point(431, 292);
            this.txtMemberInfo.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberInfo.Multiline = true;
            this.txtMemberInfo.Name = "txtMemberInfo";
            this.txtMemberInfo.Size = new System.Drawing.Size(285, 132);
            this.txtMemberInfo.TabIndex = 33;
            // 
            // txtBookInfo
            // 
            this.txtBookInfo.BackColor = System.Drawing.Color.White;
            this.txtBookInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookInfo.ForeColor = System.Drawing.Color.Black;
            this.txtBookInfo.Location = new System.Drawing.Point(83, 292);
            this.txtBookInfo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookInfo.Multiline = true;
            this.txtBookInfo.Name = "txtBookInfo";
            this.txtBookInfo.Size = new System.Drawing.Size(285, 132);
            this.txtBookInfo.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(409, 439);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 23);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 439);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Return Date:";
            // 
            // btnAdminMenu
            // 
            this.btnAdminMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(200)))));
            this.btnAdminMenu.FlatAppearance.BorderSize = 0;
            this.btnAdminMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdminMenu.Location = new System.Drawing.Point(0, -1);
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
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMenu.Controls.Add(this.btnBookInfoMenu, 2, 0);
            this.tlpMenu.Controls.Add(this.btnBorrowMenu, 0, 0);
            this.tlpMenu.Controls.Add(this.btnReturnMenu, 1, 0);
            this.tlpMenu.Controls.Add(this.btnReportMenu, 4, 0);
            this.tlpMenu.Controls.Add(this.btnMemberInfoMenu, 3, 0);
            this.tlpMenu.Location = new System.Drawing.Point(126, -1);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 1;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenu.Size = new System.Drawing.Size(674, 58);
            this.tlpMenu.TabIndex = 87;
            this.tlpMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmReturn_MouseMove);
            // 
            // btnBookInfoMenu
            // 
            this.btnBookInfoMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(200)))));
            this.btnBookInfoMenu.FlatAppearance.BorderSize = 0;
            this.btnBookInfoMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookInfoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookInfoMenu.ForeColor = System.Drawing.Color.White;
            this.btnBookInfoMenu.Location = new System.Drawing.Point(271, 3);
            this.btnBookInfoMenu.Name = "btnBookInfoMenu";
            this.btnBookInfoMenu.Size = new System.Drawing.Size(127, 52);
            this.btnBookInfoMenu.TabIndex = 88;
            this.btnBookInfoMenu.Text = "Book Information";
            this.btnBookInfoMenu.UseVisualStyleBackColor = false;
            this.btnBookInfoMenu.Click += new System.EventHandler(this.btnBookInfoMenu_Click);
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
            this.btnBorrowMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmReturn_MouseMove);
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.BackColor = System.Drawing.Color.White;
            this.btnReturnMenu.FlatAppearance.BorderSize = 0;
            this.btnReturnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnReturnMenu.Location = new System.Drawing.Point(137, 3);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(127, 52);
            this.btnReturnMenu.TabIndex = 79;
            this.btnReturnMenu.Text = "Return";
            this.btnReturnMenu.UseVisualStyleBackColor = false;
            // 
            // btnReportMenu
            // 
            this.btnReportMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(200)))));
            this.btnReportMenu.FlatAppearance.BorderSize = 0;
            this.btnReportMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReportMenu.Location = new System.Drawing.Point(539, 3);
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
            this.btnMemberInfoMenu.Location = new System.Drawing.Point(405, 3);
            this.btnMemberInfoMenu.Name = "btnMemberInfoMenu";
            this.btnMemberInfoMenu.Size = new System.Drawing.Size(127, 52);
            this.btnMemberInfoMenu.TabIndex = 77;
            this.btnMemberInfoMenu.Text = "Member Information";
            this.btnMemberInfoMenu.UseVisualStyleBackColor = false;
            this.btnMemberInfoMenu.Click += new System.EventHandler(this.btnMemberInfoMenu_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.Transparent;
            this.pnlAdmin.Controls.Add(this.btnLogout);
            this.pnlAdmin.Controls.Add(this.btnExit);
            this.pnlAdmin.Location = new System.Drawing.Point(0, 57);
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
            // frmReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Team08B_Library.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnAdminMenu);
            this.Controls.Add(this.tlpMenu);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtBookInfo);
            this.Controls.Add(this.txtMemberInfo);
            this.Controls.Add(this.dgvTransaction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tssReturn);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Book";
            this.Load += new System.EventHandler(this.frmReturn_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmReturn_MouseMove);
            this.tssReturn.ResumeLayout(false);
            this.tssReturn.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.tlpMenu.ResumeLayout(false);
            this.pnlAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbBookID;
        private System.Windows.Forms.RadioButton rbMemberID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip tssReturn;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mtxtID;
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.TextBox txtMemberInfo;
        private System.Windows.Forms.TextBox txtBookInfo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdminMenu;
        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private System.Windows.Forms.Button btnBorrowMenu;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.Button btnReportMenu;
        private System.Windows.Forms.Button btnMemberInfoMenu;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBookInfoMenu;
    }
}

