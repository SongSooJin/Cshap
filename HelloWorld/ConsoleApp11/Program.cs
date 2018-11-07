using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            //null값을 허용 하고 싶다면 ?를 사용하라.
            // 데이터 타입뒤에 ?를 붙이면 null 사용 

            //int b;
            //if (a.HasValue) b = a.Value;
            //else b = 0;
            //Console.WriteLine("Value of b is {0}", b); // Value of b is 0

            int b = (int)a;
            Console.WriteLine("Value of b is {0}", b);
            
            int c = a ?? 0;
            Console.WriteLine("Value of c is {0}", c); // Value of c is 0
            Console.ReadLine();
        }
    }
}
