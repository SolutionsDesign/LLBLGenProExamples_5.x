using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SD.LLBLGen.Pro.Examples.Authorization.Identity;

namespace SD.LLBLGen.Pro.Examples.Authorization.GUI
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
            Application.Run(new Login());

            if (LoginHelper.IsUserLoggedIn)
            {
                Application.Run(new Main());
            }
        }
    }
}