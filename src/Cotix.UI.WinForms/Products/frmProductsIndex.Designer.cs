
namespace Cotix.UI.WinForms.Products
{
    partial class frmProductsIndex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PicturePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.Disabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProductCode,
            this.Specification,
            this.Description,
            this.Price,
            this.PicturePath,
            this.Picture,
            this.Disabled,
            this.Edit,
            this.Delete});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1064, 559);
            this.dataGridView1.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ProductCode
            // 
            this.ProductCode.HeaderText = "Codigo";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            // 
            // Specification
            // 
            this.Specification.HeaderText = "Especificacion";
            this.Specification.Name = "Specification";
            this.Specification.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Descripcion";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Precio";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // PicturePath
            // 
            this.PicturePath.HeaderText = "PicturePath";
            this.PicturePath.Name = "PicturePath";
            this.PicturePath.ReadOnly = true;
            this.PicturePath.Visible = false;
            // 
            // Picture
            // 
            this.Picture.HeaderText = "Foto";
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            // 
            // Disabled
            // 
            this.Disabled.HeaderText = "Activo";
            this.Disabled.Name = "Disabled";
            this.Disabled.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Editar";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Eliminar";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // frmProductsIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 602);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmProductsIndex";
            this.Tag = "MAESTRO DE PRODUCTOS";
            this.Text = "frmProductsIndex";
            this.Controls.SetChildIndex(this.pnlMenu, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specification;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn PicturePath;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Disabled;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}