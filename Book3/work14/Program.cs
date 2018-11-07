using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 닷넷 기본 실습 테스트(기본문법, 반복문,제어문,속성,인덱서,델리게이트,람다식,쓰레드) 14번

//[실행결과]
//Number: 10,000 
//Number: 200 
//Money: $ 10,000.00 
//Money: $ 200.00
namespace work14
{
    class Program
    {
        // declare delegate
        public delegate void Print(int value);


        static void Main(string[] args)
        {


            // Print delegate points to PrintNumber
            Print printDel = new Print(PrintNumber);

            printDel(10000);
            printDel(200);


            // Print delegate points to PrintMoney
            printDel = PrintMoney;

            printDel(10000);
            printDel(200);
        }

        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);

        }
    }
}
