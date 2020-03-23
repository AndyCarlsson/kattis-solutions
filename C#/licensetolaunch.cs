using System;

namespace KattisProblems
{
    class licensetolaunch
    {
        /* In order minimize the risk of a collision, 
         * Birk has made a model of how many pieces of space junk there will be for each of the next n days. 
         * He decided that he will launch his rocket on the day with the least space junk, 
         * and if there are multiple days with the same amount of space junk he of course wants to send his rocket up as early as possible.
         On the first line there is a single integer n (1≤n≤100000) the number of days for which the launch license is valid. 
         On the second line follows n integers between 0 and 109 where the i’th integer is the amount of space junk on the i’th day. 
         The first day is day i=0.*/

        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string spacejunk = Console.ReadLine();
            string[] junkArr = spacejunk.Split(' ');

            int min = int.MaxValue;
            int days = input;

            for (int i = 0; i < input; i++)
            {
                if (int.Parse(junkArr[i]) < min)
                {
                    min = int.Parse(junkArr[i]);
                    days = i;
                }
            }
            Console.WriteLine(days);
            Console.ReadLine();
        }
    }
}
