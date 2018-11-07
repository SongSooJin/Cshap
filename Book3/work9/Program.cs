using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 닷넷 기본 실습 테스트(기본문법, 반복문,제어문,속성,인덱서,델리게이트,람다식,쓰레드) 9번

//[실행결과]
//Zara
//Riz
//Nuha
//Asif
//Davinder
//Sunil
//Rubic
//N.A.
//N.A.
//N.A.

namespace work9
{
    class IndexedNames

    {

        private string[] namelist = new string[size];

        static public int size = 10;



        public IndexedNames()

        {

            for (int i = 0; i < size; i++)

                namelist[i] = "N. A.";

        }

        public string this[int index]

        {

            get

            {

                string tmp;



                if (index >= 0 && index <= size - 1)

                {

                    tmp = namelist[index];

                }

                else

                {

                    return tmp = "";

                }



                return namelist[index];

            }

            set

            {

                if (index >= 0 && index <= size - 1)

                {

                    namelist[index] = value;

                }

            }

        }

        static void Main(string[] args)

        {

            IndexedNames names = new IndexedNames();

            names[0] = "Zara";

            names[1] = "Riz";

            names[2] = "Nuha";

            names[3] = "Asif";

            names[4] = "Davinder";

            names[5] = "Sunil";

            names[6] = "Rubic";



            for (int i = 0; i < IndexedNames.size; i++)

            {

                Console.WriteLine(names[i]);

            }

            Console.ReadKey();

        }

    }
}
