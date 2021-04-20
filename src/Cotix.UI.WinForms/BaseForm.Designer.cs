
namespace Cotix.UI.WinForms
{
    partial class BaseForm
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
            this.lblBackToMainScreen = new System.Windows.Forms.Label();
            this.btnBackToMainScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBackToMainScreen
            // 
            this.lblBackToMainScreen.AutoSize = true;
            this.lblBackToMainScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBackToMainScreen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackToMainScreen.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblBackToMainScreen.Location = new System.Drawing.Point(36, 10);
            this.lblBackToMainScreen.Name = "lblBackToMainScreen";
            this.lblBackToMainScreen.Size = new System.Drawing.Size(132, 21);
            this.lblBackToMainScreen.TabIndex = 2;
            this.lblBackToMainScreen.Text = "Pantalla Principal";
            this.lblBackToMainScreen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBackToMainScreen
            // 
            this.btnBackToMainScreen.BackColor = System.Drawing.Color.White;
            this.btnBackToMainScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToMainScreen.FlatAppearance.BorderSize = 0;
            this.btnBackToMainScreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBackToMainScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBackToMainScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMainScreen.Image = global::Cotix.UI.WinForms.Properties.Resources.left_arrow;
            this.btnBackToMainScreen.Location = new System.Drawing.Point(0, 0);
            this.btnBackToMainScreen.Name = "btnBackToMainScreen";
            this.btnBackToMainScreen.Size = new System.Drawing.Size(39, 40);
            this.btnBackToMainScreen.TabIndex = 1;
            this.btnBackToMainScreen.UseVisualStyleBackColor = false;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 602);
            this.Controls.Add(this.lblBackToMainScreen);
            this.Controls.Add(this.btnBackToMainScreen);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BaseForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "COTIX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnBackToMainScreen;
        public System.Windows.Forms.Label lblBackToMainScreen;
    }
}