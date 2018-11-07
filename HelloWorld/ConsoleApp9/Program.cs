using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Rtype
    {
        public object Value;
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            //// value  타입 예제 
            //int a = 1;
            //int b = a; //a의 값이 전달된다. a와 b는 별개의 저장공간
            //Console.WriteLine(a); // 1
            //Console.WriteLine(b); // 1
            //b = 2;
            //Console.WriteLine(a); // 1
            //Console.WriteLine(b); // 2


            //참조타입 예제 
            Rtype a = new Rtype();
            Rtype b = new Rtype();
            a.Value = 1; b = a; //a가 참조하는 것을 b도 참조한다.
            Console.WriteLine(a.Value); // 1
            Console.WriteLine(b.Value); // 1
            b.Value = 2;
            Console.WriteLine(a.Value); // 2
            Console.WriteLine(b.Value); // 2
        }
    }
}
