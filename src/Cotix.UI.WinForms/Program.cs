using Cotix.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cotix.UI.WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ToDo: Create a form for initial configuration. It will create the database and configure admin user.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (SqlLiteDataContext db = new SqlLiteDataContext())
            {
                if (!db.Database.CanConnect())
                {
                    db.Database.EnsureCreated();
                }
            }

            Application.Run(new frmMain());
        }
    }
}
