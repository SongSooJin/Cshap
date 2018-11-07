#define SOUNDCARD
#define SPEAKER

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

// 어트리뷰트(Attribute)
namespace ConsoleApp1
{
    class Test
    {
        [Conditional("SOUNDCARD")]
        static void isSound() { isSpeaker(); }
        [Conditional("SPEAKER")]
        static void isSpeaker()
        {
            Console.WriteLine("음악을 들을 수 있습니다...");
        }
        static void Main()
        {
            isSound();
        }
    }
}
