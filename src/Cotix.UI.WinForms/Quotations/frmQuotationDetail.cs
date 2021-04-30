using Cotix.AppLayer;
using Cotix.AppLayer.Interfaces;
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
    public partial class frmQuotationDetail : Form
    {
        private readonly ProductsService _productService;
        private readonly CustomersService _customerService;
        private readonly QuotationsService _quotationService;
        
        private decimal QuotationSubTotal;
        private decimal TransportationCost;
        private decimal QuotationTotal;

        public frmQuotationDetail(QuotationsService service, UnitOfWork UoW)
        {
            InitializeComponent();
            _quotationService = service;
            _productService = new ProductsService(UoW);
            _customerService = new CustomersService(UoW);

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

        private void frmQuotationDetail_Load(object sender, EventArgs e)
        {
            FillProductsDatagrid(_productService.GetAll().Where(p => p.Disabled == false).ToList());
            
            dtpValidUntil.CustomFormat = "dd-MM-yyyy";
            dtpValidUntil.MinDate = DateTime.Today;

            if (Tag != null)
            {
                lblQuotationNumberLabel.Visible = true;
                lblQuotationNumber.Visible = true;
                lblCustomerId.Visible = true;
                lblCustomerIdLabel.Visible = true;
                FillFormForUpdate();
            }

            cmbCustomerName.Focus();
        }

        private void FillFormForUpdate()
        {
            var quotation = Tag as Quotation;

            //fillCustomerInfo
            cmbCustomerName.Text = quotation.Customer.Name;
            txtCustomerCompany.Text = quotation.Customer.Company;
            txtCustomerPhone.Text = quotation.Customer.PhoneNumber;
            txtCustomerEmail.Text = quotation.Customer.Email;
            lblCustomerId.Text = quotation.Customer.Id.ToString();
            gbCustomerInfo.Enabled = false;

            //Fill txtvaliddays
            txtDaysValid.Text = (quotation.ValidUntil.Date - quotation.CreatedAt.Date).Days.ToString();

            //fill lblQuotationNumber
            lblQuotationNumber.Text = quotation.Id.ToString();

            //FillQuotationDatagrid
            foreach (QuotationDetail detail in quotation.Details)
            {
                AddItemToQuotation(detail.Product, detail.Quantity);
            }
            //Fill txttransportationcost
            if (quotation.TransportationFee > 0)
            {
                chkAddTransportation.Checked = true;
                txtTransportationCost.Visible = true;
                txtTransportationCost.Text = quotation.TransportationFee.ToString();
            }
            //calculate totals & show totals
            UpdateTotals();
            ShowTotals();
            //disable save
            btnExportPDF.Enabled = true;
            EnableSave(false);
        }

        private void FillProductsDatagrid(ICollection<Product> products)
        {
            dgvProducts.Rows.Clear();;
            foreach (var product in products)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvProducts);
                var picture = product.PicturePath != "" ? new Bitmap(new Bitmap(product.PicturePath), 64, 64) : new Bitmap(Properties.Resources.boxes, 64, 64);
                row.SetValues(product.Id, product.Code, product.Description, picture, $"{product.Price:C}",1,"Agregar");
                dgvProducts.Rows.Add(row);
            }

            dgvProducts.ClearSelection();
            EnableSave(true);
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataGridButtonClicked(sender, e)) return;


            if (!int.TryParse(dgvProducts.Rows[e.RowIndex].Cells["Qty"].Value.ToString(), out int qty))
            {
                MessageBox.Show("Debe ingresar solo numeros en el campo CANTIDAD", "COTIX",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            int productId = (int)dgvProducts.Rows[e.RowIndex].Cells["Id"].Value;
            var product = _productService.GetById(productId);
 
               
            AddItemToQuotation(product,qty);

            dgvProducts.Rows[e.RowIndex].Cells["Qty"].Value = 1;

            UpdateTotals();
            ShowTotals();
            EnableSave(true);
        }

        private bool DataGridButtonClicked(object sender, DataGridViewCellEventArgs e)
        {
            var sendergrid = (DataGridView)sender;

            if (sendergrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) return true;
            return false;
        }

        private void AddItemToQuotation(Product product, int quantity)
        {
            //Verify if the product is already in the quotation grid and update qty
            if (dgvQuotationDetails.Rows.Count > 0)
            {
                (bool exists, int index) = ProductIsInQuotation(product);
                if (exists)
                {
                    var result = MessageBox.Show("El producto ya existe en la cotizacion\nActualizar la cantidad?", "COTIX", buttons: MessageBoxButtons.YesNo);
                    if (result == DialogResult.No) return;

                    dgvQuotationDetails.Rows[index].Cells["QuotationQty"].Value = quantity;
                    dgvQuotationDetails.Rows[index].Cells["PriceTotal"].Value = $"{product.Price * quantity:c}";
                    return;
                }
            }

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvQuotationDetails);

            var picture = product.PicturePath != "" ? new Bitmap(new Bitmap(product.PicturePath), 64, 64) : new Bitmap(Properties.Resources.boxes, 64, 64);

            row.SetValues(product.Id, product.Code, product.Description, picture, quantity, $"{product.Price:C}", $"{product.Price * quantity:c}", "Eliminar");
            dgvQuotationDetails.Rows.Add(row);
            dgvQuotationDetails.Rows[dgvQuotationDetails.Rows.Count - 1].Selected = true;
        }

        private (bool exists,int index) ProductIsInQuotation(Product product)
        {
            foreach (DataGridViewRow row in dgvQuotationDetails.Rows)
            {
                if ((int)row.Cells["ProductId"].Value == product.Id) return (true,row.Index);
            }
            return (false,0);
        }

        private void dgvQuotationDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataGridButtonClicked(sender, e)) return;

            dgvQuotationDetails.Rows.RemoveAt(e.RowIndex);
            UpdateTotals();
            ShowTotals();
            EnableSave(true);
        }

        private void BtnExportExcel_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(btnExportExcel, "Exportar A Excel");
        }

        private void btnExportPDF_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(btnExportPDF, "Exportar A PDF / Imprimir");
        }

        private void txtDaysValid_TextChanged(object sender, EventArgs e)
        {
            if (txtDaysValid.Text.Length < 1) return;

            var days = double.Parse(txtDaysValid.Text);
            dtpValidUntil.Value = DateTime.Today.AddDays(days);

            EnableSave(true);
        }

        private void txtDaysValid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= HandleNotNumber(e.KeyChar);
        }

        private bool HandleNotNumber(char keychar)
        {
            bool isDigit = char.IsDigit(keychar);
            bool isBackKey = keychar == (char)Keys.Back;

            return !isDigit && !isBackKey;
        }

        private bool HandleNotDecimal(TextBox textbox, char keycode)
        {
            if (keycode == '.' && textbox.Text.Trim().Length == 0) return true;

            if (keycode == '.' && textbox.Text.Contains(".")) return true;

            return (!char.IsDigit(keycode) && keycode != '.' && keycode != (char)Keys.Back);
        }

        private void txtTransportationCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = HandleNotDecimal((TextBox)sender, e.KeyChar);
        }

        private void UpdateTotals()
        {
            QuotationSubTotal = 0;
            TransportationCost = 0;
            QuotationTotal = 0;

            foreach (DataGridViewRow row in dgvQuotationDetails.Rows)
            {
                QuotationSubTotal += decimal.Parse(row.Cells["PriceTotal"].Value.ToString().Replace("$",""));
            }

            decimal.TryParse(txtTransportationCost.Text, out TransportationCost);
            QuotationTotal = QuotationSubTotal + TransportationCost;
        }

        private void ShowTotals()
        {
            lblSubTotal.Text = $"{QuotationSubTotal:C}";
            lblTotal.Text = $"{QuotationTotal:C}";
        }

        private void txtTransportationCost_TextChanged(object sender, EventArgs e)
        {
            UpdateTotals();
            ShowTotals();
            EnableSave(true);
        }

        private bool _gridFiltered;
        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {

            //Verify text length if datagridview is not filtered
            if (!_gridFiltered && txtProductSearch.Text.Trim().Length < 4) return;

            //Show all rows in case grid is filtered and the textbox is les than 4
            if (_gridFiltered && txtProductSearch.Text.Trim().Length < 4)
            {
                foreach (DataGridViewRow row in dgvProducts.Rows) row.Visible = true;
                _gridFiltered = false;
                return;
            }

            //Search by product code or by product description. 
            //If the seachParam is not in the product code or description I make the row invisible
            //that way I dont need to go the the database
            string searchParam = txtProductSearch.Text.Trim().ToUpper();
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                var productCode = row.Cells["ProductCode"].Value.ToString().ToUpper();
                var productDesc = row.Cells["ProductDescription"].Value.ToString().ToUpper();
                if (!productCode.Contains(searchParam) && !productDesc.Contains(searchParam)) row.Visible = false;
                
                _gridFiltered = true;
            }
        }

        private double _cellValueBeforeEdit; //Used to store the value of the gridCell before it is changed.
        private void dgvQuotationDetails_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvQuotationDetails.IsCurrentCellDirty)
            {
                _cellValueBeforeEdit = double.Parse(dgvQuotationDetails.CurrentCell.Value.ToString());
            }
        }

        private void dgvQuotationDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != dgvQuotationDetails.Columns["QuotationQty"].Index) return;

            var editedCell = dgvQuotationDetails.SelectedRows[0].Cells["QuotationQty"];

            if (!double.TryParse(editedCell.Value.ToString(), out double qty))
            {
                MessageBox.Show("Debe ingresar solo numeros en el campo cantidad", "COTIX",MessageBoxButtons.OK,MessageBoxIcon.Error);
                editedCell.Value = _cellValueBeforeEdit;
                return;
            }

            var price = double.Parse(editedCell.OwningRow.Cells["QuotationPrice"].Value.ToString().Replace("$", ""));

            editedCell.OwningRow.Cells["PriceTotal"].Value = $"{price * qty:C}";

            UpdateTotals();
            ShowTotals();
            EnableSave(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Tag != null) Close();
            ClearForm();

            UpdateTotals();
            ShowTotals();

            cmbCustomerName.Focus();
        }

        private void ClearForm()
        {
            chkAddTransportation.Checked = false;

            dgvQuotationDetails.Rows.Clear();

            lblQuotationNumberLabel.Visible = false;
            lblQuotationNumber.Visible = false;
            txtDaysValid.Clear();
            dtpValidUntil.Value = DateTime.Today;

            txtProductSearch.Clear();

            cmbCustomerName.Items.Clear();
            cmbCustomerName.Text = "";
            txtCustomerCompany.Clear();
            txtCustomerEmail.Clear();
            txtCustomerPhone.Clear();
            lblCustomerIdLabel.Visible = false;
            lblCustomerId.Visible = false;
            gbCustomerInfo.Enabled = true;
        }

        private bool _needUpdate = true;//used to verify if the items list on combobox needs to be updated.
        private void cmbCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (Tag != null) return;

            if (cmbCustomerName.Text.Trim().Length < 4) _needUpdate = true;

            if (cmbCustomerName.Text.Trim().Length < 4 || !_needUpdate) return;

            var searchParam = cmbCustomerName.Text.Trim();
            
            cmbCustomerName.Items.Clear();
            var customers = _customerService.GetMatchingCustomers(searchParam);
            if (customers.Count < 1) //If my customer query didn't return anything, I dont need to query everytime the text changes
            {
                cmbCustomerName.Text = searchParam; //These 3 lines are to avoid the writen text being deleted
                cmbCustomerName.SelectionStart = searchParam.Length;
                cmbCustomerName.SelectionLength = 0;
                _needUpdate = false;
                return;
            }

            foreach (var cust in customers) cmbCustomerName.Items.Add(cust);
            _needUpdate = false; //After I load my items to the list, I dont need to updated again, unless the text is cleared.

            cmbCustomerName.ValueMember = "Id";
            cmbCustomerName.DisplayMember = "Name";
            cmbCustomerName.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbCustomerName.DroppedDown = true;
            Cursor.Current = Cursors.Default;
            cmbCustomerName.Text = searchParam; //These 3 lines are to avoid the writen text being deleted and reload the items so it wont crash the app
            cmbCustomerName.SelectionStart = searchParam.Length;
            cmbCustomerName.SelectionLength = 0;
        }

        private void cmbCustomerName_Leave(object sender, EventArgs e)
        {
            if (cmbCustomerName.Items.Count > 0) return;

            lblCustomerNotAdded.Visible = true;
            btnAddCustomer.Visible = true;
            txtCustomerCompany.Clear();
            txtCustomerEmail.Clear();
            txtCustomerPhone.Clear();
            lblCustomerIdLabel.Visible = false;
            lblCustomerId.Visible = false;
        }

        private void cmbCustomerName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selectedCustomer = cmbCustomerName.SelectedItem as Customer;
            if (selectedCustomer is null) return;

            txtCustomerCompany.Text = selectedCustomer.Company;
            txtCustomerEmail.Text = selectedCustomer.Email;
            txtCustomerPhone.Text = selectedCustomer.PhoneNumber;
            lblCustomerIdLabel.Visible = true;
            lblCustomerId.Visible = true;
            lblCustomerId.Text = selectedCustomer.Id.ToString();

            lblCustomerNotAdded.Visible = false;
            btnAddCustomer.Visible = false;
            txtProductSearch.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //This method is used to mimick tab key as the enter key for comboCustomer
            if (this.cmbCustomerName.DroppedDown && keyData == Keys.Tab)
            {
                SendKeys.Send("{ENTER}");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (!ValidCustomerInfo()) return;

            var customer = new Customer
            {
                Name = cmbCustomerName.Text.Trim(),
                Company = txtCustomerCompany.Text.Trim(),
                PhoneNumber=txtCustomerPhone.Text.Trim(),
                Email=txtCustomerEmail.Text.Trim()
            };

            var response = _customerService.Add(customer);

            if (response.IsSuccessful)
            {
                MessageBox.Show("Cliente Agregado", "COTIX");
                SelectAddedCustomer(response.ResultObject);
                txtProductSearch.Focus();
            }
            else
            {
                MessageBox.Show($"Error al agregar el cliente\nError:{response.ErrorMessage}", "COTIX", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private bool ValidCustomerInfo()
        {
            if (cmbCustomerName.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el NOMBRE del cliente", "COTIX", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            if (txtCustomerCompany.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la COMPAÑIA del cliente", "COTIX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtCustomerPhone.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un TELEFONO del cliente", "COTIX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void SelectAddedCustomer(Customer customer)
        {
            cmbCustomerName.Items.Clear();
            cmbCustomerName.Items.Add(customer);

            cmbCustomerName.ValueMember = "Id";
            cmbCustomerName.DisplayMember = "Name";
            cmbCustomerName.SelectedItem = customer;
            cmbCustomerName_SelectionChangeCommitted(new object() , new EventArgs());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Run Mandatory info validations
            if (!ValidQuotationInfo()) return;

            //Run warning info validations (date & transportation cost)

            //Collect information
            var quotation = Tag as Quotation ?? new Quotation();

            var customerId = Convert.ToInt32(lblCustomerId.Text);
            quotation.Customer = _customerService.GetById(customerId);
            quotation.ValidUntil = dtpValidUntil.Value;

            quotation.Details.Clear();
            foreach (DataGridViewRow row in dgvQuotationDetails.Rows)
            {
                quotation.Details.Add(new QuotationDetail
                {
                    Product = _productService.GetById(Convert.ToInt32(row.Cells["ProductId"].Value)),
                    Quantity = Convert.ToInt32(row.Cells["QuotationQty"].Value),
                    Amount = Convert.ToDecimal(row.Cells["PriceTotal"].Value.ToString().Replace("$",""))
                }) ;
            }

            if (txtTransportationCost.Visible)
            {
                quotation.TransportationFee = Convert.ToDecimal(txtTransportationCost.Text);
            }

            quotation.SubTotal = QuotationSubTotal;
            quotation.Total = QuotationTotal;

            //Save Quotation
            var response = Tag==null? _quotationService.Add(quotation):_quotationService.Update(quotation);

            if (response.IsSuccessful)
            {
                MessageBox.Show("Cotizacion guardada","COTIX",MessageBoxButtons.OK,MessageBoxIcon.Information);

                //Display Quotation info & handle appropiate controls enabling/disabling
                gbCustomerInfo.Enabled = false;

                lblQuotationNumberLabel.Visible = true;
                lblQuotationNumber.Visible = true;
                lblQuotationNumber.Text = response.ResultObject.Id.ToString();
                txtDaysValid.Text = ((response.ResultObject.ValidUntil - response.ResultObject.CreatedAt).Days + 1).ToString();

                btnExportPDF.Enabled = true;

                EnableSave(false);
                Tag = response.ResultObject;
            }
            else
            {
                MessageBox.Show($"Error al guardar la cotizacion\nError:{response.ErrorMessage}","COTIX",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private bool ValidQuotationInfo()
        {
            if (gbCustomerInfo.Enabled && cmbCustomerName.Items.Count < 1)
            {
                MessageBox.Show("Debe REGISTRAR EL CLIENTE antes de guardar la cotizacion", "COTIX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dgvQuotationDetails.Rows.Count < 1)
            {
                MessageBox.Show("Debe AGREGAR PRODUCTOS antes de guardar la cotizacion", "COTIX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void EnableSave(bool value)
        {
            if (lblQuotationNumber.Visible) btnSave.Enabled = value;
        }

        private void dtpValidUntil_ValueChanged(object sender, EventArgs e)
        {
            EnableSave(true);
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            using (frmReportViewer f = new frmReportViewer(Tag as Quotation))
            {
                f.ShowDialog();
            }
        }
    }
}