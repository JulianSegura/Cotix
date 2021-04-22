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

namespace Cotix.UI.WinForms.Products
{
    public partial class frmProductDetails : Form
    {
        private readonly ProductsService _productService;
        public frmProductDetails()
        {
            InitializeComponent();
            _productService = new ProductsService(new UnitOfWork());
        }

        private void pbProductPicture_MouseEnter(object sender, EventArgs e)
        {
            lblChangePicture.Visible = true;
            lblChangePicture.Cursor = Cursors.Hand;
        }

        private void pbProductPicture_MouseLeave(object sender, EventArgs e)
        {
            lblChangePicture.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CleanForm();
            txtProductCode.Focus();
        }

        private void CleanForm()
        {
            txtProductCode.Clear();
            txtSpecification.Clear();
            txtDescription.Clear();
            txtCost.Clear();
            txtPrice.Clear();
            chkDisable.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.Tag == null) AddProduct();
            else UpdateProduct((Product)this.Tag);
        }

        private void AddProduct()
        {
            //ToDo: Validar los campos antes de crear el objeto a guardar
            //ToDo: Validar solo numeros en el keypress de los textbox
            var product = new Product
            {
                Code = txtProductCode.Text.Trim().ToUpper(),
                Description = txtDescription.Text.Trim().ToUpper(),
                Specification = txtSpecification.Text.Trim().ToUpper(),
                Cost = decimal.Parse(txtCost.Text.Trim()),
                Price = decimal.Parse(txtCost.Text.Trim())
            };

            if (_productService.Add(product).Id > 0)
            {
                MessageBox.Show("Producto Agregado Exitosamente");
                return;
            }
            MessageBox.Show("Error Al Agregar El Producto");
        }

        //ToDo: Tener pendiente que el producto viene en el Tag desde el form principal
        private void UpdateProduct(Product product)
        {

        }
    }
}
