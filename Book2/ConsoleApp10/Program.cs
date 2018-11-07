using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 이벤트 예제
namespace EventTest
{
    delegate void MyDelegate(int i);
    class EventPublisher
    {
        public event MyDelegate ClapEvent;

        public void Clap(int num) {

            if (num % 2 == 0) {
                ClapEvent(num);
            }
            else { 

                
                Console.WriteLine("{0} : ~~~~~~~~", num);
            };
        }
    }

    class EventSub {
        public static void Main() {
            EventPublisher p = new EventPublisher();
            p.ClapEvent += new MyDelegate(Caller);

            int[] iArr = Array.ConvertAll(Console.ReadLine().Split(','), i => int.Parse(i));

            foreach (int i in iArr) {
                p.Clap(i);
            }
        }
        static void Caller(int num) {
            Console.WriteLine("{0} : 짝~~~~~~~~", num);

        }
        

    }
}
