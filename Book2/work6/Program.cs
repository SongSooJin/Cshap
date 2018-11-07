using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 이벤트, 델리게이트 기초 실습과제 3번
//[결과]

//iAnswer = 7

//Multiple of five reached!

//iAnswer = 10


namespace work6
{
    public class Adder

    {

        public delegate void EventRaiser();

        public event EventRaiser OnMultipleOfFiveReached;



        public int Add(int x, int y)

        {

            int iSum = x + y;

            if ((iSum % 5 == 0) && (OnMultipleOfFiveReached != null))

            {

                OnMultipleOfFiveReached();

            }

            return iSum;

        }

    }



    class Program

    {

        static void Main()

        {

            Adder a = new Adder();

            a.OnMultipleOfFiveReached += MultipleOfFiveReached;



            int iAnswer = a.Add(4, 3);

            Console.WriteLine("iAnswer = {0}", iAnswer);

            iAnswer = a.Add(4, 6);

            Console.WriteLine("iAnswer = {0}", iAnswer);

            Console.ReadKey();

        }



        static void MultipleOfFiveReached()

        {

            Console.WriteLine("Multiple of five reached!");

        }

    }
}
