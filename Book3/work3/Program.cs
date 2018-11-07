using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 닷넷 기본 실습 테스트(기본문법, 반복문,제어문,속성,인덱서,델리게이트,람다식,쓰레드) 3번

//Enter the First Number : 1 
//Enter the Second Number : 2 
//After Swapping :
//First Number : 2 
//Second Number : 1

namespace work3
{
    class Program
    {
        static void Main(string[] args)

        {

            int num1, num2, temp;
            Console.Write("\nEnter the First Number : ");

            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the Second Number : ");

            num2 = int.Parse(Console.ReadLine());



            int tmp = num1;
            num1 = num2;
            num2 = tmp;



            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + num1);
            Console.Write("\nSecond Number : " + num2);
            Console.Read();

            
        }


    }
}
