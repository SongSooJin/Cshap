﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// 멀티 쓰레드(AutoResetEvent, ManualResetEvent)
namespace ConsoleApp14
{
    class Program
    {
        private static int count = 0;
        public static EventWaitHandle _waitHandle;
        static void Main(string[] args)
        {
            Console.Write("1:AutoResetEvent\n2:ManualResetEvent\n..................");
            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    //차단기 올라간 상태
                    _waitHandle = new AutoResetEvent(true);
                    break;
                case '2':
                    _waitHandle = new ManualResetEvent(true);
                    break;
            }
            Console.WriteLine("");
            Thread T1 = new Thread(new ThreadStart(DoWork));
            Thread T2 = new Thread(new ThreadStart(DoWork));
            T1.Start();
            T2.Start();
        }
        static private void DoWork()
        {
            _waitHandle.WaitOne();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(count++);
                Thread.Sleep(500);
            }
            // 이부분에서 AutoResetEvent 는 자동으로 Reset 되어 차단기가 내려옴
            // ManualResetEvent 는 자동으로 차단되지 않아 차단기는 계속열려있다.
            // 그래서 모든 쓰레드가 통과하여 실행된다.
        }
    }


}

//1:AutoResetEvent
//2:ManualResetEvent
//..................1
//0
//1
//2
//3
//4


//1:AutoResetEvent
//2:ManualResetEvent
//..................2
//0
//1
//2
//3
//4
//5
//6
//7
//8
//9