using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarOddPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 8; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write("* ");
                    }
                }

                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
