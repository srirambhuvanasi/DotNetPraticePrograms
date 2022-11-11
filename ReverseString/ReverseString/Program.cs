using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a string");
			string s1 = Console.ReadLine();
			string s2 = " ";
			for(int i=s1.Length-1;i>=0;i--)
			{
				s2 = s2 + s1[i];
			}
			Console.WriteLine(s2);
			Console.ReadLine();
		}
	}
}
