using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPaternInverted
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
                    Console.Write(y);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
