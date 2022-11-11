using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReverseIntegers
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 1, 2, 3, 4, 5, 6 };
			Array.Reverse(arr);
			foreach(int value in arr)
			{
				Console.Write(value);
			}
			Console.ReadLine();
		}
	}
}
