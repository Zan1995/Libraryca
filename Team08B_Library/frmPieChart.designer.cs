namespace Team08B_Library
{
    partial class frmPieChart
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
            this.crvPieChart = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvPieChart
            // 
            this.crvPieChart.ActiveViewIndex = -1;
            this.crvPieChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPieChart.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPieChart.Location = new System.Drawing.Point(0, 0);
            this.crvPieChart.Name = "crvPieChart";
            this.crvPieChart.Size = new System.Drawing.Size(558, 538);
            this.crvPieChart.TabIndex = 0;
            // 
            // frmPieChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 538);
            this.Controls.Add(this.crvPieChart);
            this.Name = "frmPieChart";
            this.Text = "Report_Pie Chart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPieChart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPieChart;
    }
}