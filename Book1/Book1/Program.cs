using System;

// 값 전달, 참조전달(ref, out)
namespace ConsoleApplication2
{
    class Program
    {
        static void Swap(out int a, out int b)
        //static void Swap(ref int a, ref int b)
        {
            a = 10; b = 20;
            int tmp = a;
                a = b;
                b = tmp;
           
        }
        // 메인은 CLR이 실행 
        static void Main(string[] args)
        {
            int a = 10; int b = 20;
            Console.WriteLine("a={0}, b={1}", a, b); // a=10, b=20
            // out 은 초기화가 안되있어야함 
            Swap(out a, out b);
            // ref 로 넘길려면 초기화가 되어있어야함 
            // Swap((ref a, (ref b);
            Console.WriteLine("a={0}, b={1}", a, b); // a=10, b=20
        }
    }
}