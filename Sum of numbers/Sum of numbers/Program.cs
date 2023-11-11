using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a number");
			int num =int.Parse( Console.ReadLine());
			int Sum = 0, rem,rev=0;
			
			//same it is as a palinedrome number 
			while(num!=0)
			{
				rem = num % 10;
				rev = (rev * 10) + rem;
				num = num / 10;
			}
			Console.WriteLine("Reverse number is :"+rev);
			

			while (num > 0)
			{
				rem = num % 10;
				Sum = Sum + rem;
				num = num / 10;
			}
			Console.WriteLine("Sum of number :" + Sum);

			while (num > 0)
			{
				rem = num % 10;
				rev = (rev * 10) + rem;
				num = num / 10;
			}
			if (num == rev)
			{
				Console.WriteLine("It is a palindrone number :" + rev);
			}
			else
			{
				Console.WriteLine("It is not palindrone number :" + rev);
			}
			Console.ReadLine();
		}
	}
}
