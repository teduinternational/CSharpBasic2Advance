using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealFloatingPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            //float floatPI = 3.14f;
            //Console.WriteLine(floatPI); // 3.14 
            //double doublePI = 3.14;
            //Console.WriteLine(doublePI); // 3.14 
            //double nan = Double.NaN;
            //Console.WriteLine(nan); // NaN 
            //double infinity = Double.PositiveInfinity;
            //Console.WriteLine(infinity); // Infinity

            float floatPI = 3.141592653589793238f;
            double doublePI = 3.141592653589793238;

            decimal decimalPI = 3.14159265358979323846m;
            // Print the results on the console 
            Console.WriteLine("Float PI is: " + floatPI);
            Console.WriteLine("Double PI is: " + doublePI);
            Console.WriteLine("Decimal PI is: " + decimalPI);

            Console.Read();
        }
    }
}
