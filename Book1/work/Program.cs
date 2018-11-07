using System;

// 배열 기본 실습과제 1번
namespace ConsoleApplication3

{

    class Program

    {

        static void Main(string[] args)

        {

            //가변배열, 처음방에는 1,2 두번째방에는 1,2,3 세번째방에는 1,2,3,4

            int[][] a = { new int[] { 1,2 }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4 } };

            //3행 2열, 이차원배열 1행은 (1,2), 2행은 (3,4), 3행은 (5,6)

            int[,] b = { { 1, 2 }, { 3, 4 }, { 5, 6 } };



            //가변배열 출력

            for (int i = 0; i < 3; i++){

                foreach ( int j in a[i]) {

                    Console.Write(j + " ");

                }
            }
            Console.WriteLine("\n---------------\n");

            //이차원 배열 출력

            foreach (int i in b){

                Console.Write(i + " ");
            }
        }
    }

}