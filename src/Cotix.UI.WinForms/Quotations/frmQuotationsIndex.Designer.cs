
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
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRunningForm
            // 
            this.lblRunningForm.Size = new System.Drawing.Size(144, 25);
            this.lblRunningForm.Text = "COTIZACIONES";
            // 
            // btnSeach
            // 
            this.btnSeach.FlatAppearance.BorderSize = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Location = new System.Drawing.Point(229, 26);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.Location = new System.Drawing.Point(193, 26);
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.Location = new System.Drawing.Point(157, 26);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // frmQuotationsIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 602);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frmQuotationsIndex";
            this.Text = "frmQuotationsIndex";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}