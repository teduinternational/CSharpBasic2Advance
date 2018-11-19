using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharType
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'a';
            char ch1 = 'A';
            Console.WriteLine("The code of '" + ch + "' is: " + (int)ch);
            Console.WriteLine("The code of '" + ch1 + "' is: " + (int)ch1);

            Console.Read();
        }
    }
}
