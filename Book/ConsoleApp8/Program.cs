using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 인터페이스(Interface) : 
//인터페이스는 추상 클래스와 비슷한 개념으로 규격(틀)을 정하는 것인데 
//추상클래스가 상속 계층 구조간에 존재하지만 인터페이스는 다분히 수평적인 개념이다.
//(Dog의 하위 객체인 개가 되려면 반드시 Dog 인터페이스를 구현해야 한다.)
namespace ConsoleApp5
{
   interface Dog
    {
        string name { get; set; }
        void jitda();

    }
    class Pudle: Dog
    {
        public string name { get; set; }
        public void work()
        {
            Console.WriteLine(name + "가 일한다.");
        }
        public void jitda()
        {
            Console.WriteLine(name + " 짖다~~~.");
        }

    }

    class Jindo: Dog
    {
        public string name { get; set; }
        public void jitda()
        {
            Console.WriteLine(name + " 짖다~~~.");
        }

        public void run()
        {
            Console.WriteLine(name + "가 달린다.");
        }

    }
    class DogManager
    {
        static void Main()
        {
            Dog p = new Pudle();
            p.name = "푸들이";
            p.jitda(); // 푸들푸들
            ((Pudle)p).work();

            Dog j = new Jindo();
            j.name = "진돌이";
            j.jitda(); // 진돌진돌
            ((Jindo)j).run();

        }
    }
}
