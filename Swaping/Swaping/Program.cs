using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swaping
{
	class Program
	{
		static void Main(string[] args)
		{
			int N1 = 10;
			int N2 = 9;
			int N3 = N1;
				N1 = N2;
				N2 = N3;
			Console.WriteLine(N1);
			Console.WriteLine(N2);

			//Without third varibale
			N1 = N1 + N2;
			N2 = N1 - N2;
			N1 = N1 - N2;
			Console.WriteLine(N1);
			Console.WriteLine(N2);

			Console.ReadLine();
		}
	}
}
