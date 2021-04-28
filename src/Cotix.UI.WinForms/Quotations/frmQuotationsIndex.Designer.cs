
namespace Cotix.UI.WinForms.Quotations
{
    partial class frmQuotationsIndex
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.cmbFilterDate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.QuotationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysValid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidUntil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuotationSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuotationTransportation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuotationTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRunningForm
            // 
            this.lblRunningForm.Size = new System.Drawing.Size(144, 25);
            this.lblRunningForm.Text = "COTIZACIONES";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.label4);
            this.pnlMenu.Controls.Add(this.dtpDateTo);
            this.pnlMenu.Controls.Add(this.dtpDateFrom);
            this.pnlMenu.Controls.Add(this.label3);
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Controls.Add(this.cmbFilterDate);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.SetChildIndex(this.lblRunningForm, 0);
            this.pnlMenu.Controls.SetChildIndex(this.btnNew, 0);
            this.pnlMenu.Controls.SetChildIndex(this.btnEdit, 0);
            this.pnlMenu.Controls.SetChildIndex(this.btnDelete, 0);
            this.pnlMenu.Controls.SetChildIndex(this.btnSeach, 0);
            this.pnlMenu.Controls.SetChildIndex(this.label1, 0);
            this.pnlMenu.Controls.SetChildIndex(this.cmbFilterDate, 0);
            this.pnlMenu.Controls.SetChildIndex(this.label2, 0);
            this.pnlMenu.Controls.SetChildIndex(this.label3, 0);
            this.pnlMenu.Controls.SetChildIndex(this.dtpDateFrom, 0);
            this.pnlMenu.Controls.SetChildIndex(this.dtpDateTo, 0);
            this.pnlMenu.Controls.SetChildIndex(this.label4, 0);
            this.pnlMenu.Controls.SetChildIndex(this.txtSearch, 0);
            // 
            // btnSeach
            // 
            this.btnSeach.FlatAppearance.BorderSize = 0;
            this.btnSeach.Location = new System.Drawing.Point(675, 24);
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Location = new System.Drawing.Point(229, 26);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.Location = new System.Drawing.Point(193, 26);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.Location = new System.Drawing.Point(157, 26);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(723, 24);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Size = new System.Drawing.Size(338, 29);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(464, 24);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(102, 29);
            this.dtpDateFrom.TabIndex = 14;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(572, 24);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(102, 29);
            this.dtpDateTo.TabIndex = 15;
            this.dtpDateTo.ValueChanged += new System.EventHandler(this.dtpDateTo_ValueChanged);
            // 
            // cmbFilterDate
            // 
            this.cmbFilterDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilterDate.FormattingEnabled = true;
            this.cmbFilterDate.Location = new System.Drawing.Point(315, 24);
            this.cmbFilterDate.Name = "cmbFilterDate";
            this.cmbFilterDate.Size = new System.Drawing.Size(143, 29);
            this.cmbFilterDate.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Fecha A Filtrar";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(461, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(572, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(722, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Buscar Por Nombre De Cliente";
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuotationId,
            this.CustomerName,
            this.DaysValid,
            this.CreatedAt,
            this.ValidUntil,
            this.QuotationSubTotal,
            this.QuotationTransportation,
            this.QuotationTotal});
            this.dgvDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetails.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.EnableHeadersVisualStyles = false;
            this.dgvDetails.Location = new System.Drawing.Point(0, 59);
            this.dgvDetails.MultiSelect = false;
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvDetails.RowHeadersWidth = 15;
            this.dgvDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.Size = new System.Drawing.Size(1064, 543);
            this.dgvDetails.TabIndex = 3;
            // 
            // QuotationId
            // 
            this.QuotationId.HeaderText = "# Cotizacion";
            this.QuotationId.Name = "QuotationId";
            this.QuotationId.ReadOnly = true;
            this.QuotationId.Width = 119;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Cliente";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 82;
            // 
            // DaysValid
            // 
            this.DaysValid.HeaderText = "Dias De Validez";
            this.DaysValid.Name = "DaysValid";
            this.DaysValid.ReadOnly = true;
            this.DaysValid.Width = 140;
            // 
            // CreatedAt
            // 
            dataGridViewCellStyle12.Format = "D";
            dataGridViewCellStyle12.NullValue = null;
            this.CreatedAt.DefaultCellStyle = dataGridViewCellStyle12;
            this.CreatedAt.HeaderText = "CreatedAt";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            this.CreatedAt.Visible = false;
            this.CreatedAt.Width = 103;
            // 
            // ValidUntil
            // 
            dataGridViewCellStyle13.Format = "D";
            dataGridViewCellStyle13.NullValue = null;
            this.ValidUntil.DefaultCellStyle = dataGridViewCellStyle13;
            this.ValidUntil.HeaderText = "Valida Hasta";
            this.ValidUntil.Name = "ValidUntil";
            this.ValidUntil.ReadOnly = true;
            this.ValidUntil.Width = 119;
            // 
            // QuotationSubTotal
            // 
            this.QuotationSubTotal.HeaderText = "Sub Total";
            this.QuotationSubTotal.Name = "QuotationSubTotal";
            this.QuotationSubTotal.ReadOnly = true;
            this.QuotationSubTotal.Width = 97;
            // 
            // QuotationTransportation
            // 
            this.QuotationTransportation.HeaderText = "Flete";
            this.QuotationTransportation.Name = "QuotationTransportation";
            this.QuotationTransportation.ReadOnly = true;
            this.QuotationTransportation.Width = 67;
            // 
            // QuotationTotal
            // 
            this.QuotationTotal.HeaderText = "Total";
            this.QuotationTotal.Name = "QuotationTotal";
            this.QuotationTotal.ReadOnly = true;
            this.QuotationTotal.Width = 66;
            // 
            // frmQuotationsIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 602);
            this.Controls.Add(this.dgvDetails);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frmQuotationsIndex";
            this.Text = "frmQuotationsIndex";
            this.Load += new System.EventHandler(this.frmQuotationsIndex_Load);
            this.Controls.SetChildIndex(this.pnlMenu, 0);
            this.Controls.SetChildIndex(this.dgvDetails, 0);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFilterDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuotationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysValid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidUntil;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuotationSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuotationTransportation;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuotationTotal;
    }
}