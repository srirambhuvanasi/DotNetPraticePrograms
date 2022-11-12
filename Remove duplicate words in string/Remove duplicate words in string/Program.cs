using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_duplicate_words_in_string
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { 1, 2, 3, 4, 3, 55, 23, 2 };
			int[] dist = nums.Distinct().ToArray();

			Array.ForEach(dist, v => Console.WriteLine(v));

			string[] animals = { "Cat", "Alligator", "Fox", "Donkey", "Cat", "Fox" };

			string[] d = animals.Distinct().ToArray();

			Array.ForEach(d, v => Console.WriteLine(v));                           
			Console.ReadLine();
		}
	}
}
