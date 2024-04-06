namespace WinForms_Task_2;

public static class Program
{

	[STAThread]
	static void Main()
	{

		try
		{
			ApplicationConfiguration.Initialize();
			Application.Run(new Form1());
		}
		catch
		{
			MessageBox.Show("Erron in App", "Run Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}