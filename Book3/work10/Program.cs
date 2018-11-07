using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 닷넷 기본 실습 테스트(기본문법, 반복문,제어문,속성,인덱서,델리게이트,람다식,쓰레드) 10번

// 실행결과
// 2
namespace work10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = new List<int>() { 10, 20, 31, 40 };

            // ... Find index of first odd element.
            int oddIndex = elements.FindIndex(x => x % 2 != 0);

            Console.WriteLine(oddIndex);
        }
    }
}
