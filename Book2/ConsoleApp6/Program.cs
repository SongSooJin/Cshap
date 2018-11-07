using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 델리게이트를 이용하여 콜백을 구현하는 과정 예제3
namespace ConsoleApp6
{
    class Program
    {
        delegate void Deli(string s);

        static void Main()
        {
            // Specify delegate with Lambda Expression
            Deli d0 = (v) => Console.WriteLine(v);
            //Invoke delegate. 
            d0.Invoke("OJC");

            // Specify delegate with new Constructor 
            Deli d1 = new Deli(d);
            d1.Invoke("OJC");

            // Specify delegate with method name 
            Deli d2 = d;
            d2.Invoke("OJC");

        }
        static void d(string s) {
            Console.WriteLine(s);
        }
    }
}
