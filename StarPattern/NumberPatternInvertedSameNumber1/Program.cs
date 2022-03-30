using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPatternInvertedSameNumber1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            for (x = 5; x >= 1; x--)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
