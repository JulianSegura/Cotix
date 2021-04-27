﻿using Cotix.AppLayer;
using Cotix.Domain.Entities;
using Cotix.Infrastructure;
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
        private readonly ProductsService _productService;

        public frmProductsIndex()
        {
            InitializeComponent();
            _productService = new ProductsService(new UnitOfWork());
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using(frmProductDetails f= new frmProductDetails(_productService))
            {
                //ToDo: Add delegate to subscribe to f's added product. So I can show it in the main form
                f.ShowDialog();

                if (f.Tag is null) return;
                var result = (bool)f.Tag;
                if (result) FillProductsDatagrid(_productService.GetAll());
            }
        }

        private void frmProductsIndex_Load(object sender, EventArgs e)
        {
            FillProductsDatagrid(_productService.GetAll());
        }

        private void FillProductsDatagrid(ICollection<Product> products)
        {
            dgvDetails.Rows.Clear();
            foreach (var product in products)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvDetails);
                var picture = product.PicturePath != "" ? new Bitmap(new Bitmap(product.PicturePath), 128, 128) : new Bitmap(Properties.Resources.boxes, 128, 128);
                row.SetValues(product.Id, product.Code, product.Specification, product.Description, $"{product.Price:C}", product.PicturePath, picture, !product.Disabled);
                dgvDetails.Rows.Add(row);
            }

            dgvDetails.ClearSelection();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDetails.SelectedRows.Count < 1)
            {
                MessageBox.Show("Seleccionar Un Producto Para Editar", "COTIX");
                return;
            }

            using (frmProductDetails f= new frmProductDetails(_productService))
            {
                f.Tag = _productService.GetById((int)dgvDetails.SelectedRows[0].Cells["Id"].Value);
                f.ShowDialog();
                if (f.Tag.GetType() != typeof(bool)) return;
                var result = (bool)f.Tag;
                if (result) FillProductsDatagrid(_productService.GetAll());
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //Verify anything selected on datagrid
            if (dgvDetails.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe Seleccionar Un Producto A Borrar","COTIX");
                return;
            }

            //ToDo: Verify if product is added to any quotation
            //Case true: Notify and offer to Disable//Exception #547 is foreign key delete constraint
            //Case false: Delete from DB 
            var productId = (int)dgvDetails.SelectedRows[0].Cells["Id"].Value;
            var response = _productService.Delete(productId);

            if (!response.IsSuccessful)
            {
                MessageBox.Show("Test");
            }
        }

        private void dgvDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                using (var f=new frmPictureViewer())
                {
                    f.Tag = dgvDetails.Rows[e.RowIndex].Cells["PicturePath"].Value;
                    f.ShowDialog();
                }
            }
        }

        private bool gridFiltered;
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Verify text length if datagridview is not filtered
            if (!gridFiltered && txtSearch.Text.Trim().Length < 4) return;

            //Show all rows in case the textbox is les than 4
            if (gridFiltered && txtSearch.Text.Trim().Length < 4)
            {
                foreach (DataGridViewRow row in dgvDetails.Rows) row.Visible = true;
                gridFiltered = false;
                return;
            }

            string searchParam = txtSearch.Text.Trim().ToUpper();

            //Search by product code or by product description. 
            //If the seachParam is not in the product code or description I make the row invisible
            //that way I dont need to go the the database
            //ToDo: Test this functionality in an extention method fof the datagrid view class
            foreach (DataGridViewRow row in dgvDetails.Rows)
            {
                row.Visible = true;
                var productCode = row.Cells["ProductCode"].Value.ToString().ToUpper();
                var productDesc = row.Cells["Description"].Value.ToString().ToUpper();
                if (!productCode.Contains(searchParam) && !productDesc.Contains(searchParam)) row.Visible = false;

                gridFiltered = true;
            }
        }
    }
}
