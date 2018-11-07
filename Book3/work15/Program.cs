using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// 닷넷 기본 실습 테스트(기본문법, 반복문,제어문,속성,인덱서,델리게이트,람다식,쓰레드) 15번

// 실행결과
// 10 10 10 10 10 10 10 10 10 10
// Press a key...
namespace work15
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread[] t = new Thread[10];

            for (int tNum = 0; tNum < 10; tNum++)

            {

                t[tNum] = new Thread(() => {

                    Thread.Sleep(new Random().Next(20));

                    Console.Write(tNum + " ");

                });

                t[tNum].Start();

            }

            // wait for the threads to finish
            for (int tNum = 0; tNum < 10; tNum++)

            {

                t[tNum].Join();

            }

            Console.WriteLine("\nPress a key...");

            Console.Read();
        }
    }
}
