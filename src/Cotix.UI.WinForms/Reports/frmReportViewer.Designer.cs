
namespace Cotix.UI.WinForms.Reports
{
    partial class frmReportViewer
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GeneralInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // GeneralInfoBindingSource
            // 
            this.GeneralInfoBindingSource.DataSource = typeof(Cotix.UI.WinForms.Reports.QuotationReportPrintable);
            // 
            // rptViewer
            // 
            this.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "GeneralInfo";
            reportDataSource1.Value = this.GeneralInfoBindingSource;
            reportDataSource2.Name = "Lines";
            reportDataSource2.Value = this.linesBindingSource1;
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.rptViewer.LocalReport.EnableExternalImages = true;
            this.rptViewer.LocalReport.ReportEmbeddedResource = "Cotix.UI.WinForms.Reports.QuotationReport_Printable.rdlc";
            this.rptViewer.Location = new System.Drawing.Point(0, 0);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.ServerReport.BearerToken = null;
            this.rptViewer.Size = new System.Drawing.Size(847, 587);
            this.rptViewer.TabIndex = 0;
            // 
            // frmReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 587);
            this.Controls.Add(this.rptViewer);
            this.Name = "frmReportViewer";
            this.Text = "Reporte Cotizacion";
            this.Load += new System.EventHandler(this.frmReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GeneralInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
        private System.Windows.Forms.BindingSource GeneralInfoBindingSource;
        private System.Windows.Forms.BindingSource linesBindingSource1;
    }
}