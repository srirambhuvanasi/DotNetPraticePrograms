using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {

        //Generic Class
        public class calculator<T>
        {

            public T Message;
            public void GenericMethod(T Name, T Location)
            {
                Console.WriteLine($"Message: {Message}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Location: {Location}");
            }
            public static bool AreEqual(T Value1, T value2)
            {
                return Value1.Equals(value2);
            }
        }

        // Generic Method
        public class calculator
        {
            public static bool AreEqual<T>(T Value1, T value2)
            {
                return Value1.Equals(value2);
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Generics Class Example in C#");
            calculator<string> myGenericClass = new calculator<string>
            {
                Message = "Welcome to DotNetTutorials"
            };
            myGenericClass.GenericMethod("Pranata Rout", "Bhubaneswar");


            bool equal = calculator.AreEqual<int>(4,4);
            bool Strequal = calculator<string>.AreEqual("Interview", "Sriram");

            Console.WriteLine(equal);
            Console.WriteLine(Strequal);

            Console.ReadLine();
        }
    }
}
