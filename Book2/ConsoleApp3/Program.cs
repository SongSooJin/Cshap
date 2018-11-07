using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 델리게이트, 델리게이트 체인
// 델리게이트는 쓰레드와 이벤트에서 주로 이용할 수 있다는 것은 참고로 알아 두자
namespace ConsoleApp3
{
    public class Delegate1
    {

        // private delegate int OnjSum(int i, int j); //1. 선언
        public static void Main(string[] args)
        {
            // Delegate1 s = new Delegate1(); // 그래서 new해서 써야한다.
            //OnjSum myMethod = new OnjSum(Delegate1.Sum); //2. 생성, 메소드이름을 인자로

            //Func<int,int,int> myMethod = new Func<int, int, int> (Delegate1.Sum); // Delegate로 받기 

            //Func<int,int,int> myMethod = s.Sum; 
            //int,int,int / 앞 int두개는 아래의 파라미터 두개 마지막 int 값을 리턴받는 자료형
            // Action<int, int> myMethod = s.Sum; 

            // delegate 써서 바꾸기 
            //Action<int, int> myMethod = delegate (int i, int j)
            //{
            //    Console.WriteLine(i + j);
            //};

            // 람다식으로 바꾸기
            Action<int, int> myMethod = (i, j) =>
                Console.WriteLine(i + j); 
            

            //Func<int,int,int> myMethod = Delegate1.Sum; // new Func<int, int, int>생략가능
            //OnjSum myMethod = new OnjSum(Sum); //2. 생성
            //OnjSum myMethod = Sum; //2. 생성

            //Console.WriteLine("두수 합 : {0}", myMethod(10,30));
            myMethod(10, 30);

        }
        //static int Sum(int i, int j) {
        //    return i + j;
        //}

            // static 을 안붙이면 반드시 객체 참조가 필요하다.
            //int Sum(int i, int j)
            //{
            //    return i + j;
            //}

            //void Sum(int i, int j)
            //{
            //Console.WriteLine (i + j);
            //}

          
    }
}
