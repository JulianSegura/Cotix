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
        //ToDo: Add a clear/cancel button
        public frmQuotationDetail()
        {
            InitializeComponent();
        }

        private void chkAddTransportation_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddTransportation.Checked) txtTransportationCost.Visible = true;
            else txtTransportationCost.Visible = false;
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
            dtpValidUntil.MinDate = DateTime.Today;
        }
    }
}
