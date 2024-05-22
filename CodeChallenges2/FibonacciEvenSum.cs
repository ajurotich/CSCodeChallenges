using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace CodeChallenges2;

internal class FibonacciEvenSum {

	static void Main(string[] args){

		//=== TITLE/HEADER ===\\
		Console.SetWindowSize(120, 30);
		General.Header("Fibonacci Even Sum",
			"This program takes a positive integer and outputs the sum of all the even numbers\n" +
			"in the Fibonacci sequence up to that number.");

		//=== VARIABLES===\\
		int iInput, sum = 0;
		int[] fib = [ 0, 1 ];

		//=== INPUT ===\\
		Console.WriteLine("What range would you like to input?");
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

		while(fib[1] <= iInput) {
			if(fib[1] % 2 == 0) sum += fib[1];

			fib = [ fib[1], fib[0] + fib[1] ];
		}

		//=== OUTPUT ===\\
		Console.WriteLine($"The total sum: {sum:N0}");
		General.Footer();

	}

}
