using Cotix.Infrastructure;
using Cotix.UI.WinForms.Products;
using Cotix.UI.WinForms.Quotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cotix.UI.WinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            OpenForm<frmQuotationsIndex>(); 
        }

        private void OpenForm<F>() where F : BaseForm, new()
        {
            
            var childForm = pnlBody.Controls.OfType<F>().FirstOrDefault();

            if (childForm == null)
            {
                childForm = new F()
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                    TopMost = false
                };
                pnlBody.Controls.Add(childForm);
                childForm.BringToFront();
                childForm.Show();
            }

            childForm.BringToFront();
        }

        private void btnQuotations_Click(object sender, EventArgs e)
        {
            OpenForm<frmQuotationsIndex>();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenForm<frmProductsIndex>();
        }
    }
}
