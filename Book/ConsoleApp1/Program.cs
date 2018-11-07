using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 가변길이 매개변수
namespace ConsoleApp1
{
    class ParamsTest
    {
        static void Main(string[] args)
        {
            ParamsTest p = new ParamsTest();
            // 명명된 인수
            Console.WriteLine(p.Sum(j:1, i:2));
            Console.WriteLine(p.Sum(j:1));
            Console.WriteLine(p.Sum());
            // Console.WriteLine(p.Sum(1, 2, 3));

        }

        int Sum(int i=0, int j=0) // 선택적 인수 
        {
            Console.WriteLine("i={0}, j={1}", i , j);
            return i + j;
        }

        //int Sum(int i, int j, int k)
        //{
        //    return i + j + k;
        //}

        // params : 가변적으로 숫자가 들어옴
        //int Sum(params int[] iArray) {
        //    int sum = 0;
        // foreach : 배열에서 하나씩 꺼낼때
        //    foreach (int i in iArray) sum += i;
        //    return sum;
        //}

    }
}
