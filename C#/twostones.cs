using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KattisProblems
{
    class twostones
    {
        static void Main(string[] args)
        {
            int stone = int.Parse(Console.ReadLine());
            if (stone %2 == 0)
            {
                Console.WriteLine("Bob");
            }
            else
            {
                Console.WriteLine("Alice");
            }
        }
    }
}
