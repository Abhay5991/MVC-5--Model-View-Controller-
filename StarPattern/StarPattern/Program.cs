using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            for (int i = 1; i <= 5; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    if (k % 2 == 0)
                    {
                        Console.Write("+ ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                    k++;
                }

                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
