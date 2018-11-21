using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectType
{
    class Program
    {
        static void Main(string[] args)
        {
            object container1 = 5;
            object container2 = "Five";
            object container3 = true;

            Console.WriteLine("Container 1: " + container1);

            Console.WriteLine("Container 2: " + container2);

            Console.Read();

        }
    }
}
