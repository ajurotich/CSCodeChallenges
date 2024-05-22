using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace CodeChallenges2;

internal class TensDigitFibonacci {

    static void Main(string[] args){

		//=== TITLE/HEADER ===\\
		Console.SetWindowSize(120, 30);
		General.Header("Tens Digit Fibonacci",
			"This program takes a positive integer and outputs the index of the first " +
			"number in the Fibonacci sequence with that many digits.");

		//=== VARIABLES===\\
		int iInput, index = 1;
		int[] fib = [0, 1];

		//=== INPUT ===\\
		Console.WriteLine("How many digits would you like to input?");
		Console.Write("\n>> ");

		//=== LOGIC ===\\
		try {
			iInput = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine();
        }
		catch {
			Console.WriteLine("Invalid input.");
			General.Footer();
			return;
		}
		if(iInput <= 0) {
			Console.WriteLine("Invalid input.");
			General.Footer();
			return;
		}

		//while ((Fibonnaci.FibIndex(index)).ToString().Length < iInput) index++;
		while(fib[1].ToString().Length < iInput) {
			fib = [fib[1], fib[0] + fib[1]];
			index++;
		}

		//=== OUTPUT ===\\
		Console.WriteLine($"The index: {index}");
		Console.WriteLine($"The number: {Fibonnaci.FibIndex(index):N0}");
		General.Footer();

	}

}
