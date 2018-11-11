using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergerTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = 20;
            ushort years = 2000;
            uint days = 730480;
            ulong hours = 17531530;

            Console.WriteLine(centuries + " centuries are " + years + " years, or " + days + " days, or " + hours + " hours.");

            ulong maxIntValue = ulong.MaxValue;
            Console.WriteLine(maxIntValue);
            Console.Read();
        }
    }
}
