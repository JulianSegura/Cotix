using Cotix.AppLayer;
using Cotix.Domain.Entities;
using Cotix.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cotix.UI.WinForms.Quotations
{
    public partial class frmQuotationsIndex : BaseForm
    {
        //ToDo: Program QuotationIndex Form (And add Filters: Customer, Date range)

        private readonly QuotationsService _quotationService;
        private readonly UnitOfWork _uow;
        public frmQuotationsIndex(UnitOfWork Uow)
        {
            InitializeComponent();
            _uow = Uow;
            _quotationService = new QuotationsService(_uow);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (frmQuotationDetail f = new frmQuotationDetail(_quotationService,_uow))
            {
                f.ShowDialog();
                //ToDo: Agregar condicion para verificar si algo cambio en la cotizacion
            }

            FillQuotationsGrid();
        }

        private void frmQuotationsIndex_Load(object sender, EventArgs e)
        {
            cmbFilterDate.Items.Insert(0, "Mostrar Todas");
            cmbFilterDate.Items.Insert(1, "Fecha Creacion");
            cmbFilterDate.Items.Insert(2, "Fecha Validez");

            cmbFilterDate.SelectedIndex = 0;
            FillQuotationsGrid();
        }

        private void FillQuotationsGrid()
        {
            dgvDetails.Rows.Clear();

            var quotations = _quotationService.GetAll();

            if (quotations != null)
            {
                foreach (Quotation quotation in quotations)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvDetails);
                    row.SetValues(quotation.Id, quotation.Customer.Name, (quotation.ValidUntil.AddDays(1) - quotation.CreatedAt).Days,quotation.ValidUntil.Date, $"{quotation.SubTotal:C}", $"{quotation.TransportationFee:C}", $"{quotation.Total:C}");
                    dgvDetails.Rows.Add(row);
                }
            }
        }

        private void cmbFilterDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool gridFiltered;
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!gridFiltered && txtSearch.Text.Trim().Length < 4) return;

            //Show all rows in case the textbox is les than 4
            if (gridFiltered && txtSearch.Text.Trim().Length < 4)
            {
                UnfilterGrid();
                return;
            }

            //Search by product code or by product description. 
            //If the seachParam is not in the product code or description I make the row invisible
            //that way I dont need to go the the database
            //ToDo: Test this functionality in an extention method fof the datagrid view class
            string searchParam = txtSearch.Text.Trim().ToUpper();
            foreach (DataGridViewRow row in dgvDetails.Rows)
            {
                row.Visible = true;
                var customerName = row.Cells["CustomerName"].Value.ToString().ToUpper();
                if (!customerName.Contains(searchParam)) row.Visible = false;

                gridFiltered = true;
            }
        }

        private void UnfilterGrid()
        {
            foreach (DataGridViewRow row in dgvDetails.Rows) row.Visible = true;
            gridFiltered = false;
        }
    }
}
