namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	static class Program
	{
		[System.STAThread]
		static void Main()
		{
			// **************************************************
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			// **************************************************

			// **************************************************
			//Form1 frmStartup = new Form1();
			//Form2 frmStartup = new Form2();
			MainForm frmStartup = new MainForm();

			System.Windows.Forms.Application.Run(frmStartup);

			if (frmStartup != null)
			{
				if (frmStartup.IsDisposed == false)
				{
					frmStartup.Dispose();
				}

				frmStartup = null;
			}
			// **************************************************
		}
	}
}
