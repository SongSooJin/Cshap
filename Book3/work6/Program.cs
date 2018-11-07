using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 닷넷 기본 실습 테스트(기본문법, 반복문,제어문,속성,인덱서,델리게이트,람다식,쓰레드) 6번
// 사용자로 부터 하나의 수를 입력받고 그수까지의 소수의 합을 구하는 프로그램을 작성하세요.

namespace work6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int num = int.Parse(str);
            int i, j;
            int k = 1;
            int l = 0;
            int temp = 0;
            int sum = 0;


            for (i = 2; i <= num; i++)
            {
                k = i;
                for (j = 1; j < k + 1; j++)
                {
                    if (k % j == 0)
                    {
                        l++;
                    }
                }

                if (l <= 2)
                {
                    temp++;
                }

                l = 0;
                sum += k;

            }

            Console.WriteLine("소수는 {0}개", temp);
            Console.WriteLine("소수의 합 : {0}", sum);


        }
    }
}
