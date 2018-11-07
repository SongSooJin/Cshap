using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 닷넷 기본 실습 테스트(기본문법, 반복문,제어문,속성,인덱서,델리게이트,람다식,쓰레드) 4번
// 아래와 같이 출력하는 프로그램을 작성하세요.
// *
// ***
// *****
namespace work4
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i+=2) {
                for (int j = 0; j < i + 1; j++) {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
           

        }
    }
}
