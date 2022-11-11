using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Occurance_of_the_string_each_char_count
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = "cbgsfiufsgjcjfbgkfd";
			while(s.Length>0)
			{
				Console.Write(s[0] + " : ");
				int count = 0;
				for(int i=0;i<s.Length;i++)
				{
					if(s[0]==s[i])
					{
						count++;
					}
				}
				Console.WriteLine(count);
				s = s.Replace(s[0].ToString(), string.Empty);
			}
			Console.ReadLine();
		}
	}
}
