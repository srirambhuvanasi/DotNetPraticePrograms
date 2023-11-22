using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringLogical
{
     class Program
    {
        public static void Reversefor(string word)
        {
            string Rev=" ";
            for(int i=word.Length-1; i>=0; i--)
            {

                Rev = Rev+word[i];   
            }
            Console.WriteLine(Rev);
        }
        public static void ReverseForEach(string word)
        {
            string Rev = null;

            foreach( var letter in word)
            {
               Rev = letter+Rev; 
            }

            Console.WriteLine(Rev);
        }


        static void Main(string[] args)
        {


            Console.WriteLine("Enter a string to reverse");
            string Word=Console.ReadLine();

            Reversefor(Word);
            //ReverseForEach(Word);

            Console.ReadLine();

        }
    }
}
