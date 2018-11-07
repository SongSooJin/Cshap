using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 닷넷 기본 실습 테스트(기본문법, 반복문,제어문,속성,인덱서,델리게이트,람다식,쓰레드) 8번

// 실행결과
// ID: 1, Name: Amelio Rosales
namespace work8
{
    public class Customer

    {

        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class AutoImplementedCustomerManager

    {

        static void Main()

        {
            Customer cust = new Customer();
            cust.ID = 1;
            cust.Name = "Amelio Rosales";


            Console.WriteLine(
                "ID: {0}, Name: {1}",
                cust.ID,
               cust.Name);

            Console.ReadKey();

        }

    }

}