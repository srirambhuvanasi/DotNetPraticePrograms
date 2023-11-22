using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate void Calculator(int x, int y);
     class Program
    {
        public static void Add( int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Main(string[] args)
        {
            Calculator obj = new Calculator(Add);
            obj += Mul;
            obj(10,20);
            Console.ReadLine();
        }
    }
}
