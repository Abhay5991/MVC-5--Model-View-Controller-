﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainglePattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, i, j, count = 1;
            Console.Write("Enter number of rows:");
            number = int.Parse(Console.ReadLine());
            count = number - 1;
            for (j = 1; j <= number; j++)
            {
                #region Printing Space  
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                #endregion
                for (i = 1; i <= 2 * j - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
