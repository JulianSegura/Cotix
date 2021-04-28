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
        private readonly UnitOfWork UoW = new UnitOfWork();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            OpenQuotationForm();
        }

        private void OpenQuotationForm()
        {
            var childForm = pnlBody.Controls.OfType<frmQuotationsIndex>().FirstOrDefault();

            if (childForm == null)
            {
                childForm = new frmQuotationsIndex(UoW)
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                    TopMost = false
                };

                pnlBody.Controls.Add(childForm);
                childForm.Show();
            }
            childForm.BringToFront();
        }

        private void btnQuotations_Click(object sender, EventArgs e)
        {
            OpenQuotationForm();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenProductsForm();
        }

        private void OpenProductsForm()
        {
            var childForm = pnlBody.Controls.OfType<frmProductsIndex>().FirstOrDefault();

            if (childForm == null)
            {
                childForm = new frmProductsIndex(UoW)
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                    TopMost = false
                };

                pnlBody.Controls.Add(childForm);
                childForm.Show();
            }
            childForm.BringToFront();
        }

        //private void OpenForm<F>() where F : BaseForm, new()
        //{

        //    var childForm = pnlBody.Controls.OfType<F>().FirstOrDefault();

        //    if (childForm == null)
        //    {
        //        childForm = new F()
        //        {
        //            TopLevel = false,
        //            Dock = DockStyle.Fill,
        //            TopMost = false
        //        };

        //        pnlBody.Controls.Add(childForm);
        //        childForm.Show();
        //    }
        //    childForm.BringToFront();
        //}
    }
}
