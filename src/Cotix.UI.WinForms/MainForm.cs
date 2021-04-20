using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cotix.UI.WinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            BaseForm f1 = new BaseForm() {TopLevel=false,Dock=DockStyle.Fill};
            panel1.Controls.Add(f1);
            panel1.Tag = f1;//el tag se utiliza para exponer algun contenido que yo quiera hacia afuera de la aplicacion.
            f1.BringToFront();
            //f1.btnBackToMainScreen.Visible = false;
            //f1.lblBackToMainScreen.Visible = false;
            f1.Show();
            
        }
    }
}
