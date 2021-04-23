
namespace Cotix.UI.WinForms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlMainControls = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnQuotations = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlMainControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainControls
            // 
            this.pnlMainControls.BackColor = System.Drawing.Color.White;
            this.pnlMainControls.Controls.Add(this.btnSettings);
            this.pnlMainControls.Controls.Add(this.btnCustomers);
            this.pnlMainControls.Controls.Add(this.btnProducts);
            this.pnlMainControls.Controls.Add(this.btnQuotations);
            this.pnlMainControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainControls.Location = new System.Drawing.Point(0, 0);
            this.pnlMainControls.Name = "pnlMainControls";
            this.pnlMainControls.Size = new System.Drawing.Size(1064, 82);
            this.pnlMainControls.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::Cotix.UI.WinForms.Properties.Resources.process_accept_32by32;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSettings.Location = new System.Drawing.Point(546, 11);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(168, 65);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Configuracion";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Teal;
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Image = global::Cotix.UI.WinForms.Properties.Resources.international_consumer;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCustomers.Location = new System.Drawing.Point(368, 11);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(160, 65);
            this.btnCustomers.TabIndex = 2;
            this.btnCustomers.Text = "Clientes";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomers.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.DarkCyan;
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Image = global::Cotix.UI.WinForms.Properties.Resources.boxes;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnProducts.Location = new System.Drawing.Point(190, 11);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(160, 65);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Productos";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnQuotations
            // 
            this.btnQuotations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnQuotations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuotations.FlatAppearance.BorderSize = 0;
            this.btnQuotations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuotations.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuotations.ForeColor = System.Drawing.Color.White;
            this.btnQuotations.Image = global::Cotix.UI.WinForms.Properties.Resources.accountingSmall;
            this.btnQuotations.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnQuotations.Location = new System.Drawing.Point(12, 11);
            this.btnQuotations.Name = "btnQuotations";
            this.btnQuotations.Size = new System.Drawing.Size(160, 65);
            this.btnQuotations.TabIndex = 0;
            this.btnQuotations.Text = "Cotizaciones";
            this.btnQuotations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuotations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQuotations.UseVisualStyleBackColor = false;
            this.btnQuotations.Click += new System.EventHandler(this.btnQuotations_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 82);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1064, 599);
            this.pnlBody.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlMainControls);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COTIX";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMainControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainControls;
        private System.Windows.Forms.Button btnQuotations;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Panel pnlBody;
    }
}

