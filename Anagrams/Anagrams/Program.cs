using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    internal class Program
    {
        public static bool isAnagram(string s1, string s2)
        {
            int count = 0;
            if(s1.Length==s2.Length)
            {
                for(int i=0; s1.Length>i; i++)
                {
                    for(int j=0;s2.Length>j; j++)
                    {
                        if(s1[i] == s2[j])
                        {
                            count++;
                            if (count == s1.Length)
                            {
                                return true;
                            }
                           
                        }
                       
                    }
                }
            }
            return false;
            

        }
        public static bool checkAngagramwithduplicatechar(string s1,string s2)
        {
            string d1 = RemoveDuplicate(s1); 
            string d2 = RemoveDuplicate(s2);
            return isAnagram(d1, d2);
        }

        public static string RemoveDuplicate(string word)
        {
            HashSet<char> uniqueChars = new HashSet<char>();
            StringBuilder result = new StringBuilder();

            foreach (char c in word)
            {
                
                if (uniqueChars.Add(c))
                {                   
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        static void Main(string[] args)
        {
            string s1 = "litten";
            string s2 = "tilten";
            var result = checkAngagramwithduplicatechar(s1,s2);
           // var result= isAnagram(s1, s2);
            Console.WriteLine(result);
            Console.ReadLine();
            
        }

        
    }
}
