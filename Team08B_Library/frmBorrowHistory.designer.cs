namespace Team08B_Library
{
    partial class frmBorrowHistory
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblBigTitle = new System.Windows.Forms.Label();
            this.lblBorrowAvai = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblID.Location = new System.Drawing.Point(67, 91);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "lblID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName.Location = new System.Drawing.Point(345, 89);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "lblName";
            // 
            // tbxID
            // 
            this.tbxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxID.Location = new System.Drawing.Point(156, 86);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(109, 22);
            this.tbxID.TabIndex = 1;
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(456, 88);
            this.tbxName.Multiline = true;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(260, 53);
            this.tbxName.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(717, 215);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblBigTitle
            // 
            this.lblBigTitle.AutoSize = true;
            this.lblBigTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBigTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBigTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBigTitle.Location = new System.Drawing.Point(314, 26);
            this.lblBigTitle.Name = "lblBigTitle";
            this.lblBigTitle.Size = new System.Drawing.Size(158, 24);
            this.lblBigTitle.TabIndex = 76;
            this.lblBigTitle.Text = "Borrowing History";
            // 
            // lblBorrowAvai
            // 
            this.lblBorrowAvai.AutoSize = true;
            this.lblBorrowAvai.BackColor = System.Drawing.Color.DarkGray;
            this.lblBorrowAvai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowAvai.Location = new System.Drawing.Point(301, 242);
            this.lblBorrowAvai.Name = "lblBorrowAvai";
            this.lblBorrowAvai.Size = new System.Drawing.Size(179, 16);
            this.lblBorrowAvai.TabIndex = 77;
            this.lblBorrowAvai.Text = "There is no borrowing history";
            this.lblBorrowAvai.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(764, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(20, 20);
            this.btnCancel.TabIndex = 78;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmBorrowHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Team08B_Library.Properties.Resources.Background_purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 398);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblBorrowAvai);
            this.Controls.Add(this.lblBigTitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBorrowHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBorrowDetails";
            this.Load += new System.EventHandler(this.frmBorrowDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblBigTitle;
        private System.Windows.Forms.Label lblBorrowAvai;
        private System.Windows.Forms.Button btnCancel;
    }
}