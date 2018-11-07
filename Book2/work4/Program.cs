using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// // 델리게이트, Delegate 기초 과제 4번
namespace work4
{
    delegate void DisplayMessage(string message);
    public class TestCustomDelegate
    {
        public static void Main()
        {
            (변수 타입 채워주세요 ) messageTarget;
            if (Environment.GetCommandLineArgs().Length > 1)
                messageTarget = ShowWindowsMessage;
            else
                messageTarget = Console.WriteLine;
            messageTarget("Hello, World!");
        }
        private static void ( //메소드 이름 채워주세요 ) (string message)
 {
 MessageBox.Show(message);
 }
}
}