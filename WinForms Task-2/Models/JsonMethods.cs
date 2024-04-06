using System.Text.Json;
using System.Xml.Linq;

namespace WinForms_Task_2.Models;

public static class JsonMethods
{
	private static string path = "..\\..\\..\\JsonFiles";

	public static byte Write(User u)
	{
		if (File.Exists($"{path}\\{u.Name}.json"))
			return 0;

		try
		{
			JsonSerializerOptions op = new() { WriteIndented = true };

			File.WriteAllText($"{path}\\{u.Name}.json", JsonSerializer.Serialize<User>(u, op));
			return 1;
		}
		catch { return 2; }
	}

	public static User? Read(string name)
	{
		if (File.Exists($"{path}\\{name}.json") == false)
			return null;

		try
		{
			JsonSerializerOptions op = new() { WriteIndented = true };

			return JsonSerializer.Deserialize<User>(File.ReadAllText($"{path}\\{name}.json"));
		}
		catch { return null; }
	}
}
