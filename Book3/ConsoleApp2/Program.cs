﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 람다식(Lambda Expression) - 문형식 람다식 예제

namespace ConsoleApp2
{
    class Program
    {
        delegate int Sum(int[] arg);
        static void Main(string[] args)
        {
            Sum sumdeli = (arg) =>
            {
                int mySum = 0;
                foreach (int i in arg) mySum += i;
                return mySum;
            };

            int sum = sumdeli(new int[] { 1,2,3,4,5});
            Console.WriteLine("1+2+3+4+5 = " + sum);
        }
    }
}

//1+2+3+4+5 = 15