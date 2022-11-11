using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_number_in_a_string
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = "hhf5454dg66974dhd6548hgd888";
			
			int sum = 0;
			for(int i=0;i<s.Length;i++)
			{
				if((s[i] >= '0') && (s[i] <= '9'))
				{
					sum += (s[i] - '0');
				}
			}
			Console.WriteLine("Sum = " + sum);
			Console.ReadLine();
		}
	}
}
