using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, spaces, k = 6, i = 0, j = 0;
            spaces = k - 1;
            for (i = 1; i < k * 2; i++)
            {
                for (j = 1; j <= spaces; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j < a * 2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                
                if (i < k)
                {
                    spaces--;
                    a++;
                }
                else
                {
                    spaces++;
                    a--;
                }

                

            }
            Console.ReadLine();
        }

    }
}
