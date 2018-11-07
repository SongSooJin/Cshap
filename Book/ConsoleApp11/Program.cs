using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 코드 최적화, 객체생성 및 멤버,필드 초기화
namespace ConsoleApp11
{
    class Emp {
        public int Empno {
            get;set;
        }
        public string Ename {
            get; set;
        }
        public override string ToString()
        {
            return "[사번 :" + Empno + ", 이름 : " + Ename + "]";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Emp e1 = new Emp();
            e1.Empno = 1;
            e1.Ename = "수진송";
            Console.WriteLine(e1); // [사번 :1, 이름 : 수진송]

            Emp e2 = new Emp()
            {
                Empno = 2,
                Ename = "콩알"
            };
            Console.WriteLine(e2); // [사번 :2, 이름 : 콩알]
        }
    }
}
