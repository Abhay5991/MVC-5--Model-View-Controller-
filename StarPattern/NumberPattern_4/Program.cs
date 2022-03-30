using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPattern_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            for (x = 7; x >= 1; x -= 2)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
