using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 닷넷 기본 실습 테스트(기본문법, 반복문,제어문,속성,인덱서,델리게이트,람다식,쓰레드) 12번

// 실행결과
// 2 4 6 8 10

namespace work12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] oneToTen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = oneToTen.Where(n => n % 2 == 0);



            foreach (int i in evenNumbers)

                Console.Write("{0} ", i);
        }
    }
}
