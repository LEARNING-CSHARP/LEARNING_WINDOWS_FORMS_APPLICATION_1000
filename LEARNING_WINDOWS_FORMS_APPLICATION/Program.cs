﻿namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	internal static class Program
	{
		static Program()
		{
		}

		[System.STAThread]
		internal static void Main()
		{
			// **************************************************
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			// **************************************************

			// **************************************************
			//System.Windows.Forms.Application.Run(new Form1());
			//System.Windows.Forms.Application.Run(new Form2());
			System.Windows.Forms.Application.Run(new MainForm());
			// **************************************************

			// **************************************************
			////Form1 startupForm = new Form1();
			//Form2 startupForm = new Form2();
			////MainForm startupForm = new MainForm();

			//System.Windows.Forms.Application.Run(startupForm);

			//if (startupForm != null)
			//{
			//	if (startupForm.IsDisposed == false)
			//	{
			//		startupForm.Dispose();
			//	}

			//	//startupForm = null;
			//}
			// **************************************************
		}
	}
}
