using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  LINQ(LET)
namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myFavor = {
                "Apple,Banana,StrawBerry",
                "Baseball,Football,Soccer",
                "Programming,Design,Assembly",
            };

            var favorite =
                from m in myFavor
                let favor = m.Split(',')
                from word in favor
                let w = word.ToLower()
                where w[0] == 'a'
                select word;

            foreach (var w in favorite) {
                Console.WriteLine("A로 시작되는 단어 : {0}",w);
            }
        }
    }
}


//A로 시작되는 단어 : Apple
//A로 시작되는 단어 : Assembly