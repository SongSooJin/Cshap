using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 람다식(Lambda Expression)
namespace Book3
{
    class Program
    {
        delegate int Calc(int i, int j); // 델리게이트 선언 
        static void Main(string[] args)
        {
            Calc c = new Calc(MySum);
            // 이 델리게이트는 이름있는 외부 메소드를 참조
            // new Calc 지울수 있음 

            Console.WriteLine("1+2={0}", c(1, 2));

            Calc c1 = delegate (int i, int j)  //델리게이트를 이용한 익명 메소드
            {
                return i + j;
            };
            Console.WriteLine("3+4={0}",c1(3,4));

            Calc c2 = (int a, int b) => a + b;
            Console.WriteLine("3+4={0}",c2(3,4));

            //  delegate int Calc(int i, int j); 라고 위에 지정을 int 로 해줬기 때문에 
            // 아래에 int를 선언을 안해도 람다식은 돌아감 
            // “형식 유추(Type Inference)”라고 해서 매개변수의 형식을 제거할 수 있다.
            // (델리게이트의 선언 코드로부터 형식을 유추함)
            Calc c3 = (a, b) => a + b;
            Console.WriteLine("3+4+{0}", c3(3, 4));
        }
        static int MySum(int i, int j) {
            return i + j;
        }
    }
}


//1+2=3
//3+4=7
//3+4=7
//3+4+7