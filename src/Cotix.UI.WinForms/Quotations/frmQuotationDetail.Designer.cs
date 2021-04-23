
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuotationDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.chkAddTransportation = new System.Windows.Forms.CheckBox();
            this.txtTransportationCost = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvQuotationDetails = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnProductSeach = new System.Windows.Forms.Button();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpValidUntil = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.lblValidTime = new System.Windows.Forms.Label();
            this.lblQuotationNumber = new System.Windows.Forms.Label();
            this.lblQuotationNumberLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotationDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbCustomerName);
            this.groupBox1.Controls.Add(this.lblCustomerNotAdded);
            this.groupBox1.Controls.Add(this.btnAddCustomer);
            this.groupBox1.Controls.Add(this.txtCustomerEmail);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtCustomerPhone);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCustomerCompany);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblCustomerNotAdded
            // 
            this.lblCustomerNotAdded.AutoSize = true;
            this.lblCustomerNotAdded.ForeColor = System.Drawing.Color.Red;
            this.lblCustomerNotAdded.Location = new System.Drawing.Point(288, 130);
            this.lblCustomerNotAdded.Name = "lblCustomerNotAdded";
            this.lblCustomerNotAdded.Size = new System.Drawing.Size(102, 13);
            this.lblCustomerNotAdded.TabIndex = 22;
            this.lblCustomerNotAdded.Text = "Cliente no agregado";
            this.lblCustomerNotAdded.Visible = false;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(260, 146);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(145, 25);
            this.btnAddCustomer.TabIndex = 21;
            this.btnAddCustomer.Text = "Agregar";
            this.btnAddCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Visible = false;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(102, 104);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(303, 20);
            this.txtCustomerEmail.TabIndex = 20;
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
            this.txtCustomerPhone.Size = new System.Drawing.Size(303, 20);
            this.txtCustomerPhone.TabIndex = 18;
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
            this.txtCustomerCompany.Size = new System.Drawing.Size(303, 20);
            this.txtCustomerCompany.TabIndex = 14;
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
            // chkAddTransportation
            // 
            this.chkAddTransportation.AutoSize = true;
            this.chkAddTransportation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddTransportation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkAddTransportation.Location = new System.Drawing.Point(460, 438);
            this.chkAddTransportation.Name = "chkAddTransportation";
            this.chkAddTransportation.Size = new System.Drawing.Size(102, 17);
            this.chkAddTransportation.TabIndex = 11;
            this.chkAddTransportation.Text = "Agregar Flete";
            this.chkAddTransportation.UseVisualStyleBackColor = true;
            this.chkAddTransportation.CheckedChanged += new System.EventHandler(this.chkAddTransportation_CheckedChanged);
            // 
            // txtTransportationCost
            // 
            this.txtTransportationCost.Location = new System.Drawing.Point(460, 456);
            this.txtTransportationCost.Name = "txtTransportationCost";
            this.txtTransportationCost.Size = new System.Drawing.Size(143, 20);
            this.txtTransportationCost.TabIndex = 10;
            this.txtTransportationCost.Visible = false;
            this.txtTransportationCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTransportationCost_KeyPress);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProductCode,
            this.Specification,
            this.Price,
            this.Picture,
            this.Add});
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.Location = new System.Drawing.Point(12, 252);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(442, 280);
            this.dgvProducts.TabIndex = 1;
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
            this.ProductCode.Width = 64;
            // 
            // Specification
            // 
            this.Specification.HeaderText = "Especificacion";
            this.Specification.Name = "Specification";
            this.Specification.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Precio";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 61;
            // 
            // Picture
            // 
            this.Picture.HeaderText = "Foto";
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            this.Picture.Width = 33;
            // 
            // Add
            // 
            this.Add.HeaderText = "Agregar";
            this.Add.Name = "Add";
            this.Add.ReadOnly = true;
            this.Add.Width = 49;
            // 
            // dgvQuotationDetails
            // 
            this.dgvQuotationDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuotationDetails.Location = new System.Drawing.Point(460, 45);
            this.dgvQuotationDetails.Name = "dgvQuotationDetails";
            this.dgvQuotationDetails.Size = new System.Drawing.Size(605, 387);
            this.dgvQuotationDetails.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(709, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "$99,999,999.99";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(666, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(709, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "$99,999,999.99";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(647, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sub Total:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(918, 438);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 97);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.BackColor = System.Drawing.Color.Transparent;
            this.btnExportPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportPDF.FlatAppearance.BorderSize = 0;
            this.btnExportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPDF.ForeColor = System.Drawing.Color.White;
            this.btnExportPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnExportPDF.Image")));
            this.btnExportPDF.Location = new System.Drawing.Point(1025, 438);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(40, 46);
            this.btnExportPDF.TabIndex = 12;
            this.btnExportPDF.UseVisualStyleBackColor = false;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.FlatAppearance.BorderSize = 0;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.Location = new System.Drawing.Point(1025, 489);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(40, 46);
            this.btnExportExcel.TabIndex = 13;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            // 
            // btnProductSeach
            // 
            this.btnProductSeach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductSeach.BackColor = System.Drawing.Color.Gainsboro;
            this.btnProductSeach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductSeach.FlatAppearance.BorderSize = 0;
            this.btnProductSeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductSeach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductSeach.ForeColor = System.Drawing.Color.White;
            this.btnProductSeach.Image = ((System.Drawing.Image)(resources.GetObject("btnProductSeach.Image")));
            this.btnProductSeach.Location = new System.Drawing.Point(420, 226);
            this.btnProductSeach.Name = "btnProductSeach";
            this.btnProductSeach.Size = new System.Drawing.Size(34, 20);
            this.btnProductSeach.TabIndex = 15;
            this.btnProductSeach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductSeach.UseVisualStyleBackColor = false;
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductSearch.Location = new System.Drawing.Point(12, 226);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(405, 20);
            this.txtProductSearch.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(709, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "$99,999,999.99";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(666, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Flete :";
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(102, 25);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(303, 21);
            this.cmbCustomerName.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(6, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Id Cliente";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label13.Location = new System.Drawing.Point(99, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 18);
            this.label13.TabIndex = 25;
            this.label13.Text = "IDCliente";
            // 
            // dtpValidUntil
            // 
            this.dtpValidUntil.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValidUntil.Location = new System.Drawing.Point(537, 19);
            this.dtpValidUntil.Name = "dtpValidUntil";
            this.dtpValidUntil.Size = new System.Drawing.Size(132, 20);
            this.dtpValidUntil.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(457, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Valida Hasta";
            // 
            // lblValidTime
            // 
            this.lblValidTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblValidTime.Location = new System.Drawing.Point(844, 25);
            this.lblValidTime.Name = "lblValidTime";
            this.lblValidTime.Size = new System.Drawing.Size(221, 13);
            this.lblValidTime.TabIndex = 27;
            this.lblValidTime.Text = "La cotizacion es valida por X dias";
            // 
            // lblQuotationNumber
            // 
            this.lblQuotationNumber.AutoSize = true;
            this.lblQuotationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuotationNumber.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblQuotationNumber.Location = new System.Drawing.Point(729, 21);
            this.lblQuotationNumber.Name = "lblQuotationNumber";
            this.lblQuotationNumber.Size = new System.Drawing.Size(98, 18);
            this.lblQuotationNumber.TabIndex = 26;
            this.lblQuotationNumber.Text = "#Cotizacion";
            // 
            // lblQuotationNumberLabel
            // 
            this.lblQuotationNumberLabel.AutoSize = true;
            this.lblQuotationNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuotationNumberLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblQuotationNumberLabel.Location = new System.Drawing.Point(687, 21);
            this.lblQuotationNumberLabel.Name = "lblQuotationNumberLabel";
            this.lblQuotationNumberLabel.Size = new System.Drawing.Size(45, 18);
            this.lblQuotationNumberLabel.TabIndex = 28;
            this.lblQuotationNumberLabel.Text = "No : ";
            // 
            // frmQuotationDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1077, 547);
            this.Controls.Add(this.lblQuotationNumberLabel);
            this.Controls.Add(this.lblQuotationNumber);
            this.Controls.Add(this.lblValidTime);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtpValidUntil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProductSeach);
            this.Controls.Add(this.txtProductSearch);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.chkAddTransportation);
            this.Controls.Add(this.txtTransportationCost);
            this.Controls.Add(this.btnExportPDF);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvQuotationDetails);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmQuotationDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles Cotizacion";
            this.Load += new System.EventHandler(this.frmQuotationDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotationDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridView dgvQuotationDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTransportationCost;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.Button btnExportExcel;
        protected internal System.Windows.Forms.Button btnProductSeach;
        protected internal System.Windows.Forms.TextBox txtProductSearch;
        private System.Windows.Forms.CheckBox chkAddTransportation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specification;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpValidUntil;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblValidTime;
        private System.Windows.Forms.Label lblQuotationNumber;
        private System.Windows.Forms.Label lblQuotationNumberLabel;
    }
}