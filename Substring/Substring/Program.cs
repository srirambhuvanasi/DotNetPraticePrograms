using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
	class Program
	{
		static void Main(string[] args)
		{
			string value = "abc";
			// Avoid full length.
			for (int i = 1; i < value.Length; i++)
			{
				// End index is tricky.
				for (int j = 0; j <= value.Length - i; j++)
				{
					string substring = value.Substring(j,i);
					Console.WriteLine(substring);
				}
			}
			Console.ReadLine();
		}
	}
}
