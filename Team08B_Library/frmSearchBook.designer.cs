namespace Team08B_Library
{
    partial class frmSearchBook
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssSearch = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.rbtAll = new System.Windows.Forms.RadioButton();
            this.rbtInStock = new System.Windows.Forms.RadioButton();
            this.rbtOutOfStock = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(37)))), ((int)(((byte)(117)))));
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssSearch});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssSearch
            // 
            this.tssSearch.ForeColor = System.Drawing.Color.White;
            this.tssSearch.Name = "tssSearch";
            this.tssSearch.Size = new System.Drawing.Size(85, 17);
            this.tssSearch.Text = "Search status";
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchBy.Location = new System.Drawing.Point(118, 70);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(69, 16);
            this.lblSearchBy.TabIndex = 2;
            this.lblSearchBy.Text = "Search by";
            // 
            // cboSearch
            // 
            this.cboSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Location = new System.Drawing.Point(196, 66);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(141, 24);
            this.cboSearch.TabIndex = 3;
            this.cboSearch.TabStop = false;
            this.cboSearch.SelectedIndexChanged += new System.EventHandler(this.cboSearch_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(346, 67);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(319, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TabStop = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToResizeColumns = false;
            this.dgvSearch.AllowUserToResizeRows = false;
            this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSearch.Location = new System.Drawing.Point(53, 133);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearch.Size = new System.Drawing.Size(675, 288);
            this.dgvSearch.TabIndex = 5;
            this.dgvSearch.TabStop = false;
            this.dgvSearch.DoubleClick += new System.EventHandler(this.dgvSearch_DoubleClick);
            // 
            // rbtAll
            // 
            this.rbtAll.AutoSize = true;
            this.rbtAll.BackColor = System.Drawing.Color.Transparent;
            this.rbtAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtAll.Location = new System.Drawing.Point(276, 104);
            this.rbtAll.Name = "rbtAll";
            this.rbtAll.Size = new System.Drawing.Size(41, 20);
            this.rbtAll.TabIndex = 6;
            this.rbtAll.TabStop = true;
            this.rbtAll.Text = "All";
            this.rbtAll.UseVisualStyleBackColor = false;
            this.rbtAll.CheckedChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // rbtInStock
            // 
            this.rbtInStock.AutoSize = true;
            this.rbtInStock.BackColor = System.Drawing.Color.Transparent;
            this.rbtInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtInStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtInStock.Location = new System.Drawing.Point(333, 104);
            this.rbtInStock.Name = "rbtInStock";
            this.rbtInStock.Size = new System.Drawing.Size(73, 20);
            this.rbtInStock.TabIndex = 6;
            this.rbtInStock.TabStop = true;
            this.rbtInStock.Text = "In Stock";
            this.rbtInStock.UseVisualStyleBackColor = false;
            this.rbtInStock.CheckedChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // rbtOutOfStock
            // 
            this.rbtOutOfStock.AutoSize = true;
            this.rbtOutOfStock.BackColor = System.Drawing.Color.Transparent;
            this.rbtOutOfStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtOutOfStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtOutOfStock.Location = new System.Drawing.Point(422, 104);
            this.rbtOutOfStock.Name = "rbtOutOfStock";
            this.rbtOutOfStock.Size = new System.Drawing.Size(97, 20);
            this.rbtOutOfStock.TabIndex = 6;
            this.rbtOutOfStock.TabStop = true;
            this.rbtOutOfStock.Text = "Out of Stock";
            this.rbtOutOfStock.UseVisualStyleBackColor = false;
            this.rbtOutOfStock.CheckedChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(331, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search Books";
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
            this.btnCancel.TabIndex = 78;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Team08B_Library.Properties.Resources.Background_purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtOutOfStock);
            this.Controls.Add(this.rbtInStock);
            this.Controls.Add(this.rbtAll);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.lblSearchBy);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSearchBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Book";
            this.Load += new System.EventHandler(this.frmSearchBook_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssSearch;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.RadioButton rbtAll;
        private System.Windows.Forms.RadioButton rbtInStock;
        private System.Windows.Forms.RadioButton rbtOutOfStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
    }
}