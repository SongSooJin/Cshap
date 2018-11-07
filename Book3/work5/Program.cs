using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 닷넷 기본 실습 테스트(기본문법, 반복문,제어문,속성,인덱서,델리게이트,람다식,쓰레드) 5번

//Enter a Number : 123
//Reverse of Entered Number : 321

 
namespace work5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, reverse = 0;

            Console.WriteLine("Enter a Number : ");

            num = int.Parse(Console.ReadLine());

            while (num != 0)

            {

                // 채워 주세요, 10으로 나누어서 몫, 나머지 이용
                reverse = reverse * 10;
                reverse += num % 10;
                num = num / 10;
              


            }

            Console.WriteLine("Reverse of Entered Number is : " + reverse);

            Console.ReadLine();
        }
    }
}
