﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterPattern_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int a = 5;
            for (x = 1; x <= a; x++)
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
