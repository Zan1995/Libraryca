namespace Team08B_Library
{
    partial class frmBookUpdate
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
            this.tbxAuthor = new System.Windows.Forms.TextBox();
            this.lblTotalStock = new System.Windows.Forms.Label();
            this.tbxPublisher = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblBookType = new System.Windows.Forms.Label();
            this.tbxBookTitle = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.tbxBookID = new System.Windows.Forms.TextBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxNumberBorowed = new System.Windows.Forms.TextBox();
            this.lblNumberBorrowed = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbbBookType = new System.Windows.Forms.ComboBox();
            this.nudTotalStock = new System.Windows.Forms.NumericUpDown();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTotalStockValid = new System.Windows.Forms.Label();
            this.lblAuthorValid = new System.Windows.Forms.Label();
            this.lblPublisherValid = new System.Windows.Forms.Label();
            this.lblBookTitleValid = new System.Windows.Forms.Label();
            this.lblBookTypeValid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalStock)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxAuthor
            // 
            this.tbxAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAuthor.Location = new System.Drawing.Point(464, 70);
            this.tbxAuthor.Name = "tbxAuthor";
            this.tbxAuthor.Size = new System.Drawing.Size(209, 22);
            this.tbxAuthor.TabIndex = 7;
            this.tbxAuthor.TextChanged += new System.EventHandler(this.tbxAuthor_TextChanged);
            // 
            // lblTotalStock
            // 
            this.lblTotalStock.AutoSize = true;
            this.lblTotalStock.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStock.ForeColor = System.Drawing.Color.Black;
            this.lblTotalStock.Location = new System.Drawing.Point(18, 198);
            this.lblTotalStock.Name = "lblTotalStock";
            this.lblTotalStock.Size = new System.Drawing.Size(76, 16);
            this.lblTotalStock.TabIndex = 52;
            this.lblTotalStock.Text = "Total Stock";
            // 
            // tbxPublisher
            // 
            this.tbxPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPublisher.Location = new System.Drawing.Point(463, 26);
            this.tbxPublisher.Name = "tbxPublisher";
            this.tbxPublisher.Size = new System.Drawing.Size(210, 22);
            this.tbxPublisher.TabIndex = 6;
            this.tbxPublisher.TextChanged += new System.EventHandler(this.tbxPublisher_TextChanged);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.Black;
            this.lblAuthor.Location = new System.Drawing.Point(344, 74);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(46, 16);
            this.lblAuthor.TabIndex = 53;
            this.lblAuthor.Text = "Author";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.BackColor = System.Drawing.Color.Transparent;
            this.lblPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.ForeColor = System.Drawing.Color.Black;
            this.lblPublisher.Location = new System.Drawing.Point(344, 29);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(64, 16);
            this.lblPublisher.TabIndex = 54;
            this.lblPublisher.Text = "Publisher";
            // 
            // lblBookType
            // 
            this.lblBookType.AutoSize = true;
            this.lblBookType.BackColor = System.Drawing.Color.Transparent;
            this.lblBookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookType.ForeColor = System.Drawing.Color.Black;
            this.lblBookType.Location = new System.Drawing.Point(18, 75);
            this.lblBookType.Name = "lblBookType";
            this.lblBookType.Size = new System.Drawing.Size(69, 16);
            this.lblBookType.TabIndex = 55;
            this.lblBookType.Text = "Book type";
            // 
            // tbxBookTitle
            // 
            this.tbxBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBookTitle.Location = new System.Drawing.Point(108, 112);
            this.tbxBookTitle.Multiline = true;
            this.tbxBookTitle.Name = "tbxBookTitle";
            this.tbxBookTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxBookTitle.Size = new System.Drawing.Size(565, 67);
            this.tbxBookTitle.TabIndex = 2;
            this.tbxBookTitle.TextChanged += new System.EventHandler(this.tbxBookTitle_TextChanged);
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.ForeColor = System.Drawing.Color.Black;
            this.lblBookTitle.Location = new System.Drawing.Point(18, 115);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(63, 16);
            this.lblBookTitle.TabIndex = 48;
            this.lblBookTitle.Text = "Book title";
            // 
            // tbxBookID
            // 
            this.tbxBookID.Enabled = false;
            this.tbxBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBookID.Location = new System.Drawing.Point(108, 25);
            this.tbxBookID.Name = "tbxBookID";
            this.tbxBookID.Size = new System.Drawing.Size(209, 22);
            this.tbxBookID.TabIndex = 1;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.BackColor = System.Drawing.Color.Transparent;
            this.lblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.ForeColor = System.Drawing.Color.Black;
            this.lblBookID.Location = new System.Drawing.Point(18, 29);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(56, 16);
            this.lblBookID.TabIndex = 49;
            this.lblBookID.Text = "Book ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(436, 370);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 30);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.Leave += new System.EventHandler(this.btnUpdate_Leave);
            // 
            // tbxNumberBorowed
            // 
            this.tbxNumberBorowed.Enabled = false;
            this.tbxNumberBorowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNumberBorowed.Location = new System.Drawing.Point(463, 196);
            this.tbxNumberBorowed.Name = "tbxNumberBorowed";
            this.tbxNumberBorowed.Size = new System.Drawing.Size(84, 22);
            this.tbxNumberBorowed.TabIndex = 9;
            // 
            // lblNumberBorrowed
            // 
            this.lblNumberBorrowed.AutoSize = true;
            this.lblNumberBorrowed.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberBorrowed.ForeColor = System.Drawing.Color.Black;
            this.lblNumberBorrowed.Location = new System.Drawing.Point(344, 199);
            this.lblNumberBorrowed.Name = "lblNumberBorrowed";
            this.lblNumberBorrowed.Size = new System.Drawing.Size(116, 16);
            this.lblNumberBorrowed.TabIndex = 62;
            this.lblNumberBorrowed.Text = "Number borrowed";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(37)))), ((int)(((byte)(117)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 66;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // cbbBookType
            // 
            this.cbbBookType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbBookType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbBookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBookType.FormattingEnabled = true;
            this.cbbBookType.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Animated",
            "Animation",
            "Comedy",
            "Drama",
            "Horror",
            "Martial Ar",
            "Sci-fi",
            "War"});
            this.cbbBookType.Location = new System.Drawing.Point(108, 68);
            this.cbbBookType.Name = "cbbBookType";
            this.cbbBookType.Size = new System.Drawing.Size(209, 24);
            this.cbbBookType.TabIndex = 3;
            this.cbbBookType.SelectedIndexChanged += new System.EventHandler(this.cbbBookType_SelectedIndexChanged);
            this.cbbBookType.TextChanged += new System.EventHandler(this.cbbBookType_SelectedIndexChanged);
            // 
            // nudTotalStock
            // 
            this.nudTotalStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTotalStock.Location = new System.Drawing.Point(108, 196);
            this.nudTotalStock.Name = "nudTotalStock";
            this.nudTotalStock.ReadOnly = true;
            this.nudTotalStock.Size = new System.Drawing.Size(120, 22);
            this.nudTotalStock.TabIndex = 8;
            this.nudTotalStock.ValueChanged += new System.EventHandler(this.nudTotalStock_ValueChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(206, 370);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 30);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTotalStockValid
            // 
            this.lblTotalStockValid.AutoSize = true;
            this.lblTotalStockValid.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalStockValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStockValid.ForeColor = System.Drawing.Color.Red;
            this.lblTotalStockValid.Location = new System.Drawing.Point(105, 221);
            this.lblTotalStockValid.Name = "lblTotalStockValid";
            this.lblTotalStockValid.Size = new System.Drawing.Size(29, 13);
            this.lblTotalStockValid.TabIndex = 68;
            this.lblTotalStockValid.Text = "Error";
            // 
            // lblAuthorValid
            // 
            this.lblAuthorValid.AutoSize = true;
            this.lblAuthorValid.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthorValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorValid.ForeColor = System.Drawing.Color.Red;
            this.lblAuthorValid.Location = new System.Drawing.Point(461, 94);
            this.lblAuthorValid.Name = "lblAuthorValid";
            this.lblAuthorValid.Size = new System.Drawing.Size(29, 13);
            this.lblAuthorValid.TabIndex = 68;
            this.lblAuthorValid.Text = "Error";
            // 
            // lblPublisherValid
            // 
            this.lblPublisherValid.AutoSize = true;
            this.lblPublisherValid.BackColor = System.Drawing.Color.Transparent;
            this.lblPublisherValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisherValid.ForeColor = System.Drawing.Color.Red;
            this.lblPublisherValid.Location = new System.Drawing.Point(461, 51);
            this.lblPublisherValid.Name = "lblPublisherValid";
            this.lblPublisherValid.Size = new System.Drawing.Size(29, 13);
            this.lblPublisherValid.TabIndex = 68;
            this.lblPublisherValid.Text = "Error";
            // 
            // lblBookTitleValid
            // 
            this.lblBookTitleValid.AutoSize = true;
            this.lblBookTitleValid.BackColor = System.Drawing.Color.Transparent;
            this.lblBookTitleValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitleValid.ForeColor = System.Drawing.Color.Red;
            this.lblBookTitleValid.Location = new System.Drawing.Point(105, 180);
            this.lblBookTitleValid.Name = "lblBookTitleValid";
            this.lblBookTitleValid.Size = new System.Drawing.Size(29, 13);
            this.lblBookTitleValid.TabIndex = 68;
            this.lblBookTitleValid.Text = "Error";
            // 
            // lblBookTypeValid
            // 
            this.lblBookTypeValid.AutoSize = true;
            this.lblBookTypeValid.BackColor = System.Drawing.Color.Transparent;
            this.lblBookTypeValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTypeValid.ForeColor = System.Drawing.Color.Red;
            this.lblBookTypeValid.Location = new System.Drawing.Point(105, 94);
            this.lblBookTypeValid.Name = "lblBookTypeValid";
            this.lblBookTypeValid.Size = new System.Drawing.Size(29, 13);
            this.lblBookTypeValid.TabIndex = 68;
            this.lblBookTypeValid.Text = "Error";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(307, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 24);
            this.label2.TabIndex = 73;
            this.label2.Text = "Book Information Update";
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
            this.btnCancel.TabIndex = 76;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(202)))), ((int)(((byte)(238)))));
            this.groupBox1.Controls.Add(this.lblBookTypeValid);
            this.groupBox1.Controls.Add(this.lblBookTitleValid);
            this.groupBox1.Controls.Add(this.lblPublisherValid);
            this.groupBox1.Controls.Add(this.lblAuthorValid);
            this.groupBox1.Controls.Add(this.lblTotalStockValid);
            this.groupBox1.Controls.Add(this.nudTotalStock);
            this.groupBox1.Controls.Add(this.cbbBookType);
            this.groupBox1.Controls.Add(this.tbxNumberBorowed);
            this.groupBox1.Controls.Add(this.lblNumberBorrowed);
            this.groupBox1.Controls.Add(this.tbxAuthor);
            this.groupBox1.Controls.Add(this.lblTotalStock);
            this.groupBox1.Controls.Add(this.tbxPublisher);
            this.groupBox1.Controls.Add(this.lblAuthor);
            this.groupBox1.Controls.Add(this.lblPublisher);
            this.groupBox1.Controls.Add(this.lblBookType);
            this.groupBox1.Controls.Add(this.tbxBookTitle);
            this.groupBox1.Controls.Add(this.lblBookTitle);
            this.groupBox1.Controls.Add(this.tbxBookID);
            this.groupBox1.Controls.Add(this.lblBookID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 257);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Information";
            // 
            // frmBookUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Team08B_Library.Properties.Resources.Background_purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnUpdate);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBookUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookInfo_Update";
            this.Load += new System.EventHandler(this.BookInfo_Update_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalStock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxAuthor;
        private System.Windows.Forms.Label lblTotalStock;
        private System.Windows.Forms.TextBox tbxPublisher;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblBookType;
        private System.Windows.Forms.TextBox tbxBookTitle;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox tbxBookID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxNumberBorowed;
        private System.Windows.Forms.Label lblNumberBorrowed;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox cbbBookType;
        private System.Windows.Forms.NumericUpDown nudTotalStock;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTotalStockValid;
        private System.Windows.Forms.Label lblAuthorValid;
        private System.Windows.Forms.Label lblPublisherValid;
        private System.Windows.Forms.Label lblBookTitleValid;
        private System.Windows.Forms.Label lblBookTypeValid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}