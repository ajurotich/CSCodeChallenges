using System;
using System.Text.Json;

namespace Common;

public class General {

	public static void Header(string title) {
		if(title == "")
			return;

		Console.Title = title;
		Console.WriteLine("\n" + title);
		for(int i = 0;i<title.Length;i++)
			Console.Write("-");
		Console.WriteLine("\n");
	}

	public static void Header(string title, string description) {
		if(title == "") return;

		Console.Title = title;
		Console.WriteLine("\n" + title.ToUpper() + '\n');

		Console.WriteLine(description);
		for(int i = 0; i<description.Length && i<Console.WindowWidth; i++) Console.Write("-");
		Console.WriteLine("\n");
	}

	public static void Footer() =>
		Console.WriteLine("\n\n\n");

	public static string Stringify<T>(T input) =>
		JsonSerializer.Serialize(input, new JsonSerializerOptions { WriteIndented = true });

}
