using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraingleBoarderOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            for (x = 1; x <= 5; x++)
            {
                for (y = x; y < 5; y++)
                {
                    Console.Write(" ");
                }
                for (y = 1; y <= (2 * x - 1); y++)
                {
                    if (x == 5 || y == 1 || y == (2 * x - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
