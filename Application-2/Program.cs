namespace Application_2;

public static class Program
{

	[STAThread]
	static void Main()
	{
		try
		{
			ApplicationConfiguration.Initialize();
			Application.Run(new Form2());
		}
		catch
		{
			MessageBox.Show("as", "as");
		}
	}
}