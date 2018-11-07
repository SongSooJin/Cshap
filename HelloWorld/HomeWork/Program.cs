using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1번 다음과 같은 결과를 출력하는 C# 프로그램을 작성하세요.
            //// 2 4 6 8 10
            //
            //int i = 1;

            //for (i = 1; i <= 10; i++) {
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }


            //// 2번  숫자를 입력하면 다음과 같이 출력하는 C# 프로그램을 작성하세요. 
            //// [출력] 
            ////입력숫자: 10
            ////10까지의 숫자 : 1 2 3 4 5 6 7 8 9 10
            ////10까지의 숫자합은 : 55
            ///
            //string str = Console.ReadLine();

            //int num = int.Parse(str);
            //int sum = 0;
            //for (int i = 1; i <= num; i++)
            //{
            //    for (i = 1; i <= num; i++)
            //    {
            //        Console.WriteLine(i);
            //        sum += i;
            //    }
            //    Console.WriteLine(sum);

            //}


            //// 3번 10개의 숫자를 입력받아 입력받은 수를 출력하고 합, 평균을 구해 출력하세요. 
            //string str = Console.ReadLine();

            //int num = int.Parse(str);
            //int sum = 0;

            //for (int i = 1; i <= num; i++)
            //{
            //    for (i = 1; i <= num; i++)
            //    {
            //        Console.WriteLine(" 숫자 :"+i);
            //        sum += i;
            //    }
            //    Console.WriteLine(" 합 :"+sum);


            //}
            //double avg = (double)sum / num;
            //Console.WriteLine(" 평균 :" + avg);


            ////4번 다음과 같이 출력결과를 만들어내는 C# 프로그램을 작성하세요.
            int i, j;
            string str = Console.ReadLine();
            int num = int.Parse(str);

            for (i = 1; i <=num; i++) {
                for (j = 1; j <= 3; j++) {
                    Console.Write(j + "x" + i + "=" + (i * j)+" ");
                }
                Console.WriteLine( );
            }
            
        }
    }
}
