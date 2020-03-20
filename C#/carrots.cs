using System;

namespace KattisProblems
{
    class carrots
    {
        static void Main(string[] args)
        {
            /*In this contest, you also earn a carrot for each difficult problem you solve, or huffle-puff problems as we prefer to call them.
              You will be given the number of contestants in a hypothetical contest, the number of huffle-puff problems that people solved in the contest 
              and a description of each contestant. Now, find the number of carrots that will be handed out during the contest.*/

            string np = Console.ReadLine();

            string[] split = np.Split(' ');

            int contestants = int.Parse(split[0]);
            int output = int.Parse(split[1]);

            for (int i = 0; i <= contestants; i++)
            {
                Console.ReadLine();
            }

            Console.WriteLine(output);

        }
    }
}
