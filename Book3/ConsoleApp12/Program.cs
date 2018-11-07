using System;
using System.Threading;

// 멀티 쓰레드(Interrupt를 이용한 쓰레드 종료방법)

namespace ConsoleApp12
{
    class Program
    {
        public static Thread sleeperThread;
        
        public static void Main(string[] args)
        {
            sleeperThread = new Thread(new ThreadStart(ThreadToSleep));
            sleeperThread.Start();
            sleeperThread.Interrupt();
        }

        private static void ThreadToSleep() {
            int i = 0;
            while (true) {
                Console.WriteLine("[Sleeper :" + i++ +" ]");
                if (i == 9) {
                    try {
                        Console.WriteLine("i가 9가 되어 1초 쉼///");
                        Thread.Sleep(1000);
                    }
                    catch (ThreadInterruptedException e) {
                        Console.WriteLine("ThreadInterruptedException ...");
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}

//[Sleeper:0 ]
//[Sleeper:1 ]
//[Sleeper:2 ]
//[Sleeper:3 ]
//[Sleeper:4 ]
//[Sleeper:5 ]
//[Sleeper:6 ]
//[Sleeper:7 ]
//[Sleeper:8 ]
//i가 9가 되어 1초 쉼///
//ThreadInterruptedException...