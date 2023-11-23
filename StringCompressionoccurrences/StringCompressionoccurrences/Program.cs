using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompressionoccurrences
{
    internal class Program
    {
        public static void StringCompression(string s)
        {
            char temp = s[0];
            int count = 1;
            for (int i = 1; i < s.Length; i++)
            {  
                    if (s[i] == temp)
                    {
                        count++;                      
                    }
                    else
                    {
                    Console.Write(temp.ToString() + count);
                    temp = s[i];
                    count = 1;
                    }
            }
            Console.Write(temp.ToString());
            Console.Write(count);
        }

        static void Main(string[] args)
        {
            string s1 = "aaabbbffgg";
           
            StringCompression(s1);
          
            Console.ReadLine();
        }

       
    }
}
