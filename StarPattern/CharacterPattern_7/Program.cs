using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterPattern_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int a = 5;
            for (x = a; x >= 1; x--)
            {
                for (y = a; y >= x; y--)
                {
                    Console.Write((char)(y + 64));
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
