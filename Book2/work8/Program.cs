using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akadia.NoDelegate

{
    public delegate void MyDelegate();

    public class MyClass

    {
        
   
        public void Process()

        {

            Console.WriteLine("Process() begin");

            Console.WriteLine("Process() end");
  
        }

    }

    public class Test

    {

        static void Main(string[] args)

        {
            MyClass myClass = new MyClass();
            myClass.Process();

            MyDelegate delegate1 = myClass.Process;
            delegate1();

            Action delegate2 = myClass.Process;
            delegate2();

        }

    }

}