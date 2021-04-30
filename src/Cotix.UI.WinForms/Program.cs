using Cotix.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
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
            //ToDo: Create a form for initial configuration. It will create the database,picture folder and configure admin user.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CreateDataFolders();
            Application.Run(new frmMain());
        }

        static void CreateDataFolders()
        {
            if (!Directory.Exists(Properties.Settings.Default.ImageFolder)) Directory.CreateDirectory(Properties.Settings.Default.ImageFolder);
            
            using (SqlLiteDataContext db = new SqlLiteDataContext())
            {
                if (!db.Database.CanConnect())
                {
                    if (!Directory.Exists(Properties.Settings.Default.DataFolder)) Directory.CreateDirectory(Properties.Settings.Default.DataFolder);
                    db.Database.EnsureCreated();
                }
            }
        }
    }
}
