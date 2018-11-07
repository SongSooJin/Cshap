using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 구조체 예제 
namespace ConsoleApp12
{
    struct Emp
    {
        public int id; public string name;
    }
    class EmpTest
    {
        public static void Main()
        {
            Emp e;
            e.id = 1;
            e.name = "1길동";

            Console.WriteLine("사번: {0}", e.id); // 사번:1
            Console.WriteLine("이름: {0}", e.name); // 이름: 1길동

            Emp e1 = new Emp(); //new하더라도 스택에 저장된다.

            e1.id = 2;
            e1.name = "2길동";

            Console.WriteLine("사번: {0}", e1.id); // 사번: 2
            Console.WriteLine("이름: {0}", e1.name); // 이름: 2길동
        }
    }
}
