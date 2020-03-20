using System;

namespace KattisProblems
{
    class r2
    {

        /* The number S is called the mean of two numbers R1 and R2 if S is equal to 
         * (R1+R2)/2. Mirko’s birthday present for Slavko was two integers R1 and R2.
         * Slavko promptly calculated their mean which also happened to be an integer 
         * but then lost R2! Help Slavko restore R2. */

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] firstValues = input.Split(' ');

            int num1 = int.Parse(firstValues[0]);
            int num2 = int.Parse(firstValues[1]);

            int output = num2 * 2 - num1;

            Console.WriteLine(output);
        }
    }
}
