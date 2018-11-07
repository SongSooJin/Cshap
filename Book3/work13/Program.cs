using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

// 닷넷 기본 실습 테스트(기본문법, 반복문,제어문,속성,인덱서,델리게이트,람다식,쓰레드) 13번

//실행 결과
//Rex
//Sean
//Stacy

namespace work13
{
    class Dog

    {

        public string Name { get; set; }

        public int Age { get; set; }

    }

    class demo
    {

        static void Main()

        {

            List<Dog> dogs = new List<Dog>() {

            new Dog { Name = "Rex", Age = 4 },
            new Dog { Name = "Sean", Age = 0 },
            new Dog { Name = "Stacy", Age = 3 }

         };

            var names = dogs.Select(x => x.Name);

            foreach (var name in names)

            {
                Console.WriteLine(name);

            }

            Console.Read();

        }

    }
}
