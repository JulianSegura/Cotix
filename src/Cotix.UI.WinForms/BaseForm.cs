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
    public partial class BaseForm : Form
    {
        ToolTip toolTip = new ToolTip();
        protected internal bool Modified = false;

        public BaseForm()
        {
            InitializeComponent();
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnDelete, "Eliminar");
        }

        private void btnEdit_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnEdit, "Ver Detalles / Actualizar");
        }

        private void btnNew_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnNew, "Agregar Nuevo");
        }
    }
}
