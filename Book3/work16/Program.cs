using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 닷넷 기본 실습 테스트(기본문법, 반복문,제어문,속성,인덱서,델리게이트,람다식,쓰레드) 16번

//[실행결과]
//Dog
//Cat
//Mouse
//Mouse
namespace work16
{
    class Program
    {
        public delegate void EventHandler();

        public static event EventHandler _show;



        static void Main()

        {
            // Add event handlers to Show event. 
            _show += new Program.EventHandler(Cat);
            _show += new Program.EventHandler(Dog);
            _show += new Program.EventHandler(Mouse);
            _show += new Program.EventHandler(Mouse);


            // Invoke the event. 
            //d1.Invoke();
            //if (_show != null) {
            //    _show();
            //}

            _show?.Invoke();

        }



        static void Cat()
        {
            Console.WriteLine("Cat");
        }


        static void Dog()
        {
            Console.WriteLine("Dog");
        }


        static void Mouse()
        {
            Console.WriteLine("Mouse");

        }
    }
}
