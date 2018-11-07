using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Emp
    {
        // protected : 같은 패키지나 상속받은 클래스에서만 쓸수 있음 
        // internal : 같은 어셈블리(exe파일,프로젝트)
        // public : 공용 
        // private string name; // 멤버변수 / 피드 (자바는 인스턴스변수)
        public string Name // 자동구현속성
        {
            get;
            set;
        }
        //public void SetName(string name) {
        //    this.name = name;
        //}
        //public string GetName() {
        //    return this.name;
        //}
    }

    class EmpTest {

        static void Main()
        {
            Emp e = new Emp();
            //e.SetName("길동이");
            e.Name = "길동이";
            //Console.WriteLine(e.GetName());
            Console.WriteLine(e.Name);
        }
    }
       
    
}
