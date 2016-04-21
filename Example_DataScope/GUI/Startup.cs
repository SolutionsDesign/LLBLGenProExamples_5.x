using System;
using System.Windows.Forms;


namespace Northwind.GUI
{
	/// <summary>
	/// Simple startup class with the main.
	/// </summary>
	public class Startup
	{
		public Startup()
		{
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.DoEvents();

			MainForm mainWindow = new MainForm();
			Application.Run(mainWindow);
		}
	}
}
