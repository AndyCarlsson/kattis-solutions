using System;

namespace KattisProblems
{
    class twostones
    {

        /* Alice and Bob in turns take exactly two consecutive stones on the ground until 
         * there are no consecutive stones on the ground. 
         * That is, each player can take stone i and stone i+1, where 1≤i≤N−1. 
         * If the number of stone left is odd, Alice wins. Otherwise, Bob wins.*/

        static void Main(string[] args)
        {
            int stone = int.Parse(Console.ReadLine());

            if (stone %2 == 0)
            {
                Console.WriteLine("Bob");
            }
            else
            {
                Console.WriteLine("Alice");
            }
        }
    }
}
