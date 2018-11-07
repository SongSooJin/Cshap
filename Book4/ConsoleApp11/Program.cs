using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// C# 윈폼(Form클래스)

namespace ConsoleApp11
{
    class Program : Form {
        public void MouseHandler(object sender, MouseEventArgs e) {
            Console.WriteLine("Sender :" + ((Form)sender).Text);
            Console.WriteLine("Sender :" + ((Form)sender).Name);
            Console.WriteLine("X:{0}, Y:{1}",e.X,e.Y);
            Console.WriteLine("Button:{0}, Clicks:{1}",e.Button, e.Clicks);
        }
        public Program(String title) {
            this.Text = title;
            this.Name = "윈폼";
            this.MouseDown += new MouseEventHandler(MouseHandler);
        }
        static void Main(string[] args) {
            Application.Run(new Program("마우스 이벤트 예제"));
        }
    }
   
}

//실행결과 (폼에 마우스 클릭하면 콘솔창에 좌표가 찍힘)
//Sender :마우스 이벤트 예제
//Sender :윈폼
//X:48, Y:45
//Button:Left, Clicks:1