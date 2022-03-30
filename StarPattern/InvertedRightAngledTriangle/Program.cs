using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertedRightAngledTriangle
{
    class Program
    {
        static void Main(string[] args)
        {

            //loop to start with 8, this time as we will print inverted triangle
            //loop to print number of rows, here 8
            for (int row = 8; row >= 1; row--)
            {
                //loop to print columns
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                // to place cursor to next line
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
