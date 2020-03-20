using System;

namespace KattisProblems
{
    class qaly
    {

        /* The first line of input contains a single integer N (1≤N≤100),
         * which is the number of periods of constant quality of life during the person’s lifetime.
           The next N lines describe the periods of life. 
           Each of these lines contains two real numbers q (0<q≤1), which is the quality of life in this period, and y (0<y≤100),
           which is the number of years in this period. */

        static void Main(string[] args)
        {

            int periods = int.Parse(Console.ReadLine());
            double output = 0;

            for (int i = 0; i < periods; i++)
            {
                string qy = Console.ReadLine();
                string[] qySplit = qy.Split(' ');

                double num1 = double.Parse(qySplit[0]);
                double num2 = double.Parse(qySplit[1]);

                output += (num1 * num2);
            }

            Console.WriteLine(output);

        }
    }
}
