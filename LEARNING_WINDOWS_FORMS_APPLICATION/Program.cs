﻿namespace LEARNING_WINDOWS_FORMS_APPLICATION
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
			//Form1 startupForm = new Form1();
			Form2 startupForm = new Form2();
			//MainForm startupForm = new MainForm();

			System.Windows.Forms.Application.Run(startupForm);

			if (startupForm != null)
			{
				if (startupForm.IsDisposed == false)
				{
					startupForm.Dispose();
				}

				startupForm = null;
			}
			// **************************************************
		}
	}
}
