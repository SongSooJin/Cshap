using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 생성자와 소멸자
namespace ConsoleApp9
{
    class A
    {
        // private  : 아무것도 안써져있으면 private이다.
        // protected A()
        internal A()
        {

        }

        ~A() { // 소멸자: public / finalize() 메소드 : ~가 붙으면
            Console.WriteLine("A소멸");
        }
    }

    class B :A
    {
        static void Main(string[] args)
        {
            // B a = new B(); // object -> A -> B
            A a = new A(); // 생성자 
            GC.Collect();
        }
    }
}
