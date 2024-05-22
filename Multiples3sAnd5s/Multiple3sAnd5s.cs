namespace Multiples3sAnd5s;

internal class Multiple3sAnd5s {
	static void Main(string[] args) {

		//=== TITLE/HEADER ===\\
		Console.SetWindowSize(120, 30);
		Console.Title = "Multiple3sAnd5s";
		Console.WriteLine("Multiple3sAnd5s");
		Console.WriteLine("This program will take in a positive number and output the sum of the multiples of 3 and 5.");
		Console.WriteLine("-------------------------------------------------------------------------------------------\n");

		//=== VARIABLES===\\
		string sInput;
		int iInput, sum = 0;

		//=== INPUT ===\\
		Console.WriteLine("What range would you like to input?");
		Console.Write("\n>> ");
		sInput = Console.ReadLine().Trim();
		Console.WriteLine();

		//=== LOGIC ===\\
		iInput = Convert.ToInt32(sInput);
		if(iInput <= 0) {
			Console.WriteLine("Invalid input.");
			Console.WriteLine("\n\n\n");
			return;
		}

		for(int i = 0; i < iInput; i++) 
			if(i%3 == 0 || i%5 == 0) sum += i;
		

		//=== OUTPUT ===\\
		Console.WriteLine($"The total sum: {sum}");
		Console.WriteLine("\n\n\n");

	}
}
