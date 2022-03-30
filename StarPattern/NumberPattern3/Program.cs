using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPattern3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            for (x = 6; x >= 1; x--)
            {
                for (y = x; y >= 1; y--)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
