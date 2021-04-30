using Cotix.AppLayer;
using Cotix.Domain.Entities;
using Cotix.Infrastructure;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Cotix.UI.WinForms.Products
{
    public partial class frmProductDetails : Form
    {
        //ToDo: Try saving this on the settings file so i can use it in other forms.
        private readonly string _picturesFolder = @"C:\COTIX\Images\"; //Path.GetDirectoryName(Application.ExecutablePath) + @"\Images\";
        private readonly ProductsService _productService;

        public frmProductDetails(ProductsService service)
        {
            InitializeComponent();
            _productService = service;
        }

        private void pbProductPicture_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(pbProductPicture, "Doble Click Para Cambiar La Imagen");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Tag != null)
            {
                Close();
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
            pbProductPicture.Image = Properties.Resources.Products;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.Tag == null) AddProduct();
            else UpdateProduct((Product)this.Tag);
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
                PicturePath = pbProductPicture.ImageLocation != null ?  PictureDestinationFilePath() : string.Empty
            };

            var result = _productService.Add(product);

            if (result.IsSuccessful)
            {
                if(pbProductPicture.ImageLocation!=null) SavePicture();
                var another=MessageBox.Show("Producto Agregado Exitosamente\nDesea Agregar Otro Producto?","COTIX",buttons:MessageBoxButtons.YesNo);
                if (another != DialogResult.Yes) 
                {
                    Tag = true;
                    Close();
                } 
                CleanForm();
                txtProductCode.Focus();
                return;
            }
            MessageBox.Show($"Error Al Agregar El Producto\nError: {result.ErrorMessage}","COTIX",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void UpdateProduct(Product product)
        {
            if (EmptyFields()) return;

            product.Description = txtDescription.Text.Trim();
            product.Specification = txtSpecification.Text.Trim();
            product.Cost = txtCost.Text.Trim() != "" ? decimal.Parse(txtCost.Text.Trim()) : 0;
            product.Price = txtPrice.Text.Trim() != "" ? decimal.Parse(txtPrice.Text.Trim()) : 0;
            product.Disabled = !chkDisable.Checked;
            bool pictureChanged = false;
            if (product.PicturePath != pbProductPicture.ImageLocation)
            {
                pictureChanged = true;
                product.PicturePath = PictureDestinationFilePath();
            }
            

            var result = _productService.Update(product);

            if (result.IsSuccessful)
            {
                if (pictureChanged) SavePicture();
                MessageBox.Show("Producto Actualizado Exitosamente","COTIX",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Tag = true;
                Close();
                return;
            }
            MessageBox.Show($"Error Al Actualizar El Producto\nError: {result.ErrorMessage}","COTIX",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private bool HandleNotDecimal(ref TextBox textbox, char keycode)
        {
            if (keycode == '.' && textbox.Text.Trim().Length == 0) return true;

            if (keycode == '.' && textbox.Text.Contains(".")) return true;

            return (!char.IsDigit(keycode) && keycode != '.' && keycode != (char)Keys.Back);
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = HandleNotDecimal(ref txtCost, e.KeyChar);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = HandleNotDecimal(ref txtPrice, e.KeyChar);
        }

        private bool EmptyFields()
        {
            if (txtProductCode.Text.Trim() == "")
            {
                MessageBox.Show("El CODIGO DE PRODUCTO no puede estar vacio","COTIX");
                return true;
            }

            if (txtDescription.Text.Trim() == "")
            {
                MessageBox.Show("La DESCRIPCION no puede estar vacia", "COTIX");
                return true;
            }

            if (txtPrice.Text.Trim() == "")
            {
                MessageBox.Show("El PRECIO DE PRODUCTO no puede estar vacio", "COTIX");
                return true;
            }

            return false;
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
            if (File.Exists(PictureDestinationFilePath())) return;

            if (!Directory.Exists(_picturesFolder)) Directory.CreateDirectory(_picturesFolder);

            File.Copy(pbProductPicture.ImageLocation, PictureDestinationFilePath());
        }

        private string PictureDestinationFilePath()
        {
            var fileToCopy = pbProductPicture.ImageLocation;
            return _picturesFolder + Path.GetFileName(fileToCopy);
        }

        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            if (Tag == null) return;

            txtProductCode.Enabled = false;

            var product = (Product)Tag;

            Fill(product);
        }

        private void Fill(Product product)
        {
            txtProductCode.Text = product.Code;
            ChangeCheckDisabled(!product.Disabled);
            txtDescription.Text = product.Description;
            txtSpecification.Text = product.Specification;
            txtCost.Text = product.Cost.ToString();
            txtPrice.Text = product.Price.ToString();
            pbProductPicture.ImageLocation = product.PicturePath;
        }

        private void ChangeCheckDisabled(bool status)
        {
            if (status == true)
            {
                chkDisable.Checked = true;
                chkDisable.Text = "Habilitado";
                chkDisable.ForeColor = Color.Green;
                return;
            }
            chkDisable.Checked = false;
            chkDisable.Text = "Desabilitado";
            chkDisable.ForeColor = Color.Red;
        }

        private void chkDisable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDisable.Checked)
            {
                ChangeCheckDisabled(true);
                return;
            }
            ChangeCheckDisabled(false);
        }
    }
}