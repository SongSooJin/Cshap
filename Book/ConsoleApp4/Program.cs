using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Triangle1
    {
        private int width;
        private int height;
        private int area;

        public int Width {
            get { return width;}
            set { width = value;}
        }
        public int Heigth {
            get { return height; }
            set { height = value; }
        }
        public int Area {
            get { return width * height / 2;  }
        }
    }

    class Trianble2 {

        public int Width {
            get;
            set;
        }

        public int Heigth {
            get;
            set;
        }
        public int Area {
            get { return Width * Heigth / 2; }
        }

    }

    public class Test {

        static void Main() {
            Triangle1 t1 = new Triangle1();
            t1.Width = 6;
            t1.Heigth = 6;

            Console.WriteLine("밑변은 {0}",t1.Width); // 밑변은 6
            Console.WriteLine("높이는 {0}",t1.Heigth); // 높이는 6
            Console.WriteLine("면적은 {0}",t1.Area); // 면적은 18

            Trianble2 t2 = new Trianble2();
            t2.Width = 8;
            t2.Heigth = 8;

            Console.WriteLine("밑변은 {0}", t2.Width); // 밑변은 8
            Console.WriteLine("높이는 {0}", t2.Heigth); // 높이는 8
            Console.WriteLine("면적은 {0}", t2.Area); // 면적은 32
        }
    }
}
