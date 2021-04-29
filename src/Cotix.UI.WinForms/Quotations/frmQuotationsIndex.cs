using Cotix.AppLayer;
using Cotix.Domain.Entities;
using Cotix.Infrastructure;
using Cotix.UI.WinForms.Reports;
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
                //ToDo: Add condition to check if something changed on the quotation so i can call the FillQuotationGrid method
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
                    row.SetValues
                        (quotation.Id,
                        quotation.Customer.Name,
                        (quotation.ValidUntil.AddDays(1) - quotation.CreatedAt).Days,
                        quotation.CreatedAt,
                        quotation.ValidUntil.Date,
                        $"{quotation.SubTotal:C}",
                        $"{quotation.TransportationFee:C}",
                        $"{quotation.Total:C}",
                        "Imprimir");

                    dgvDetails.Rows.Add(row);
                }
            }
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

        private void btnSeach_Click(object sender, EventArgs e)
        {
            var dateFrom = new DateTime();
            var dateTo = new DateTime();
            string filterColumn = "";

            switch (cmbFilterDate.SelectedIndex)
            {
                case 1:
                    //filter by createdAt date
                    filterColumn = "CreatedAt";
                    dateFrom = dtpDateFrom.Value.Date;
                    dateTo = dtpDateTo.Value.Date;
                    FilterGridByDate(filterColumn,dateFrom,dateTo);
                    break;
                case 2:
                    //filter by validUntil date ValidUntil
                    filterColumn = "ValidUntil";
                    dateFrom = dtpDateFrom.Value.Date;
                    dateTo = dtpDateTo.Value.Date;
                    FilterGridByDate(filterColumn, dateFrom, dateTo);
                    break;
                default:
                    if (gridFiltered) UnfilterGrid();
                    break;
            }
        }

        private void FilterGridByDate(string filterColumn, DateTime dateFrom, DateTime dateTo)
        {
            foreach (DataGridViewRow row in dgvDetails.Rows)
            {
                row.Visible = true;

                var quotationDate = Convert.ToDateTime(row.Cells[$"{filterColumn}"].Value).Date;
                if (!(quotationDate >= dateFrom && quotationDate<=dateTo)) row.Visible = false;

                gridFiltered = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDetails.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe Seleccionar Una Cotizacion A Borrar", "COTIX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show("Seguro que desea ELIMINAR ESTA COTIZACION?", "COTIX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var quotationId = Convert.ToInt32(dgvDetails.SelectedRows[0].Cells["QuotationId"].Value);
            if (!_quotationService.Delete(quotationId))
            {
                MessageBox.Show("Error al eliminar la cotizacion", "COTIX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FillQuotationsGrid();
        }

        private void dtpDateTo_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateTo.Value.Date < dtpDateFrom.Value.Date)
            {
                MessageBox.Show("La FECHA HASTA no puede ser menor que la FECHA DESDE", "COTIX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDateTo.Value = dtpDateFrom.Value;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDetails.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe Seleccionar Una Cotizacion para ACTUALIZAR", "COTIX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var id = Convert.ToInt32(dgvDetails.SelectedRows[0].Cells["QuotationId"].Value);
            var quotation = _quotationService.GetById(id);

            using (frmQuotationDetail f = new frmQuotationDetail(_quotationService, _uow))
            {
                f.Tag = quotation;
                f.ShowDialog();
                //ToDo: Add condition to check if something changed on the quotation so i can call the FillQuotationGrid method
            }

            FillQuotationsGrid();
        }

        private void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var sendergrid = (DataGridView)sender;

            if (sendergrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var quotationId = Convert.ToInt32(sendergrid.Rows[e.RowIndex].Cells["QuotationId"].Value);
                var quotation = _quotationService.GetById(quotationId);
                using (frmReportViewer f = new frmReportViewer(quotation))
                {
                    f.ShowDialog();
                }
            }
        }
    }
}