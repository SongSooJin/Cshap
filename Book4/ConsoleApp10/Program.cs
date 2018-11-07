using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//  C# 윈폼(Application 클래스)

namespace ConsoleApp10
{
    public class MessageFilter : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m)
        { //m.Msg는 메시지 ID
          //마우스 왼쪽, 오른쪽, 가운데 버튼동작, 마우스 휠굴림 메시지
            if (m.Msg >= 0x200 && m.Msg <= 0x20E)
            {
                Console.WriteLine("메시지: " +m.Msg);
                return true; //메시지처리했으니 더 관심가질 필요없다.
            }
            return false; //메시지를 건드리지 않았으니 응용프로그램에서 처리해라
        }
    }
    class Program : Form
    {
        static void Main(string[] args)
        {
            Program form = new Program();
            //form.Click += new EventHandler(form.Form_Click);
            //Console.WriteLine("윈도우 시작..");
            //Application.Run(form);
            //Console.WriteLine("윈도우 종료..");

            // 람다식 표현 
            form.Click += new EventHandler(
                (sender,eventArgs) => {
                    Console.WriteLine("폼 클릭 이벤트...");
                    Application.Exit();
                }
                );
            Console.WriteLine("윈도우 시작..");
            Application.Run(form);
            Console.WriteLine("윈도우 종료..");
        }

        //void Form_Click(object sender, EventArgs e) {
        //    Console.WriteLine("폼 클릭 이벤트");
        //    Application.Exit();
        //}
    }
}
