using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 닷넷 기본 실습 테스트(기본문법, 반복문,제어문,속성,인덱서,델리게이트,람다식,쓰레드) 7번

// [결과]
// Student Info: Code = 001, Name = Zara, Age = 9
// Student Info: Code = 001, Name = Zara, Age = 10
namespace work7
{
    class Student
    {

        private string code = "N.A";
        private string name = "not known";
        private int age = 0;


        // Declare a Code property of type string:
        public string Code
        {
            get { return code; }
            set { code = value; }
        }


        // Declare a Name property of type string:
        public string Name
        {

            get { return name; }
            set { name = value; }

        }


        // Declare a Age property of type int:
        public int Age
        {

            get { return age; }
            set { age = value; }

        }

        public override string ToString()
        {
            return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;

        }

    }


    class ExampleDemo
    {

        public static void Main()
        {

            // Create a new Student object:
            Student s = new Student();


            // Setting code, name and the age of the student
            s.Code = "001";
            s.Name = "Zara";
            s.Age = 9;

            Console.WriteLine("Student Info: {0}", s);



            //let us increase age
            s.Age += 1;

            Console.WriteLine("Student Info: {0}", s);
            Console.ReadKey();

        }

    }

}
