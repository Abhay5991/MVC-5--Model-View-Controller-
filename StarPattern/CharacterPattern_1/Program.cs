using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterPattern_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int z = 5;
            for (x = 1; x <= z; x++)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write((char)(x + 64));
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
