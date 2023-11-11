using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_max_Count
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = "srirambgjhkjffhjfcbahgasfhbvfcsfhuvuviacsdvhjZsna";
			int[] charcount = new int[256];
			int len = s.Length;
			for(int i=0;i<len;i++)
			{
				charcount[s[i]]++;
			}
			int maxcount = -1;
			char ch = ' ';
			for(int j=0;j<len;j++)
			{
				if(maxcount<charcount[s[j]])
				{
					maxcount = charcount[s[j]];
					ch = s[j];
				}
			}
			Console.WriteLine("Highest charcter :"+ ch);
			Console.WriteLine("Number of time :"+maxcount);
			Console.ReadLine();
		}
	}
}
