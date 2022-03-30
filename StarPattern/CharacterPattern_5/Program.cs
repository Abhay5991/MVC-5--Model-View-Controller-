using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterPattern_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            int k = 5;
            for (x = 1; x <= k; x++)
            {
                for (y = 1; y <= k - x; y++)
                {
                    Console.Write(" ");
                }
                for (z = 1; z <= x; z++)
                {
                    Console.Write((char)(x + 64));
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
