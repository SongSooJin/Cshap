using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 사칙연산
{
    //// 1번
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("두수를 입력하세요.");
    //        Console.WriteLine("예 : 3,5");
    //        string str = Console.ReadLine();
    //        str.Trim();
    //        string[] strarr = str.Split(',');

    //        if (strarr.Length != 2)
    //        {
    //            Console.WriteLine("숫자2개를 콤마로 구분해서 입력하세요~");
    //            return;
    //        }
    //        int first, second;
    //        try
    //        {
    //            first = int.Parse(strarr[0]);  //여기 채워주세요 ;
    //            second = int.Parse(strarr[1]); //여기 채워주세요 ;
    //        }
    //        catch
    //        {
    //            Console.WriteLine("입력이 잘못되었습니다.");
    //            return;
    //        }
    //        Console.WriteLine("{0} + {1} = {2}", first, second, Calc(first, second, "+"));
    //        Console.WriteLine("{0} - {1} = {2}", first, second, Calc(first, second, "-"));
    //        Console.WriteLine("{0} * {1} = {2}", first, second, Calc(first, second, "*"));
    //        Console.WriteLine("{0} / {1} = {2}", first, second, Calc(first, second, "/"));
    //    }
    //    static double Calc(int first, int second, string op)
    //    {
    //        double result = 0;
    //        switch (op)
    //        {
    //            //여기 채워주세요
    //            case "+":
    //                result = first + second;
    //                break;
    //            case "-":
    //                result = first - second;
    //                break;
    //            case "*":
    //                result = first * second;
    //                break;
    //            case "/":
    //                result = first / second;
    //                break;
    //        }
    //        return result;
    //    }
    //}

    // 버블정렬 
    class Bubble
    {
        public static void Main(string[] args)
        {
            Console.Write(",를 기준으로 정렬할 숫자를 입력하세요. : ");

            string s = Console.ReadLine();

            string[] sArr = s.Split(',');

            int[] iArr = Array.ConvertAll(sArr, i => int.Parse(i));

            int tep;

            //for (int i = 1; i < iArr.Length; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (iArr[j] > iArr[i]) {
            //            tep = iArr[j];
            //            iArr[j] = iArr[i];
            //            iArr[i] = tep;
            //        }
            //    }

            //}
            //foreach (int t in iArr) {
            //    Console.Write("{0}",t);
            //}

            int sel;
            for (int i = 0; i < iArr.Length - 1; i++) {
                sel = iArr[i];
                for (int j = i + 1; j < iArr.Length; j++) {
                    if (iArr[j] < sel) {
                        sel = iArr[j];

                        int tem = iArr[i];
                        iArr[i] = iArr[j];
                        iArr[j] = tem;
                    }
                }
            }
            foreach (int t in iArr) {
                Console.Write("{0}", t);
            }
        }
    }




    // 2번 아래와 같은 결과를 만들기 위한 for문을 완성하세요.
    //i = 0 and j = 0
    //i = 1 and j = 1
    //i = 2 and j = 2
    // 
    //using System;

    //namespace Loop
    //{
    //    class ForLoop
    //    {
    //        public static void Main(string[] args)
    //        {
    //            for (int i=0; i<3; i++)
    //            {
    //                int j = i;
    //                Console.WriteLine("i = {0} and j = {1}", i, j);
    //            }
    //        }
    //    }
    //}


    //3. 아래와 같은 결과를 만들기 위한 for문을 완성하세요.
    //C# For Loop: Iteration 1
    //C# For Loop: Iteration 2
    //C# For Loop: Iteration 3
    //C# For Loop: Iteration 4
    //C# For Loop: Iteration 5

    //using System;

    //namespace Loop
    //{
    //    class ForLoop
    //    {
    //        public static void Main(string[] args)
    //        {
    //            int i = 1;
    //            for (i = 1; i <= 5; i /= 1)
    //            {
    //                Console.WriteLine("C# For Loop: Iteration {0}", i);
    //                i++;
    //            }
    //        }
    //    }
    //}

}

