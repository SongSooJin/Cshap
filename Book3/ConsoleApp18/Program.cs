using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// 멀티 쓰레드(동기화, Monitor)

namespace ConsoleApp17
{
    public class ThreadTest3
    {
        public string lockString = "Hello";
        private object obj = new object();
        public void Print(string rank)
        {
            //Monitor.Enter 구문은 처음 쓰레드가 끝날때 까지 다른 쓰레드가 접근 금지
            Monitor.Enter(obj);
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Thread.Sleep(100);
                        Console.Write(",");
                    }
                    Console.WriteLine("{0}{1} ", rank, lockString);
                }
                Monitor.Exit(obj);
            }
        }
        public void FirstWork() { Print("F"); }
        public void SecondWork() { Print("S"); }
    }
    class TestMain
    {
        [MTAThread]
        public static void Main()
        {
            ThreadTest3 t = new ThreadTest3();
            Thread first = new Thread(new ThreadStart(t.FirstWork));
            Thread second = new Thread(new ThreadStart(t.SecondWork));
            first.Start();
            second.Start();
        }
    }}//,,,,,FHello
//,,,,,FHello
//,,,,,FHello
//,,,,,FHello
//,,,,,FHello
//,,,,,SHello
//,,,,,SHello
//,,,,,SHello
//,,,,,SHello
//,,,,,SHello