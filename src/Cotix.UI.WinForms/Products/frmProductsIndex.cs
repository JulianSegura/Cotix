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
    public partial class frmProductsIndex : BaseForm
    {
        public frmProductsIndex()
        {
            InitializeComponent();
        }



        private void btnNew_Click(object sender, EventArgs e)
        {
            using(frmProductDetails productForm= new frmProductDetails())
            {
                productForm.ShowDialog();
            }
        }

        private void frmProductsIndex_Load(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvDetails);
            row.SetValues("1", "ProductCode", "Especificacion", "Descripcion un poco larga del producto", "1500:d", "c:/eso/eso", null, true);
            dgvDetails.Rows.Add(row);
        }
    }
}
