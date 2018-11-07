using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 델리게이트를 이용하여 콜백을 구현하는 과정 예제1
namespace ConsoleApp4
{
    class OnjMath
    {
        internal static double MultipleByTwo(double value)
        {
            return value * 2;
        }
        internal static double Square(double value)
        {
            return value * value;
        }

    }
        delegate double OnjDouble(double x);

    class DelegateTest2 {
        static void Main(string[] args) {
            //Delegate를 배열로 지정
            OnjDouble[] op = {
                new OnjDouble(OnjMath.MultipleByTwo),
                new OnjDouble(OnjMath.Square)
            };

            for (int i = 0; i < op.Length; i++) {
                Console.WriteLine("op[{0}] 호출", i);
                CallDelegate(op[i], 3.0); //Delegate를 다른 메소드의 인자로 넘긴다
                //Console.WriteLine("결과는 {0} 이다", op[i](3.0));
                Console.WriteLine();
            }
        }

        static void CallDelegate(OnjDouble func, double value) {
            // 넘겨받은 Delegate를 실행 한다.
            double ret = func(value);
            Console.WriteLine("입력된 값은 {0}이고 결과는 {1} 이다.",value,ret);
        }
    }
}

//op[0] 호출
//입력된 값은 3이고 결과는 6 이다.

//op[1] 호출
//입력된 값은 3이고 결과는 9 이다.