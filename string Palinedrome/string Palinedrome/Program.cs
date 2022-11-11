using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_Palinedrome
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a palindrome word");
			string s1 = Console.ReadLine();
			string s2 = "";
			for(int i=s1.Length-1;i>=0;i--)
			{
				s2 += s1[i].ToString();
			}
			if(s2==s1)
			{
				Console.WriteLine("yes! string is palindeome :"+ s2);
			}
			else
			{
				Console.WriteLine("No! string is not palindeome :" + s2);
			}
			Console.ReadLine();
		}
	}
}
