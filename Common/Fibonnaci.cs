using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common;

public class Fibonnaci {

	public static int FibIndex(int n) =>
		(n < 2) ? n : FibIndex(n-1) + FibIndex(n-2) ;

	public static int FibLessThan(int n) {
		if(n <=0 ) return 0;
		int i = 1;
		
		while (FibIndex(i) < n) i++;

		return i;
	}

}
