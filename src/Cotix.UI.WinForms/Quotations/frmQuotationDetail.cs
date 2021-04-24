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
    public partial class frmQuotationDetail : Form
    {
        //ToDo: If the call action is to add, Quotation ID must be invisible.
        //ToDo: Add function to verify added product in quotation grid and increase quantity.
        //ToDo: Add function to calculate and display totals.

        private readonly ProductsService _productService;

        public frmQuotationDetail()
        {
            InitializeComponent();
            _productService = new ProductsService(new UnitOfWork());
        }

        private void chkAddTransportation_CheckedChanged(object sender, EventArgs e)
        {

            if (chkAddTransportation.Checked) 
            {
                txtTransportationCost.Visible = true;
                txtTransportationCost.Focus();
                lblTransportationTittle.Visible = true;
                lblTotalTittle.Location = new Point(437, 504);
                lblTotal.Location = new Point(481, 495);
                return;
            } 
            
            txtTransportationCost.Visible = false;
            txtTransportationCost.Clear();
            lblTransportationTittle.Visible = false;
            lblTotalTittle.Location = new Point(437, 484);
            lblTotal.Location = new Point(481, 475);
            
            
        }

        private bool HandleKey(ref TextBox textbox, char keycode)
        {
            if (keycode == '.' && textbox.Text.Trim().Length == 0) return true;

            if (keycode == '.' && textbox.Text.Contains(".")) return true;

            return (!char.IsDigit(keycode) && keycode != '.' && keycode != (char)Keys.Back);
        }

        private void txtTransportationCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = HandleKey(ref txtTransportationCost, e.KeyChar);
        }

        private void frmQuotationDetail_Load(object sender, EventArgs e)
        {
            dtpValidUntil.CustomFormat = "dd-MM-yyyy";
            dtpValidUntil.MinDate = DateTime.Today;
            FillProductsDatagrid(_productService.GetAll().Where(p => p.Disabled == false).ToList());
        }

        private void FillProductsDatagrid(ICollection<Product> products)
        {
            dgvProducts.Rows.Clear();
            var picture = new Bitmap(64,64);
            foreach (var product in products)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvProducts);
                picture = product.PicturePath != "" ? new Bitmap(new Bitmap(product.PicturePath), 64, 64) : new Bitmap(Properties.Resources.boxes, 64, 64);
                row.SetValues(product.Id, product.Code, product.Description, picture, $"{product.Price:C}",1,"Agregar");
                dgvProducts.Rows.Add(row);
            }

            dgvProducts.ClearSelection();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataGridButtonClicked(sender, e)) return;

            int qty;

            if(!int.TryParse(dgvProducts.Rows[e.RowIndex].Cells["Qty"].Value.ToString(),out qty))
            {
                MessageBox.Show("Debe ingresar solo numeros en el campo cantidad","COTIX");
                return;
            }

            int productId = (int)dgvProducts.Rows[e.RowIndex].Cells["Id"].Value;
            var product = _productService.GetById(productId);
 
               
            AddItemToQuotation(product,qty);

            dgvProducts.Rows[e.RowIndex].Cells["Qty"].Value = 1;
            
        }

        private bool DataGridButtonClicked(object sender, DataGridViewCellEventArgs e)
        {
            var sendergrid = (DataGridView)sender;

            if (sendergrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) return true;
            return false;
        }

        private void AddItemToQuotation(Product product, int quantity)
        {
            var picture = new Bitmap(64, 64);
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvQuotationDetails);

            picture = product.PicturePath != "" ? new Bitmap(new Bitmap(product.PicturePath), 64, 64) : new Bitmap(Properties.Resources.boxes, 64, 64);
            row.SetValues(product.Id, product.Code, product.Description, picture,quantity, $"{product.Price:C}",$"{product.Price*quantity:c}", "Eliminar");
            dgvQuotationDetails.Rows.Add(row);

            dgvQuotationDetails.Rows[dgvQuotationDetails.Rows.Count-1].Selected = true;
        }

        private void dgvQuotationDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataGridButtonClicked(sender, e)) return;

            dgvQuotationDetails.Rows.RemoveAt(e.RowIndex);
        }

        private void btnExportExcel_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(btnExportExcel, "Exportar A Excel");
        }

        private void btnExportPDF_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(btnExportPDF, "Exportar A PDF");
        }

        private void txtDaysValid_TextChanged(object sender, EventArgs e)
        {
            if (txtDaysValid.Text.Length < 1) return;

            var days = double.Parse(txtDaysValid.Text);
            dtpValidUntil.Value = DateTime.Today.AddDays(days);
        }

        private void txtDaysValid_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKey(sender, e);
        }

        private void HandleKey(object sender, KeyPressEventArgs e)
        {
            bool isDigit = char.IsDigit(e.KeyChar);
            bool isBackKey = e.KeyChar == (char)Keys.Back;

            e.Handled = !isDigit && !isBackKey;
        }

        private void txtTransportationCost_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            HandleKey(sender, e);
        }
    }
}