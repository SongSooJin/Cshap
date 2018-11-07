using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class p18
    {
        class Emp {
            public override string ToString()
            {
                return "Emp";
            }
        }
        class Programer : Emp { }
        class Program {
            static void Main() {
                Programer p = new Programer();

                Emp e = p as Emp;
                if (e != null)
                    System.Console.WriteLine(e.ToString());
            }
        }
    }
}
