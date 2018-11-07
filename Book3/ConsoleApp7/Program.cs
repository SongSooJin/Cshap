using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  LINQ 쿼리식 기본 
// 배열에서 홀수 값 오름차순, 3보다 큰수 내림차순 추출

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var onjQuery1 = from n in num
                            where n % 2 == 1
                            orderby n
                            select n;

            foreach (int i in onjQuery1)
                Console.WriteLine("홀수 : {0}" , i);

            // Query Expression.
            IEnumerable<int> onjQuery2 =  //query variable
                from n in num  //데이터소스 및 범위변수(필수
                where n > 3  // 생략가능
                orderby n descending // 내림차순정렬(생략가능)
                select n;  //select or group으로 끝나야 한다.
            foreach (int i in onjQuery2) {
                Console.WriteLine(i);
            }
        }
    }
}

//홀수 : 1
//홀수 : 3
//홀수 : 5
//홀수 : 7
//홀수 : 9
//10
//9
//8
//7
//6
//5
//4
