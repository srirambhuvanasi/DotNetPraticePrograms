using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubstringWithoutRepeatingCharacters
{
    internal class Program
    {
        public static int LongestSubstring(string s)
        {
            int maxLength = 0;
            string maxChar = null;
            int start = 0;
            Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (charIndexMap.ContainsKey(s[i]))
                {
                    start = Math.Max(start, charIndexMap[s[i]] + 1);
                }

                charIndexMap[s[i]] = i;
                maxLength = Math.Max(maxLength, i - start + 1);
                
            }
            
            return maxLength;
        }
        static void Main(string[] args)
        {
            string s = "GREEKSFORGREEKS";
            int result=LongestSubstring(s);
            Console.WriteLine($"Length of the longest substring without repeating characters: {result}");
            Console.ReadLine();

        }


    }
}
