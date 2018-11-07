using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

//  멀티 쓰레드(Multi-Thread)

namespace ConsoleApp10
{
    public class ThreadTest
    {
        public void FirstWork()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                Console.Write("F{0}", i);
            }

        }
            public void SecondWork() {
                for (int i = 0; i < 100; i++) {
                    Thread.Sleep(1000);
                    Console.Write("S{0}", i);
                }
            }


            public static void Main()
            {
                ThreadTest t = new ThreadTest();
                //Thread는 생성자에 ThreadStart형 Delegate를 인자로 받는다.
                Thread first = new Thread(t.FirstWork);
                Thread second = new Thread(new ThreadStart(t.SecondWork));

                first.Priority = ThreadPriority.Lowest;
                second.Priority = ThreadPriority.Highest;
                first.Start();
                second.Start();
            }
        }        
}

//S0F0S1F1S2F2S3F3S4F4S5F5S6F6S7F7S8F8S9F9S10F10 ....