using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 일반화 프로그래밍(Generic)
namespace ConsoleApp4
{
    class Program<T> // 일반화 클래스 
    {
        //static void Main(string[] args)
        //{
        //    int i = 1; int j = 2;
        //    Console.WriteLine("{0} + {1}+ {2}",i,j,Sum<int>(i,j));
        //    float f1 = 1.0f; float f2 = 2.0f;
        //    Console.WriteLine("{0:f} + {1:f}+ {2:f}", f1, f2, Sum<float>(f1, f2));

        //}
        //static T Sum<T>(T i, T j) {
        //    return (dynamic)i + (dynamic)j;
        //}
        public T Sum<T>(T i, T j)
        {
            return (dynamic)i + (dynamic)j;
        }

        // dynamic : 컴파일 할때 데이터타입 신경쓰지마라 
        //static float Sum(float i = 0, float j = 0)
        //{
        //    return i + j;
        //}
    }
    class Programtest
    {
        static void Main()
        {
            Program<int> t = new Program<int>();
            int i = 1; int j = 2;
            Console.WriteLine("{0} + {1}+ {2}", i, j, t.Sum(i, j));

            Program<float> t1 = new Program<float>();
            float f1 = 1.0f; float f2 = 2.0f;
            Console.WriteLine("{0:f} + {1:f}+ {2:f}", f1, f2, t.Sum(f1, f2));

        }
    }
}
