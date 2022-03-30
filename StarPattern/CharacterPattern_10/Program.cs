using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterPattern_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int z = 6;
            for (x = 1; x <= z; x++)
            {
                for (y = 1; y <= z - x; y++)
                {
                    Console.Write(" ");
                }
                for (y = 1; y <= x; y++)
                {
                    Console.Write((char)(y + 64));
                }
                for (y = x - 1; y >= 1; y--)
                {
                    Console.Write((char)(y + 64));
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
