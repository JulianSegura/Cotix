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
        public frmProductDetails()
        {
            InitializeComponent();
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
    }
}
