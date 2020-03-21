using System;

namespace KattisProblems
{
    class pet
    {
        /* In the popular show “Dinner for Five”, five contestants compete in preparing culinary delights.
         * Every evening one of them makes dinner and each of other four then grades it on a scale from 1 to 5.
         * The number of points a contestant gets is equal to the sum of grades they got. The winner of the show is of
         * course the contestant that gets the most points.
           Write a program that determines the winner and how many points they got.*/

        static void Main(string[] args)
        {
            int winnerPoints = 0;
            int winner = 0;

            for (int i = 1; i <= 5; i++)
            {
                string points = Console.ReadLine();
                string[] pointsArr = points.Split(' ');

                int result = int.Parse(pointsArr[0]) + int.Parse(pointsArr[1]) + int.Parse(pointsArr[2]) + int.Parse(pointsArr[3]);

                if (result > winnerPoints)
                {
                    winnerPoints = result;
                    winner = i;
                }
            }

            Console.WriteLine($"{winner} {winnerPoints}");
            Console.ReadLine();

        }
    }
}
