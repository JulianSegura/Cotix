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
        public frmQuotationsIndex()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (frmQuotationDetail f=new frmQuotationDetail())
            {
                f.ShowDialog();
            }
        }
    }
}
