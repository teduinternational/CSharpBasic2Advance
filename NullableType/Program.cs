using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableType
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            int? ni = 6;
            //Nullable<int> i = 5;
            Console.WriteLine(ni.HasValue);
            Console.WriteLine(ni.HasValue ? ni.Value : 0);
            Console.WriteLine(ni.GetValueOrDefault());

            Console.Read();
        }
    }
}
