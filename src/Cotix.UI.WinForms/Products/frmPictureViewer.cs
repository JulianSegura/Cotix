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
    public partial class frmPictureViewer : Form
    {
        public frmPictureViewer()
        {
            InitializeComponent();
        }

        private void frmPictureViewer_Load(object sender, EventArgs e)
        {
            pbPicture.ImageLocation = (string)Tag;
        }
    }
}
