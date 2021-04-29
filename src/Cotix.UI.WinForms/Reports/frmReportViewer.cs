using Cotix.Domain.Entities;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cotix.UI.WinForms.Reports
{
    public partial class frmReportViewer : Form
    {
        private readonly QuotationReportPrintable _quotationReport;
        public frmReportViewer(Quotation quotation)
        {
            InitializeComponent();
            _quotationReport = new QuotationReportPrintable(quotation);
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            GeneralInfoBindingSource.DataSource = _quotationReport;
            linesBindingSource1.DataSource = _quotationReport.Lines;
            rptViewer.LocalReport.EnableExternalImages = true;
            rptViewer.SetDisplayMode(DisplayMode.PrintLayout);

            rptViewer.RefreshReport();
            
        }
    }
}
