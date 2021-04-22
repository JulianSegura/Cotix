using Cotix.AppLayer;
using Cotix.Domain.Entities;
using Cotix.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(pbProductPicture, "Doble Click Para Cambiar La Imagen");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Check the Tag to verify if the form was opened with an update request.
            if (Tag != null)
            {
                Close();
                Dispose();
                return;
            }
            CleanForm();
            txtProductCode.Focus();
        }

        private void CleanForm()
        {
            txtProductCode.Enabled = true;
            txtProductCode.Clear();
            txtSpecification.Clear();
            txtDescription.Clear();
            txtCost.Clear();
            txtPrice.Clear();
            chkDisable.Checked = true;
            pbProductPicture.Image = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.Tag == null) AddProduct();
            else UpdateProduct((Product)this.Tag);
            //ToDo: Tener pendiente que el producto viene en el Tag desde el form principal
            //ToDo: Inactivar el codigo de producto al actualizar (en el load)
        }

        private void AddProduct()
        {
            if (EmptyFields()) return;

            var product = new Product
            {
                Code = txtProductCode.Text.Trim().ToUpper(),
                Description = txtDescription.Text.Trim().ToUpper(),
                Specification = txtSpecification.Text.Trim().ToUpper(),
                Cost = txtCost.Text.Trim() != "" ? decimal.Parse(txtCost.Text.Trim()) : 0,
                Price = txtPrice.Text.Trim() != "" ? decimal.Parse(txtPrice.Text.Trim()) : 0,
                PicturePath = pbProductPicture.ImageLocation
            };

            var result = _productService.Add(product);

            if (result.IsSuccessful)
            {
                //ToDo: Save product picture
                MessageBox.Show("Producto Agregado Exitosamente");
                return;
            }
            MessageBox.Show($"Error Al Agregar El Producto\nError: {result.ErrorMessage}");
        }

        private void UpdateProduct(Product product)
        {
            if (EmptyFields()) return;

            product.Description = txtDescription.Text.Trim();
            product.Specification = txtSpecification.Text.Trim();
            product.Cost = txtCost.Text.Trim() != "" ? decimal.Parse(txtCost.Text.Trim()) : 0;
            product.Price = txtPrice.Text.Trim() != "" ? decimal.Parse(txtPrice.Text.Trim()) : 0;
            //ToDo: Compare if picture path changed
            product.PicturePath = pbProductPicture.ImageLocation;
            product.Disabled = !chkDisable.Checked;

            var result = _productService.Update(product);

            if (result.IsSuccessful)
            {
                //ToDo: Save product picture if changed
                MessageBox.Show("Producto Actualizado Exitosamente");
                return;
            }
            MessageBox.Show($"Error Al Actualizar El Producto\nError: {result.ErrorMessage}");
        }

        private bool HandleKey(ref TextBox textbox, char keycode)
        {
            if (keycode == '.' && textbox.Text.Trim().Length == 0) return true;

            if (keycode == '.' && textbox.Text.Contains(".")) return true;

            return (!char.IsDigit(keycode) && keycode != '.' && keycode != (char)Keys.Back);
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = HandleKey(ref txtCost, e.KeyChar);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = HandleKey(ref txtPrice, e.KeyChar);
        }

        private bool EmptyFields()
        {
            if (txtProductCode.Text.Trim() == "")
            {
                MessageBox.Show("El CODIGO DE PRODUCTO no puede estar vacio");
                return true;
            }

            if (txtDescription.Text.Trim() == "")
            {
                MessageBox.Show("La DESCRIPCION no puede estar vacia");
                return true;
            }

            if (txtPrice.Text.Trim() == "")
            {
                MessageBox.Show("El PRECIO DE PRODUCTO no puede estar vacio");
                return true;
            }

            return false;
        }

        private void chkDisable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDisable.Checked) 
            {
                chkDisable.Text = "Habilitado";
                chkDisable.ForeColor = Color.Green;
                return;
            } 
            chkDisable.Text = "Desabilitado";
            chkDisable.ForeColor = Color.Red;
        }

        private void chkDisable_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(chkDisable, "Los productos desabilitados NO SE MUESTRAN para realizar las cotizaciones");
        }

        private void SetPicture()
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Seleccione una imagen";
            opFile.Filter = "Archivos De Imagen| *.jpg; *.jpeg; *.png";

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                pbProductPicture.ImageLocation = opFile.FileName;
            }
        }

        private void pbProductPicture_DoubleClick(object sender, EventArgs e)
        {
            SetPicture();
        }

        private void SavePicture()
        {
            //string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Images\"; 
            //if (Directory.Exists(appPath) == false)                                              
            //{                                                                                    
            //    Directory.CreateDirectory(appPath);                                              
            //}                                                                                    

            //if (opFile.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        string iName = opFile.SafeFileName;   // <---
            //        string filepath = opFile.FileName;    // <---
            //        File.Copy(filepath, appPath + iName); // <---
            //        picProduct.Image = new Bitmap(opFile.OpenFile());
            //    }
            //    catch (Exception exp)
            //    {
            //        MessageBox.Show("Unable to open file " + exp.Message);
            //    }
            //}
            //else
            //{
            //    opFile.Dispose();
            //}
        }
    }
}