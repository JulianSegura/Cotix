
namespace Cotix.UI.WinForms.Quotations
{
    partial class frmQuotationDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuotationDetail));
            this.gbCustomerInfo = new System.Windows.Forms.GroupBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblCustomerIdLabel = new System.Windows.Forms.Label();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.lblCustomerNotAdded = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustomerCompany = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalTittle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDaysValid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQuotationDetails = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuotationProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuotationPicture = new System.Windows.Forms.DataGridViewImageColumn();
            this.QuotationQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuotationPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtTransportationCost = new System.Windows.Forms.TextBox();
            this.lblQuotationNumberLabel = new System.Windows.Forms.Label();
            this.lblQuotationNumber = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpValidUntil = new System.Windows.Forms.DateTimePicker();
            this.lblTransportationTittle = new System.Windows.Forms.Label();
            this.chkAddTransportation = new System.Windows.Forms.CheckBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotationDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCustomerInfo
            // 
            this.gbCustomerInfo.Controls.Add(this.lblCustomerId);
            this.gbCustomerInfo.Controls.Add(this.lblCustomerIdLabel);
            this.gbCustomerInfo.Controls.Add(this.cmbCustomerName);
            this.gbCustomerInfo.Controls.Add(this.lblCustomerNotAdded);
            this.gbCustomerInfo.Controls.Add(this.btnAddCustomer);
            this.gbCustomerInfo.Controls.Add(this.txtCustomerEmail);
            this.gbCustomerInfo.Controls.Add(this.label11);
            this.gbCustomerInfo.Controls.Add(this.txtCustomerPhone);
            this.gbCustomerInfo.Controls.Add(this.label10);
            this.gbCustomerInfo.Controls.Add(this.label9);
            this.gbCustomerInfo.Controls.Add(this.txtCustomerCompany);
            this.gbCustomerInfo.Controls.Add(this.label8);
            this.gbCustomerInfo.Controls.Add(this.label7);
            this.gbCustomerInfo.Location = new System.Drawing.Point(12, 12);
            this.gbCustomerInfo.Name = "gbCustomerInfo";
            this.gbCustomerInfo.Size = new System.Drawing.Size(442, 186);
            this.gbCustomerInfo.TabIndex = 0;
            this.gbCustomerInfo.TabStop = false;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblCustomerId.Location = new System.Drawing.Point(99, 130);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(76, 18);
            this.lblCustomerId.TabIndex = 25;
            this.lblCustomerId.Text = "IDCliente";
            this.lblCustomerId.Visible = false;
            // 
            // lblCustomerIdLabel
            // 
            this.lblCustomerIdLabel.AutoSize = true;
            this.lblCustomerIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomerIdLabel.Location = new System.Drawing.Point(6, 133);
            this.lblCustomerIdLabel.Name = "lblCustomerIdLabel";
            this.lblCustomerIdLabel.Size = new System.Drawing.Size(51, 13);
            this.lblCustomerIdLabel.TabIndex = 24;
            this.lblCustomerIdLabel.Text = "Id Cliente";
            this.lblCustomerIdLabel.Visible = false;
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(102, 25);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(323, 21);
            this.cmbCustomerName.Sorted = true;
            this.cmbCustomerName.TabIndex = 0;
            this.cmbCustomerName.SelectionChangeCommitted += new System.EventHandler(this.cmbCustomerName_SelectionChangeCommitted);
            this.cmbCustomerName.TextChanged += new System.EventHandler(this.cmbCustomerName_TextChanged);
            this.cmbCustomerName.Leave += new System.EventHandler(this.cmbCustomerName_Leave);
            // 
            // lblCustomerNotAdded
            // 
            this.lblCustomerNotAdded.AutoSize = true;
            this.lblCustomerNotAdded.ForeColor = System.Drawing.Color.Red;
            this.lblCustomerNotAdded.Location = new System.Drawing.Point(308, 130);
            this.lblCustomerNotAdded.Name = "lblCustomerNotAdded";
            this.lblCustomerNotAdded.Size = new System.Drawing.Size(103, 13);
            this.lblCustomerNotAdded.TabIndex = 22;
            this.lblCustomerNotAdded.Text = "Cliente no registrado";
            this.lblCustomerNotAdded.Visible = false;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(280, 146);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(145, 25);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "Guardar";
            this.btnAddCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Visible = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(102, 104);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(323, 20);
            this.txtCustomerEmail.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(9, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Correo";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(102, 78);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(323, 20);
            this.txtCustomerPhone.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(6, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Telefono (s)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(6, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nombre Contacto";
            // 
            // txtCustomerCompany
            // 
            this.txtCustomerCompany.Location = new System.Drawing.Point(102, 52);
            this.txtCustomerCompany.Name = "txtCustomerCompany";
            this.txtCustomerCompany.Size = new System.Drawing.Size(323, 20);
            this.txtCustomerCompany.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(6, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Compañia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(152, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Informacion Del Cliente";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProductCode,
            this.ProductDescription,
            this.Picture,
            this.Price,
            this.Qty,
            this.Add});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.Location = new System.Drawing.Point(7, 43);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(427, 318);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 42;
            // 
            // ProductCode
            // 
            this.ProductCode.HeaderText = "Codigo";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            this.ProductCode.Width = 70;
            // 
            // ProductDescription
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDescription.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductDescription.HeaderText = "Descripcion";
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.ReadOnly = true;
            this.ProductDescription.Width = 98;
            // 
            // Picture
            // 
            this.Picture.HeaderText = "Foto";
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            this.Picture.Width = 37;
            // 
            // Price
            // 
            this.Price.HeaderText = "Precio";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 67;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Qty.DefaultCellStyle = dataGridViewCellStyle3;
            this.Qty.HeaderText = "Cantidad";
            this.Qty.Name = "Qty";
            this.Qty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Qty.Width = 60;
            // 
            // Add
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.Add.DefaultCellStyle = dataGridViewCellStyle4;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.HeaderText = "";
            this.Add.Name = "Add";
            this.Add.ReadOnly = true;
            this.Add.Text = "";
            this.Add.ToolTipText = "Agregar A Cotizacion";
            this.Add.Width = 5;
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductSearch.Location = new System.Drawing.Point(96, 19);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(338, 20);
            this.txtProductSearch.TabIndex = 0;
            this.txtProductSearch.TextChanged += new System.EventHandler(this.txtProductSearch_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(189, -1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Productos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtProductSearch);
            this.groupBox2.Controls.Add(this.dgvProducts);
            this.groupBox2.Location = new System.Drawing.Point(12, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 368);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(4, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Buscar Producto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.lblTotalTittle);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtDaysValid);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dgvQuotationDetails);
            this.groupBox3.Controls.Add(this.txtTransportationCost);
            this.groupBox3.Controls.Add(this.lblQuotationNumberLabel);
            this.groupBox3.Controls.Add(this.lblQuotationNumber);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.dtpValidUntil);
            this.groupBox3.Controls.Add(this.lblTransportationTittle);
            this.groupBox3.Controls.Add(this.chkAddTransportation);
            this.groupBox3.Controls.Add(this.lblSubTotal);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(460, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(635, 523);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(481, 475);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 25);
            this.lblTotal.TabIndex = 32;
            this.lblTotal.Text = "$0.00";
            // 
            // lblTotalTittle
            // 
            this.lblTotalTittle.AutoSize = true;
            this.lblTotalTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalTittle.Location = new System.Drawing.Point(437, 484);
            this.lblTotalTittle.Name = "lblTotalTittle";
            this.lblTotalTittle.Size = new System.Drawing.Size(44, 13);
            this.lblTotalTittle.TabIndex = 31;
            this.lblTotalTittle.Text = "Total :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(212, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 49;
            this.label3.Text = "dias";
            // 
            // txtDaysValid
            // 
            this.txtDaysValid.Location = new System.Drawing.Point(146, 29);
            this.txtDaysValid.Name = "txtDaysValid";
            this.txtDaysValid.Size = new System.Drawing.Size(62, 20);
            this.txtDaysValid.TabIndex = 1;
            this.txtDaysValid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDaysValid.TextChanged += new System.EventHandler(this.txtDaysValid_TextChanged);
            this.txtDaysValid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDaysValid_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(143, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Valida Por";
            // 
            // dgvQuotationDetails
            // 
            this.dgvQuotationDetails.AllowUserToAddRows = false;
            this.dgvQuotationDetails.AllowUserToDeleteRows = false;
            this.dgvQuotationDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvQuotationDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvQuotationDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvQuotationDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQuotationDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuotationDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvQuotationDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuotationDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.QuotationProductCode,
            this.Description,
            this.QuotationPicture,
            this.QuotationQty,
            this.QuotationPrice,
            this.PriceTotal,
            this.DeleteButton});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuotationDetails.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvQuotationDetails.EnableHeadersVisualStyles = false;
            this.dgvQuotationDetails.Location = new System.Drawing.Point(8, 52);
            this.dgvQuotationDetails.MultiSelect = false;
            this.dgvQuotationDetails.Name = "dgvQuotationDetails";
            this.dgvQuotationDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuotationDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvQuotationDetails.RowHeadersVisible = false;
            this.dgvQuotationDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuotationDetails.Size = new System.Drawing.Size(621, 387);
            this.dgvQuotationDetails.TabIndex = 2;
            this.dgvQuotationDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuotationDetails_CellContentClick);
            this.dgvQuotationDetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuotationDetails_CellEndEdit);
            this.dgvQuotationDetails.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvQuotationDetails_CurrentCellDirtyStateChanged);
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Visible = false;
            this.ProductId.Width = 67;
            // 
            // QuotationProductCode
            // 
            this.QuotationProductCode.HeaderText = "Codigo Producto";
            this.QuotationProductCode.Name = "QuotationProductCode";
            this.QuotationProductCode.ReadOnly = true;
            this.QuotationProductCode.Width = 114;
            // 
            // Description
            // 
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Description.DefaultCellStyle = dataGridViewCellStyle8;
            this.Description.HeaderText = "Descripcion";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 98;
            // 
            // QuotationPicture
            // 
            this.QuotationPicture.HeaderText = "Foto";
            this.QuotationPicture.Name = "QuotationPicture";
            this.QuotationPicture.ReadOnly = true;
            this.QuotationPicture.Width = 37;
            // 
            // QuotationQty
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.QuotationQty.DefaultCellStyle = dataGridViewCellStyle9;
            this.QuotationQty.HeaderText = "Cantidad";
            this.QuotationQty.Name = "QuotationQty";
            this.QuotationQty.Width = 81;
            // 
            // QuotationPrice
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.QuotationPrice.DefaultCellStyle = dataGridViewCellStyle10;
            this.QuotationPrice.HeaderText = "Precio Unitatio";
            this.QuotationPrice.Name = "QuotationPrice";
            this.QuotationPrice.ReadOnly = true;
            this.QuotationPrice.Width = 105;
            // 
            // PriceTotal
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PriceTotal.DefaultCellStyle = dataGridViewCellStyle11;
            this.PriceTotal.HeaderText = "Total";
            this.PriceTotal.Name = "PriceTotal";
            this.PriceTotal.ReadOnly = true;
            this.PriceTotal.Width = 60;
            // 
            // DeleteButton
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.DefaultCellStyle = dataGridViewCellStyle12;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.HeaderText = "";
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.ToolTipText = "Remover Producto De Cotizacion";
            this.DeleteButton.Width = 5;
            // 
            // txtTransportationCost
            // 
            this.txtTransportationCost.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransportationCost.Location = new System.Drawing.Point(485, 470);
            this.txtTransportationCost.Name = "txtTransportationCost";
            this.txtTransportationCost.Size = new System.Drawing.Size(117, 25);
            this.txtTransportationCost.TabIndex = 1;
            this.txtTransportationCost.Visible = false;
            this.txtTransportationCost.TextChanged += new System.EventHandler(this.txtTransportationCost_TextChanged);
            this.txtTransportationCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTransportationCost_KeyPress);
            // 
            // lblQuotationNumberLabel
            // 
            this.lblQuotationNumberLabel.AutoSize = true;
            this.lblQuotationNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuotationNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQuotationNumberLabel.Location = new System.Drawing.Point(482, 31);
            this.lblQuotationNumberLabel.Name = "lblQuotationNumberLabel";
            this.lblQuotationNumberLabel.Size = new System.Drawing.Size(45, 18);
            this.lblQuotationNumberLabel.TabIndex = 46;
            this.lblQuotationNumberLabel.Text = "No : ";
            this.lblQuotationNumberLabel.Visible = false;
            // 
            // lblQuotationNumber
            // 
            this.lblQuotationNumber.AutoSize = true;
            this.lblQuotationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuotationNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQuotationNumber.Location = new System.Drawing.Point(524, 31);
            this.lblQuotationNumber.Name = "lblQuotationNumber";
            this.lblQuotationNumber.Size = new System.Drawing.Size(98, 18);
            this.lblQuotationNumber.TabIndex = 44;
            this.lblQuotationNumber.Text = "#Cotizacion";
            this.lblQuotationNumber.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(5, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Valida Hasta";
            // 
            // dtpValidUntil
            // 
            this.dtpValidUntil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpValidUntil.Location = new System.Drawing.Point(8, 28);
            this.dtpValidUntil.Name = "dtpValidUntil";
            this.dtpValidUntil.Size = new System.Drawing.Size(132, 20);
            this.dtpValidUntil.TabIndex = 0;
            this.dtpValidUntil.ValueChanged += new System.EventHandler(this.dtpValidUntil_ValueChanged);
            // 
            // lblTransportationTittle
            // 
            this.lblTransportationTittle.AutoSize = true;
            this.lblTransportationTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransportationTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTransportationTittle.Location = new System.Drawing.Point(438, 475);
            this.lblTransportationTittle.Name = "lblTransportationTittle";
            this.lblTransportationTittle.Size = new System.Drawing.Size(43, 13);
            this.lblTransportationTittle.TabIndex = 40;
            this.lblTransportationTittle.Text = "Flete :";
            this.lblTransportationTittle.Visible = false;
            // 
            // chkAddTransportation
            // 
            this.chkAddTransportation.AutoSize = true;
            this.chkAddTransportation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddTransportation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkAddTransportation.Location = new System.Drawing.Point(8, 445);
            this.chkAddTransportation.Name = "chkAddTransportation";
            this.chkAddTransportation.Size = new System.Drawing.Size(102, 17);
            this.chkAddTransportation.TabIndex = 0;
            this.chkAddTransportation.Text = "Agregar Flete";
            this.chkAddTransportation.UseVisualStyleBackColor = true;
            this.chkAddTransportation.CheckedChanged += new System.EventHandler(this.chkAddTransportation_CheckedChanged);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(481, 445);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(50, 21);
            this.lblSubTotal.TabIndex = 34;
            this.lblSubTotal.Text = "$0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(419, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Sub Total:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(262, -1);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Detalle Cotizacion";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(784, 539);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.Enabled = false;
            this.btnExportExcel.FlatAppearance.BorderSize = 0;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.Location = new System.Drawing.Point(488, 545);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(22, 27);
            this.btnExportExcel.TabIndex = 3;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.MouseEnter += new System.EventHandler(this.BtnExportExcel_MouseEnter);
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.BackColor = System.Drawing.Color.Transparent;
            this.btnExportPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportPDF.Enabled = false;
            this.btnExportPDF.FlatAppearance.BorderSize = 0;
            this.btnExportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPDF.ForeColor = System.Drawing.Color.White;
            this.btnExportPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnExportPDF.Image")));
            this.btnExportPDF.Location = new System.Drawing.Point(460, 544);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(22, 27);
            this.btnExportPDF.TabIndex = 2;
            this.btnExportPDF.UseVisualStyleBackColor = false;
            this.btnExportPDF.MouseEnter += new System.EventHandler(this.btnExportPDF_MouseEnter);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(882, 539);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(213, 32);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmQuotationDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 577);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbCustomerInfo);
            this.Controls.Add(this.btnExportPDF);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmQuotationDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles Cotizacion";
            this.Load += new System.EventHandler(this.frmQuotationDetail_Load);
            this.gbCustomerInfo.ResumeLayout(false);
            this.gbCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotationDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCustomerInfo;
        private System.Windows.Forms.DataGridView dgvProducts;
        protected internal System.Windows.Forms.TextBox txtProductSearch;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustomerCompany;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCustomerNotAdded;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblCustomerIdLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblQuotationNumberLabel;
        private System.Windows.Forms.Label lblQuotationNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpValidUntil;
        private System.Windows.Forms.Label lblTransportationTittle;
        private System.Windows.Forms.CheckBox chkAddTransportation;
        private System.Windows.Forms.TextBox txtTransportationCost;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalTittle;
        private System.Windows.Forms.DataGridView dgvQuotationDetails;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuotationProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewImageColumn QuotationPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuotationQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuotationPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceTotal;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
        private System.Windows.Forms.TextBox txtDaysValid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}