namespace Team08B_Library
{
    partial class frmReport
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMemberInfo = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.btnCrossTab = new System.Windows.Forms.Button();
            this.btnBookList = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpMenu.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnMemberInfo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnReceipt, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCrossTab, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBookList, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(50, 107);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(689, 301);
            this.tableLayoutPanel1.TabIndex = 58;
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBorrowMenu_MouseMove);
            // 
            // btnMemberInfo
            // 
            this.btnMemberInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(37)))), ((int)(((byte)(117)))));
            this.btnMemberInfo.FlatAppearance.BorderSize = 0;
            this.btnMemberInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberInfo.ForeColor = System.Drawing.Color.White;
            this.btnMemberInfo.Location = new System.Drawing.Point(347, 153);
            this.btnMemberInfo.Name = "btnMemberInfo";
            this.btnMemberInfo.Size = new System.Drawing.Size(339, 144);
            this.btnMemberInfo.TabIndex = 61;
            this.btnMemberInfo.Text = "Member Information";
            this.btnMemberInfo.UseVisualStyleBackColor = false;
            this.btnMemberInfo.Click += new System.EventHandler(this.btnMemberInfo_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnReceipt.FlatAppearance.BorderSize = 0;
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.ForeColor = System.Drawing.Color.White;
            this.btnReceipt.Location = new System.Drawing.Point(3, 153);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(338, 144);
            this.btnReceipt.TabIndex = 60;
            this.btnReceipt.Text = "Borrow Receipt";
            this.btnReceipt.UseVisualStyleBackColor = false;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnCrossTab
            // 
            this.btnCrossTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnCrossTab.FlatAppearance.BorderSize = 0;
            this.btnCrossTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrossTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrossTab.ForeColor = System.Drawing.Color.White;
            this.btnCrossTab.Location = new System.Drawing.Point(347, 3);
            this.btnCrossTab.Name = "btnCrossTab";
            this.btnCrossTab.Size = new System.Drawing.Size(339, 144);
            this.btnCrossTab.TabIndex = 59;
            this.btnCrossTab.Text = "Cross Tab Report";
            this.btnCrossTab.UseVisualStyleBackColor = false;
            this.btnCrossTab.Click += new System.EventHandler(this.btnCrossTab_Click);
            // 
            // btnBookList
            // 
            this.btnBookList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(37)))), ((int)(((byte)(117)))));
            this.btnBookList.FlatAppearance.BorderSize = 0;
            this.btnBookList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookList.ForeColor = System.Drawing.Color.White;
            this.btnBookList.Location = new System.Drawing.Point(3, 3);
            this.btnBookList.Name = "btnBookList";
            this.btnBookList.Size = new System.Drawing.Size(338, 144);
            this.btnBookList.TabIndex = 53;
            this.btnBookList.Text = "List of Books";
            this.btnBookList.UseVisualStyleBackColor = false;
            this.btnBookList.Click += new System.EventHandler(this.btnBookList_Click);
            this.btnBookList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBorrowMenu_MouseMove);
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
            this.btnAdminMenu.TabIndex = 88;
            this.btnAdminMenu.Text = "Hi Admin";
            this.btnAdminMenu.UseVisualStyleBackColor = false;
            this.btnAdminMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAdminMenu_MouseMove);
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
            this.tlpMenu.Location = new System.Drawing.Point(133, 1);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 1;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenu.Size = new System.Drawing.Size(667, 58);
            this.tlpMenu.TabIndex = 90;
            this.tlpMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBorrowMenu_MouseMove);
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
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(200)))));
            this.btnReturnMenu.FlatAppearance.BorderSize = 0;
            this.btnReturnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMenu.ForeColor = System.Drawing.Color.White;
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
            this.btnReportMenu.BackColor = System.Drawing.Color.White;
            this.btnReportMenu.FlatAppearance.BorderSize = 0;
            this.btnReportMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportMenu.ForeColor = System.Drawing.Color.Black;
            this.btnReportMenu.Location = new System.Drawing.Point(535, 3);
            this.btnReportMenu.Name = "btnReportMenu";
            this.btnReportMenu.Size = new System.Drawing.Size(129, 52);
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
            this.btnMemberInfoMenu.Location = new System.Drawing.Point(402, 3);
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
            this.pnlAdmin.Location = new System.Drawing.Point(0, 59);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(133, 71);
            this.pnlAdmin.TabIndex = 89;
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
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Team08B_Library.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnAdminMenu);
            this.Controls.Add(this.tlpMenu);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBorrowMenu_MouseMove);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpMenu.ResumeLayout(false);
            this.pnlAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnMemberInfo;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Button btnCrossTab;
        private System.Windows.Forms.Button btnBookList;
        private System.Windows.Forms.Button btnAdminMenu;
        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private System.Windows.Forms.Button btnBookInfoMenu;
        private System.Windows.Forms.Button btnBorrowMenu;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.Button btnReportMenu;
        private System.Windows.Forms.Button btnMemberInfoMenu;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
    }
}