using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ServiceModel;
using SD.LLBLGen.Pro.Examples.WCF.ServiceInterface;

namespace SD.LLBLGen.Pro.Examples.WCF.Client
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

            // Open a channel with the WCF service endpoint, and keep it alive till the end of the program.
            ChannelFactory<INorthwindService> channelFactory = new ChannelFactory<INorthwindService>("WCFServer");
            INorthwindService service = channelFactory.CreateChannel();
			var toRun = new MainForm(service);
            Application.Run(toRun);

            channelFactory.Close();
        }
    }
}