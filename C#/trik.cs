using System;

namespace KattisProblems
{
    class trik
    {
        /*
         Borko puts three opaque cups onto the table next to each other (opening facing down) and a small ball under the leftmost cup. 
         He then swaps two cups in one of three possible ways a number of times. Mirko has to tell which cup the ball ends up under.
         Input:
         The first and only line contains a non-empty string of at most 50 characters, Borko’s moves. 
         Each of the characters is ‘A’, ‘B’ or ‘C’ (without quote marks).
         Output: 
         The index of the cup under which the ball is: 1 if it is under the left cup, 
         2 if it is under the middle cup or 3 if it is under the right cup.*/

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] inputArr = input.ToCharArray();

            int output = 1;

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] == 'A')
                {
                    if (output == 1)
                    {
                        output = 2;
                    }
                    else if (output == 2)
                    {
                        output = 1;
                    }
                    else if (output == 3)
                    {
                        output = 3;
                    } 
                }
                else if (inputArr[i] == 'B')
                {
                    if (output == 1)
                    {
                        output = 1;
                    }
                    else if (output == 2)
                    {
                        output = 3;
                    }
                    else if (output == 3)
                    {
                        output = 2;
                    }
                }
                else if (inputArr[i] == 'C')
                {
                    if (output == 1)
                    {
                        output = 3;
                    }
                    else if (output == 2)
                    {
                        output = 2;
                    }
                    else if (output == 3)
                    {
                        output = 1;
                    }
                }
            }
           
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
