using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 닷넷 기본 실습 테스트(기본문법, 반복문,제어문,속성,인덱서,델리게이트,람다식,쓰레드) 1번
// 콤마로 구분해서 야러 숫자를 입력받아 합을 구하는 프로그램을 작성하세요.

namespace work
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] sArr = s.Split(',');
            int[] iArr = Array.ConvertAll(sArr, i => int.Parse(i));
            int sum = 0;

            for (int j = 0; j < iArr.Length; j++) {
                 sum += iArr[j];
               
            }

            Console.WriteLine("합은 : {0}", sum);
        }
    }
}
