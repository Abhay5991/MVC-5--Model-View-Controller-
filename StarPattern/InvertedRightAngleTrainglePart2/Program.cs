using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertedRightAngleTrainglePart2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            for (x = 5; x >= 1; x--)
            {
                for (y = 5; y > x; y--)
                {
                    Console.Write(" ");
                }
                for (z = 1; z <= x; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
