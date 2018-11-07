using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 어트리뷰트
namespace ConsoleApp2
{
    [AdditionalInfoAttribute("홍길동","2018/10/18", Download = "http://ojc.asia")]
    class test
    {
        static void Main() {
            Type type = typeof(test);
            foreach (Attribute attr in type.GetCustomAttributes(true)) {
                AdditionalInfoAttribute info = attr as AdditionalInfoAttribute;                if (info != null) {
                    Console.WriteLine("Name={0}, Update={1}, DownLoad={2}",
                        info.Name, info.Update, info.Download);
                }
            }
        }
    }
}
