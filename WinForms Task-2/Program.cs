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
		catch(Exception ex)
		{
			MessageBox.Show("Erron in App", $"{ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}