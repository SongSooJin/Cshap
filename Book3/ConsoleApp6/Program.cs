using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// // Action 델리게이트 

namespace ConsoleApp6
{
    public delegate void ShowName();

    public class Onj {
        private string name;

        public Onj(string name) {
            this.name = name;
        }
        public void DisplayToConsole() {
            Console.WriteLine(this.name);
        }
        public void DisplayToWindow() {
            MessageBox.Show(this.name);
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            //delegate를 정의 후 호출
            Onj onj1 = new Onj("아예아예~");
            ShowName act1 = onj1.DisplayToWindow;
            act1();

            //Action delegate를 이용
            Onj onj2 = new Onj("뚜루뚜루뚜루");
            Action act2 = onj2.DisplayToWindow;
            act2();

            //Action무명 메소드 이용            Onj onj3 = new Onj("블랙핑크");
            Action act3 = delegate ()
            {
                onj3.DisplayToWindow();
            };
            act3();

            //Action delegate에 람다식 이용
            Onj onj4 = new Onj("후잉");
            Action act5 = () => onj4.DisplayToWindow();
            act5();
        }
    }
}
