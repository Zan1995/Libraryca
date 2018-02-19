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
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.sspAdd = new System.Windows.Forms.StatusStrip();
            this.sslAdd = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblTotalStock = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblBookType = new System.Windows.Forms.Label();
            this.txtTotalStock = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.txtBID = new System.Windows.Forms.TextBox();
            this.lblBID = new System.Windows.Forms.Label();
            this.cmbBookType = new System.Windows.Forms.ComboBox();
            this.lblErrorID = new System.Windows.Forms.Label();
            this.lblErrorTitle = new System.Windows.Forms.Label();
            this.lblErrorType = new System.Windows.Forms.Label();
            this.lblErrorPublisher = new System.Windows.Forms.Label();
            this.lblErrorAuthor = new System.Windows.Forms.Label();
            this.grpBookInfo = new System.Windows.Forms.GroupBox();
            this.lblErrorStock = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.sspAdd.SuspendLayout();
            this.grpBookInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewBook.FlatAppearance.BorderSize = 0;
            this.btnAddNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewBook.Location = new System.Drawing.Point(346, 395);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(129, 23);
            this.btnAddNewBook.TabIndex = 63;
            this.btnAddNewBook.Text = "Add";
            this.btnAddNewBook.UseVisualStyleBackColor = false;
            this.btnAddNewBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // sspAdd
            // 
            this.sspAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(37)))), ((int)(((byte)(117)))));
            this.sspAdd.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.sspAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslAdd});
            this.sspAdd.Location = new System.Drawing.Point(0, 478);
            this.sspAdd.Name = "sspAdd";
            this.sspAdd.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.sspAdd.Size = new System.Drawing.Size(800, 22);
            this.sspAdd.TabIndex = 66;
            this.sspAdd.Text = "statusStrip1";
            // 
            // sslAdd
            // 
            this.sslAdd.Name = "sslAdd";
            this.sslAdd.Size = new System.Drawing.Size(0, 17);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(327, 106);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(46, 16);
            this.lblAuthor.TabIndex = 55;
            this.lblAuthor.Text = "Author";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.ForeColor = System.Drawing.Color.Gray;
            this.txtPublisher.Location = new System.Drawing.Point(403, 53);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(209, 22);
            this.txtPublisher.TabIndex = 3;
            this.txtPublisher.Text = "Bloomsbury";
            this.txtPublisher.Enter += new System.EventHandler(this.ClearDefault);
            // 
            // lblTotalStock
            // 
            this.lblTotalStock.AutoSize = true;
            this.lblTotalStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStock.Location = new System.Drawing.Point(327, 172);
            this.lblTotalStock.Name = "lblTotalStock";
            this.lblTotalStock.Size = new System.Drawing.Size(76, 16);
            this.lblTotalStock.TabIndex = 54;
            this.lblTotalStock.Text = "Total Stock";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(327, 57);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(64, 16);
            this.lblPublisher.TabIndex = 56;
            this.lblPublisher.Text = "Publisher";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.ForeColor = System.Drawing.Color.Gray;
            this.txtAuthor.Location = new System.Drawing.Point(403, 102);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(209, 22);
            this.txtAuthor.TabIndex = 4;
            this.txtAuthor.Text = "J. K. Rowling";
            this.txtAuthor.Enter += new System.EventHandler(this.ClearDefault);
            // 
            // lblBookType
            // 
            this.lblBookType.AutoSize = true;
            this.lblBookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookType.Location = new System.Drawing.Point(11, 172);
            this.lblBookType.Name = "lblBookType";
            this.lblBookType.Size = new System.Drawing.Size(69, 16);
            this.lblBookType.TabIndex = 57;
            this.lblBookType.Text = "Book type";
            // 
            // txtTotalStock
            // 
            this.txtTotalStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalStock.ForeColor = System.Drawing.Color.Gray;
            this.txtTotalStock.Location = new System.Drawing.Point(403, 169);
            this.txtTotalStock.Name = "txtTotalStock";
            this.txtTotalStock.Size = new System.Drawing.Size(209, 22);
            this.txtTotalStock.TabIndex = 5;
            this.txtTotalStock.Text = "1";
            this.txtTotalStock.Enter += new System.EventHandler(this.ClearDefault);
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookTitle.ForeColor = System.Drawing.Color.Gray;
            this.txtBookTitle.Location = new System.Drawing.Point(87, 102);
            this.txtBookTitle.Multiline = true;
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBookTitle.Size = new System.Drawing.Size(209, 44);
            this.txtBookTitle.TabIndex = 1;
            this.txtBookTitle.Text = "Harry Potter";
            this.txtBookTitle.Enter += new System.EventHandler(this.ClearDefault);
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.Location = new System.Drawing.Point(11, 105);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(63, 16);
            this.lblBookTitle.TabIndex = 50;
            this.lblBookTitle.Text = "Book title";
            // 
            // txtBID
            // 
            this.txtBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBID.ForeColor = System.Drawing.Color.Gray;
            this.txtBID.Location = new System.Drawing.Point(87, 53);
            this.txtBID.MaxLength = 6;
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(209, 22);
            this.txtBID.TabIndex = 0;
            this.txtBID.Text = "eg. 1234";
            this.txtBID.TextChanged += new System.EventHandler(this.txtBID_TextChanged);
            this.txtBID.Enter += new System.EventHandler(this.ClearDefault);
            this.txtBID.Leave += new System.EventHandler(this.txtBID_Leave);
            // 
            // lblBID
            // 
            this.lblBID.AutoSize = true;
            this.lblBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBID.Location = new System.Drawing.Point(11, 57);
            this.lblBID.Name = "lblBID";
            this.lblBID.Size = new System.Drawing.Size(56, 16);
            this.lblBID.TabIndex = 51;
            this.lblBID.Text = "Book ID";
            // 
            // cmbBookType
            // 
            this.cmbBookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBookType.ForeColor = System.Drawing.Color.Gray;
            this.cmbBookType.FormattingEnabled = true;
            this.cmbBookType.Items.AddRange(new object[] {
            "Action",
            "Sci-fi",
            "Adventure",
            "Comedy",
            "Drama",
            "Animated"});
            this.cmbBookType.Location = new System.Drawing.Point(87, 170);
            this.cmbBookType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBookType.Name = "cmbBookType";
            this.cmbBookType.Size = new System.Drawing.Size(209, 24);
            this.cmbBookType.TabIndex = 2;
            this.cmbBookType.Text = "Fantasy";
            this.cmbBookType.Enter += new System.EventHandler(this.ClearDefault);
            // 
            // lblErrorID
            // 
            this.lblErrorID.AutoSize = true;
            this.lblErrorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorID.ForeColor = System.Drawing.Color.Red;
            this.lblErrorID.Location = new System.Drawing.Point(84, 78);
            this.lblErrorID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorID.Name = "lblErrorID";
            this.lblErrorID.Size = new System.Drawing.Size(29, 13);
            this.lblErrorID.TabIndex = 62;
            this.lblErrorID.Text = "Error";
            // 
            // lblErrorTitle
            // 
            this.lblErrorTitle.AutoSize = true;
            this.lblErrorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTitle.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTitle.Location = new System.Drawing.Point(84, 149);
            this.lblErrorTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorTitle.Name = "lblErrorTitle";
            this.lblErrorTitle.Size = new System.Drawing.Size(29, 13);
            this.lblErrorTitle.TabIndex = 63;
            this.lblErrorTitle.Text = "Error";
            // 
            // lblErrorType
            // 
            this.lblErrorType.AutoSize = true;
            this.lblErrorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorType.ForeColor = System.Drawing.Color.Red;
            this.lblErrorType.Location = new System.Drawing.Point(84, 196);
            this.lblErrorType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorType.Name = "lblErrorType";
            this.lblErrorType.Size = new System.Drawing.Size(29, 13);
            this.lblErrorType.TabIndex = 64;
            this.lblErrorType.Text = "Error";
            // 
            // lblErrorPublisher
            // 
            this.lblErrorPublisher.AutoSize = true;
            this.lblErrorPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPublisher.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPublisher.Location = new System.Drawing.Point(400, 78);
            this.lblErrorPublisher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorPublisher.Name = "lblErrorPublisher";
            this.lblErrorPublisher.Size = new System.Drawing.Size(29, 13);
            this.lblErrorPublisher.TabIndex = 65;
            this.lblErrorPublisher.Text = "Error";
            // 
            // lblErrorAuthor
            // 
            this.lblErrorAuthor.AutoSize = true;
            this.lblErrorAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorAuthor.ForeColor = System.Drawing.Color.Red;
            this.lblErrorAuthor.Location = new System.Drawing.Point(400, 127);
            this.lblErrorAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorAuthor.Name = "lblErrorAuthor";
            this.lblErrorAuthor.Size = new System.Drawing.Size(29, 13);
            this.lblErrorAuthor.TabIndex = 66;
            this.lblErrorAuthor.Text = "Error";
            // 
            // grpBookInfo
            // 
            this.grpBookInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(202)))), ((int)(((byte)(238)))));
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
            this.grpBookInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBookInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookInfo.Location = new System.Drawing.Point(84, 120);
            this.grpBookInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpBookInfo.Name = "grpBookInfo";
            this.grpBookInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpBookInfo.Size = new System.Drawing.Size(627, 227);
            this.grpBookInfo.TabIndex = 65;
            this.grpBookInfo.TabStop = false;
            this.grpBookInfo.Text = "Book Information";
            // 
            // lblErrorStock
            // 
            this.lblErrorStock.AutoSize = true;
            this.lblErrorStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorStock.ForeColor = System.Drawing.Color.Red;
            this.lblErrorStock.Location = new System.Drawing.Point(400, 194);
            this.lblErrorStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorStock.Name = "lblErrorStock";
            this.lblErrorStock.Size = new System.Drawing.Size(29, 13);
            this.lblErrorStock.TabIndex = 68;
            this.lblErrorStock.Text = "Error";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(333, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 73;
            this.label2.Text = "Add A New Book";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(780, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(20, 20);
            this.btnCancel.TabIndex = 74;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Team08B_Library.Properties.Resources.Background_purple;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sspAdd);
            this.Controls.Add(this.btnAddNewBook);
            this.Controls.Add(this.grpBookInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddNewBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookInfo_AddNewBook";
            this.Load += new System.EventHandler(this.frmAddNewBook_Load);
            this.sspAdd.ResumeLayout(false);
            this.sspAdd.PerformLayout();
            this.grpBookInfo.ResumeLayout(false);
            this.grpBookInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.StatusStrip sspAdd;
        private System.Windows.Forms.ToolStripStatusLabel sslAdd;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label lblTotalStock;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblBookType;
        private System.Windows.Forms.TextBox txtTotalStock;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox txtBID;
        private System.Windows.Forms.Label lblBID;
        private System.Windows.Forms.ComboBox cmbBookType;
        private System.Windows.Forms.Label lblErrorID;
        private System.Windows.Forms.Label lblErrorTitle;
        private System.Windows.Forms.Label lblErrorType;
        private System.Windows.Forms.Label lblErrorPublisher;
        private System.Windows.Forms.Label lblErrorAuthor;
        private System.Windows.Forms.GroupBox grpBookInfo;
        private System.Windows.Forms.Label lblErrorStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
    }
}