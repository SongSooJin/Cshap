using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 닷넷 기본 실습 테스트(기본문법, 반복문,제어문,속성,인덱서,델리게이트,람다식,쓰레드) 2번
// 하나의 숫자를 입력받아서 홀수/짝수를 판정하세요.
namespace work2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int num = int.Parse(str);

            if (num % 2 == 0)
            {
                Console.WriteLine("짝수", num);
            }
            else {
                Console.WriteLine("홀수", num);
            }
            
        }
    }
}
