using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveSpecial_charcters
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = "s$hgh%jhjk&nkjndf*khjkhd###jhhjhf))(R";
			string[] chars = new string[] { ",", ".", "/", "!", "@", "#", "$", "%", "^", "&", "*", "'", "\"", ";", "_", "(", ")", ":", "|", "[", "]" };
			for (int i= 0;i < chars.Length;i++)
			{
				if(s.Contains(chars[i]))
				{
					s = s.Replace(chars[i],"");
				}
			}
			Console.WriteLine(s);
			Console.ReadLine();
		}
	}
}
