using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            short a = 10;
            int b = a;     //short형은 int형에 묵시적으로 변환되어 대입된다.
            int c = 50000; //이진수로 “0000 0000 0000 0000 1100 0011 0101 0000”
                           //short형으로 변환하면 부호비트가 0에서 1로, 음수가 된다.     

            short d = (short)c; //명시적으로 형변환 하지않으면 오류! 오버플로우가 일어남
            Console.WriteLine("Short : {0}",d); // Short : -15536


            try
            {
                short f = checked((short)c); // overflow를 검사하여 예외를 발생시킴
            }
            catch (Exception e)
            {
                Console.WriteLine("예외: { 0}",e.StackTrace);
                Console.WriteLine("예외: ",e.StackTrace);
            }


        }
    }
}
