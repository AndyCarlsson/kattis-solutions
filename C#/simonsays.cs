using System;

namespace KattisProblems
{
    class simonsays
    {
        /*Input starts with a line containing an integer 1≤N≤1000. 
         * Each of the next N lines is one command, of length at most 100 characters.
         * Each command is a properly-capitalized sequence of one or more words, 
         * separated by a single space between each pair of words, ending in a period. 
         * Some commands begin with “Simon says” and others may not. If a command begins with “Simon says”, 
         * there will always be another space and at least one additional word after “says”. No lines contain leading or trailing space.*/

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string output = string.Empty;
            string newOutput = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputArr = input.Split(' ');

                if (inputArr[0] == "Simon" && inputArr[1] == "says")
                {
                    for (int y = 2; y < inputArr.Length; y++)
                    {
                       output += inputArr[y] + " ";
                    }
                    newOutput = output.ToString().TrimEnd(' ');
                    Console.WriteLine(newOutput);
                }      
                output = string.Empty;
            }
        }
    }
}
