using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al3ooryCharity
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             //Application.Run(new FrmLogin());
            //Application.Run(new Main());
            // Application.Run(new FrmLogin());
            //Application.Run(new FrmAddDona());
            //Application.Run(new PL.FrmManageDona());
            //Application.Run(new PL.Admin.FrmManageCategories());
            //Application.Run(new Al3ooryCharity.PL.frmUserList());
           /* FrmCreateIDs createIDs = new FrmCreateIDs();
            createIDs.Size = new System.Drawing.Size(474, 570);
            Application.Run(createIDs);*/
            //Application.Run(new Al3ooryCharity.FrmMemList());
           // Application.Run(new PL.Admin.FrmManageCategories());
            //Application.Run(new PL.FrmManageMem());
            //Application.Run(new PL.Admin.FrmAddUser());
            Application.Run(new PL.FrmBackup());
            //Application.Run(new FrmChangePass());
            //Application.Run(new PL.Admin.FrmAddUser());

        }
    }
}
