using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicate_Characters_in_string
{
	class Program
	{
		static void Main(string[] args)
		{
			string s1 = "Google";
			string s2 = " ";
			string s3 = " ";
			foreach(char value in s1)
			{
				if(s2.IndexOf(value)==-1)
				{
					s2 += value;
					s3 += value;
				}
			}
			Console.WriteLine(s3);
			Console.ReadLine();
		}
	}
}
