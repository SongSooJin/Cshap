using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 상속(Inheritence) :
// 이미 정의된 클래스를 바탕으로 필요한 기능을 추가하여 정의하는 것을 
// 의미하며 부모 클래스의자원을 재사용 하는 것이다.

namespace ConsoleApp5
{
    public class Dog
    {
        public string name { get; set; }
        public void jitda()
        {
            Console.WriteLine(name + "가 짖다.");
        }
    }
    public class Pudle : Dog
    {
        public void work() {
            Console.WriteLine(name + "가 일한다.");
        }
    }
    public class Jindo : Dog
    {
        public void run() {
            Console.WriteLine(name + "가 달린다.");
        }
    }
    class DogManager
    {
        static void Main()
        {
            Pudle p = new Pudle();
            p.name = "푸들이";
            p.jitda(); p.work();

            Jindo j = new Jindo();
            j.name = "진돌이";
            j.jitda();
            j.run();

        }
    }
}