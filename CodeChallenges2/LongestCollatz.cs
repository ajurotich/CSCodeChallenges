using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace CodeChallenges2;

internal class LongestCollatz {

	static void Main(string[] args) {

		//=== TITLE/HEADER ===\\
		Console.SetWindowSize(120, 30);
		General.Header("Longest Collatz",
			"This program takes a positive integer and outputs the number under that input with the longest" +
			"Collatz chain.");

		//=== VARIABLES===\\
		int iInput, num = 1, length = 0;

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

		for (int i = 1; i < iInput; i++) {
			int l = CollatzChainLength(i);
            if (l > length) {
				length = l;
				num = i;
			}
		}

		//=== OUTPUT ===\\
		Console.WriteLine($"The number: {num}");
		Console.WriteLine($"The length: {length}");
		General.Footer();

	}

	internal static int CollatzChainLength(int n) {
		int length = 1;

		while(n > 1) {
			n = (n%2 == 0) ? n/2 : 3*n+1;
			length++;
		}

		return length;
	}

}
