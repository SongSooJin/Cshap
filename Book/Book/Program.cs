using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 십진수를 이진수로 변환
namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int mok = int.Parse(num);
            string na = "";


            //while (mok > 0) {
            //    na = (mok % 2) + na;
            //    mok = mok / 2;
            //}

            for (int i = mok; mok>0;) {
                na = (mok % 2) + na;
                mok = mok / 2;
            }


            Console.WriteLine(na);
        }
    }
}
