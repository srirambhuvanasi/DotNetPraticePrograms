using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabonaci_series
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("enter a number");
			int n = int.Parse(Console.ReadLine());
			int a = 1, b = 2, c = 0;
			while(a<n)
			{
				Console.WriteLine(a);
				c = a + b;
				a = b;
				b = c;
				
			}
			
			Console.ReadLine();

		}
	}
}
