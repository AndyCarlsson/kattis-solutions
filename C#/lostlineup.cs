using System;

namespace KattisProblems
{
    class lostlineup
    {

        /* Jimmy and his friends were all standing in a lineup for ice cream when a huge gust blew them all around.
         * The friends want to keep things fair and make sure everyone gets their ice cream in the order they started with.
         * The friends do not remember the order, but each of them remember exactly how many people were between them and Jimmy.
         * Jimmy is always the first person in line. Can you help him and his friends remember the order? */

        /*Input: The first line contains a single integer n (1≤n≤100, the number of people in the line.
          The second line contains n−1 space separated integers, where di (0≤di≤n−2) is the number of people between the (i+1)th person and Jimmy.
          Output: Print a single line with n integers, the people in the order of the original lineup.*/

        static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());
            int[] keyArr = new int[n];
            int[] valueArr = new int[n];

            string d = Console.ReadLine();
            string[] dStringArr = d.Split(' ');

            if (n > 1)
            {
                for (int i = 0; i < dStringArr.Length; i++)
                {
                    keyArr[i+1] = int.Parse(dStringArr[i]);
                    valueArr[i+1] = i + 2;
                }

                keyArr[0] = 1;
                valueArr[0] = 1;

                Array.Sort(keyArr, valueArr, 1, valueArr.Length-1);        
            }
            else
            {
                valueArr[0] = 1;
            }

            for (int i = 0; i < valueArr.Length; i++)
            {
                if (i != valueArr.Length - 1)
                    Console.Write(valueArr[i] + " ");
                else
                    Console.Write(valueArr[i]);
            }
        }
    }
}
