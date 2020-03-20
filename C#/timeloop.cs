using System;

namespace KattisProblems
{
    class timeloop
    {
        /* The wizard gives you a magic number, and you must count up to that number, starting at 1, saying “Abracadabra” each time.
         Output the entire wizard’s spell by counting from 1 to N, giving one number and “Abracadabra” per line.*/

        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine($"{i} Abracadabra");
            }
        }
    }
}
