namespace QLPT
{
    partial class frmReportBill
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.cbxBill = new System.Windows.Forms.ComboBox();
            this.rpvBill = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ReportBillBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hóa đơn";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(693, 29);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(90, 32);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // cbxBill
            // 
            this.cbxBill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBill.FormattingEnabled = true;
            this.cbxBill.Location = new System.Drawing.Point(507, 34);
            this.cbxBill.Name = "cbxBill";
            this.cbxBill.Size = new System.Drawing.Size(151, 24);
            this.cbxBill.TabIndex = 4;
            // 
            // rpvBill
            // 
            this.rpvBill.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "ReportBillDataSet";
            reportDataSource1.Value = this.ReportBillBindingSource;
            this.rpvBill.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvBill.LocalReport.ReportEmbeddedResource = "QLPT.ReportBill.rdlc";
            this.rpvBill.Location = new System.Drawing.Point(0, 94);
            this.rpvBill.Name = "rpvBill";
            this.rpvBill.ServerReport.BearerToken = null;
            this.rpvBill.Size = new System.Drawing.Size(1355, 525);
            this.rpvBill.TabIndex = 5;
            // 
            // ReportBillBindingSource
            // 
            this.ReportBillBindingSource.DataSource = typeof(QLPT.DTO.ReportBill);
            // 
            // frmReportBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 619);
            this.Controls.Add(this.rpvBill);
            this.Controls.Add(this.cbxBill);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label1);
            this.Name = "frmReportBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê hóa đơn";
            this.Load += new System.EventHandler(this.frmReportBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportBillBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ComboBox cbxBill;
        private System.Windows.Forms.BindingSource ReportBillBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rpvBill;
    }
}