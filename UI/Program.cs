using System;
using System.Windows.Forms;
using BusinessLogic.Repository;

namespace UI
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			DatabaseInitializer.EnsureDatabase();

			Application.Run(new LoginPage());
		}
	}
}