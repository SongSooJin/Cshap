using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(+3);      // 3
            Console.WriteLine(3 + 3);   // 6
            Console.WriteLine(3 + .3);  // 3.3
            Console.WriteLine("3"+"3"); // 33
            Console.WriteLine(3.0 + "3"); // 33

            Console.WriteLine(!true); // False

            byte x = 10;
            Console.WriteLine(~x); // -11

            Console.WriteLine(unchecked((short)50000)); // -15536
        }
    }
}
