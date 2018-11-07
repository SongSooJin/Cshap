
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  System.EventHandler 델리게이트를 통한 이벤트 처리 9번 고치기 
namespace ConsoleApp11
{
    //이벤트 게시자 클래스, 이벤트를 발생시키는 객체
    class EventPublisher
    {
        //public delegate void MyEventHandler();
        public event EventHandler MyEvent;
        public void Do()
        {
            //이벤트 가입자가 있는지 확인
            if (MyEvent != null)
            {
                MyEvent(null, null); //이벤트 발생
            }

        }
    }
    class Subscriber
    {
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();
            //구독자의 이벤트 처리 메소드를 등록
            //이벤트를 발생하면 호출될 메소드를 정의, 여기서는 doAction 메소드 호출
            //MyEvent 라는 이벤트에 이벤트핸들러인 델리게이트를 통해 메소드를 등록
            //MyEvent 라는 이벤트가 발생하면 델리게이트가 참조하는 메소드 doAction() 실행

            //c#1.0에서의 이벤트에 가입하는 방법 
            p.MyEvent += new EventHandler(doAction);

            //c#2.0이상에서 이벤트 가입하는 방법
            p.MyEvent += doAction;

            //c#2.0이상에서 delegate를 이용한 무명함수로 이벤트에 가입하는 방법
            p.MyEvent += delegate(object sender, EventArgs e){
                Console.WriteLine("MyEvent 라는 이벤트 발생");
            };

            //c#3.0 이후 람다식을 이용한 무명함수로 이벤트에 가입하는 방법
            p.MyEvent += (sender, e) => {
                Console.WriteLine("MyEvent 라는 이벤트 발생");
            };


          
            p.Do();
        }
        //MyEvent 라는 이벤트가 발생하면 호출되는 메소드
        static void doAction(object sender, EventArgs e)
        {
            Console.WriteLine("MyEvent 라는 이벤트 발생...");
        }
    }
}
