﻿using System;
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
            llbChangePicture.Visible = true;
        }

        private void pbProductPicture_MouseLeave(object sender, EventArgs e)
        {
            llbChangePicture.Visible = false;
        }
    }
}