using System;

namespace KattisProblems
{
    class railroad2
    {
        /* Write a program that outputs if it is possible to build a railroad that does not require any bumpers 
         * (i.e., which does not have any dead-end tracks).
         The input consists of a single test case with two integer numbers X (0≤X≤1000) and Y (0≤Y≤1000) 
         denoting the number of level junctions and switches, respectively. You may assume that Theta has sufficiently many 
         straight and curved pieces as well as bridges.
         Output possible if she can build a closed track using all level junctions and all switches without any dead ends, or impossible otherwise.*/
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string[] inputArr = input.Split(' ');

            int x = int.Parse(inputArr[0]);
            int y = int.Parse(inputArr[1]);

            if (x % 2 == 0)
            {
                if (y % 2 == 0)
                {
                    Console.WriteLine("possible");
                }
                else if (y % 2 != 0)
                {
                    Console.WriteLine("impossible");
                }
            }

            else if (x % 2 != 0)
            {
                if (y % 2 == 0)
                {
                    Console.WriteLine("possible");
                }
                else if (y % 2 != 0)
                {
                    Console.WriteLine("impossible");
                }
            }
        }
    }
}
