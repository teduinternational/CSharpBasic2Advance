using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringType
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Smith";

            string fullName = firstName + " " + lastName;

            Console.WriteLine("Hello, " + firstName + "!");
            Console.WriteLine("Your full name is " + fullName + ".");
            Console.Read();
        }
    }
}
