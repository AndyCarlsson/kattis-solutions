using System;

namespace KattisProblems
{
    class reversebinary
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            string binaryString = "";
            
            double binaryNum = 0;
            while (inputNum != 0)
            {
                if (inputNum % 2 == 0)
                    binaryString += "0";
                else if (inputNum % 2 == 1)
                    binaryString += "1";
                inputNum /= 2;
            }

            int[] binaryIntArr = new int[binaryString.Length];

            for (int i = 0; i < binaryString.Length; i++)
            {
                binaryIntArr[i] = int.Parse(binaryString[i].ToString());
            }
            for (int i = 0; i < binaryIntArr.Length; i++)
            {
                if (binaryIntArr[i] == 1)
                {
                    binaryNum += 1 * Math.Pow(2, binaryIntArr.Length - i-1);
                }
            }
            Console.WriteLine(binaryNum);
            Console.ReadLine();
        }
    }
}
