using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

    1. 임의의 수를 콤마로 구분해서 Console.ReadLine()으로 입력 받은 후 델리게이트를

    이용하여 사칙연산을 구하는 프로그램을 델리게이트 체인 및 델리게이트 멀티 캐스팅을

    이용하여 구현하세요.

    */

namespace work
{
    public delegate void myDeli(int a, int b);
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            string[] strarr = str.Split(',');
            int[] iArr = Array.ConvertAll(strarr, i => int.Parse(i));

            myDeli callback = (myDeli)Delegate.Combine(

               new myDeli(Plus),

               new myDeli(Minus),

               new myDeli(Multiplication),

               new myDeli(Division)

               );

            callback(iArr[0], iArr[1]);
        }

      
            static void Plus(int a, int b) { Console.WriteLine("{0} + {1} = {2}", a, b, a + b); }
            static void Minus(int a, int b) { Console.WriteLine("{0} - {1} = {2}", a, b, a - b); }
            static void Multiplication(int a, int b) { Console.WriteLine("{0} * {1} = {2}", a, b, a * b); }
            static void Division(int a, int b) { Console.WriteLine("{0} / {1} = {2}", a, b, a / b); }
      

    }
}