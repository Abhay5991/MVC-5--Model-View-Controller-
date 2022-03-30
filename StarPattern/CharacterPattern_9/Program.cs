using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterPattern_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int z = 5;
            for (x = z; x >= 1; x--)
            {
                for (y = x; y >= 1; y--)
                {
                    Console.Write((char)(y + 64));
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
