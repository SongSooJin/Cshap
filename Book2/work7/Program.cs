using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//이벤트, 델리게이트 기초 실습과제 4번

//[실행결과]

//iAnswer = 7

//Multiple of five reached:

//iAnswer = 10
namespace work7
{
    class Program

    {

        static void Main()

        {

            Adder a = new Adder();

            a.OnMultipleOfFiveReached += a_MultipleOfFiveReached;
            //a.OnMultipleOfFiveReached += delegate (object sender, MultipleOfFiveEventArgs e) {
            //    Console.WriteLine("Multiple of five reached: {0}", e.Total);
            //};

            int iAnswer = a.Add(4, 3);

            Console.WriteLine("iAnswer = {0}", iAnswer);

            iAnswer = a.Add(4, 6);

            Console.WriteLine("iAnswer = {0}", iAnswer);

            Console.ReadKey();

        }



        static void a_MultipleOfFiveReached(object sender, MultipleOfFiveEventArgs e)

        {

            Console.WriteLine("Multiple of five reached: {0}", e.Total);

        }

    }



    public class Adder

    {

        public event EventHandler<MultipleOfFiveEventArgs> OnMultipleOfFiveReached;

        public int Add(int x, int y)

        {

            int iSum = x + y;

            if ((iSum % 5 == 0) && (OnMultipleOfFiveReached != null))

            {

                OnMultipleOfFiveReached(this, new MultipleOfFiveEventArgs(iSum));

            }

            return iSum;

        }

    }



    public class MultipleOfFiveEventArgs : EventArgs

    {
        // 클래스에서 new해서 객체를 만들고 싶은데 생성자가 없으면 생성자를 만들고 있으면 있는걸 쓰게됨 


        public MultipleOfFiveEventArgs(int iTotal)

        {

            Total = iTotal;

        }

        // c#의 프로퍼티 문법 : 객체 밖에서  int Total에 대한 직접적인 접근을 막고 get set을 통해서만 
        // 접근 하게 하기 위해 
        // get : 값을 읽어올때 / set : 값을 입력 
        public int Total { get; set; }

    }

}
