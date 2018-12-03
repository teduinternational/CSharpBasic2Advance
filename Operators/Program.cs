using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int squarePerimeter = 17;
            double squareSide = squarePerimeter / 4.0;
            double squareArea = squareSide * squareSide;
            Console.WriteLine(squareSide); // 4.25
            Console.WriteLine(squareArea); // 18.0625
            int a = 5;
            int b = 4;
            Console.WriteLine(a + b); // 9
            Console.WriteLine(a + (b++)); // 9
            Console.WriteLine(a + b); // 10
            Console.WriteLine(a + (++b)); // 11
            Console.WriteLine(a + b); // 11
            Console.WriteLine(14 / a); // 2
            Console.WriteLine(14 % a); // 4
            int one = 1;
            int zero = 0;
            // Console.WriteLine(one / zero); // DivideByZeroException
            double dMinusOne = -1.0;
            double dZero = 0.0;
            Console.WriteLine(dMinusOne / zero); // -Infinity
            Console.WriteLine(one / dZero); // Infinity


            //Logic opertors
            bool a1 = true;
            bool b1 = false;
            Console.WriteLine(a1 && b1); // False
            Console.WriteLine(a1 || b1); // True
            Console.WriteLine(!b1); // True
            Console.WriteLine(b1 || true); // True
            Console.WriteLine((5 > 7) ^ (a1 == b1)); // False

            //String concat
            string csharp = "C#";
            string dotnet = ".NET";
            string csharpDotNet = csharp + dotnet;
            Console.WriteLine(csharpDotNet); // C#.NET 
            string csharpDotNet4 = csharpDotNet + " " + 5;
            Console.WriteLine(csharpDotNet4); // C#.NET 5

            //Bitwise operators
            byte a2 = 3; // 0000 0011 = 3 
            byte b2 = 5; // 0000 0101 = 5 
            Console.WriteLine(a2 | b2); // 0000 0111 = 7 
            Console.WriteLine(a2 & b2); // 0000 0001 = 1 
            Console.WriteLine(a2 ^ b2); // 0000 0110 = 6 
            Console.WriteLine(~a2 & b2); // 0000 0100 = 4 
            Console.WriteLine(a2 << 1); // 0000 0110 = 6 
            Console.WriteLine(a2 << 2); // 0000 1100 = 12 
            Console.WriteLine(a2 >> 1); // 0000 0001 = 1

            //Comparision operator
            int x = 10, y = 5;
            Console.WriteLine("x > y : " + (x > y)); // True 
            Console.WriteLine("x < y : " + (x < y)); // False 
            Console.WriteLine("x >= y : " + (x >= y)); // True 
            Console.WriteLine("x <= y : " + (x <= y)); // False 
            Console.WriteLine("x == y : " + (x == y)); // False 
            Console.WriteLine("x != y : " + (x != y)); // True

            //Assignment operator
            int x1 = 6;
            string helloString = "Hello string.";
            int y1 = x1;

            x1 = x1 + 2;
            x1 += 2;
            x1 *= 2;

            //Conditional Operators
            int a3 = 6; int b3 = 4;
            Console.WriteLine(a3 > b3 ? "a3>b3" : "b3<=a3"); // a>b
            int num = (a3 == b3 ? 1 : -1); // num will have value -1

            //Dot operator
            Console.WriteLine(DateTime.Now); // Prints the date + time

            //Square bracket [] operator
            int[] arr = { 1, 2, 3 };
            Console.WriteLine(arr[0]); // 1 
            string str = "Hello";
            Console.WriteLine(str[1]); // e

            int? a4 = 5; Console.WriteLine(a4 ?? -1); // 5 
            string name = null;
            Console.WriteLine(name ?? "(no name)"); // (no name)

            Console.Read();
        }
    }
}
