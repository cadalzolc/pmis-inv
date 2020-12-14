using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LAZYANT_LIB;
using System.Configuration;

namespace PMIS
{

    static class Program
    {
 
        [STAThread]
        static void Main()
        {
            String ConnStr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString.ToString();

            if (Server.Start(ConnStr) == false)
            {
                Application.Exit();
            }
            else 
            {

                Application.SetCompatibleTextRenderingDefault(false);
                Application.EnableVisualStyles();

                FrmLogin f = new FrmLogin();
                f.ShowDialog();

                if (Current.User.ID.ToString()!="0") 
                {
                    Application.Run(new FrmMain());
                }
                
            }
            
        }
    }
}
