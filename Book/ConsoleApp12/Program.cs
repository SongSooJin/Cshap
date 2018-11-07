using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  new 한정자
namespace ConsoleApp5
{
    public class Dog
    {
        public string name { get; set; }
        public virtual void jitda()
        {
            Console.WriteLine(name + "가 짖다.");
        }
    }
    public class Pudle : Dog
    {
        // new 한정자 
        public new void jitda()
        {

            Console.WriteLine(name + "푸들푸들");
        }

        public void work()
        {

            Console.WriteLine(name + "가 일한다.");
        }


    }
    public class Jindo : Dog
    {
        public override void jitda()
        {
            Console.WriteLine(name + "진돌진돌~");
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

