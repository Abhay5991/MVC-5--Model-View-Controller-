using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondShape
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, count = 1, number;
            Console.Write("Enter number of rows:");
            number = int.Parse(Console.ReadLine());
            count = number - 1;
            for (j = 1; j <= number; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (i = 1; i <= 2 * j - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            count = 1;
            for (j = 1; j <= number - 1; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (i = 1; i <= 2 * (number - j) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}


//using System;
					
//public class DiamondTriangleProgram
//{
//    public static void Main()
//    {
//        Console.WriteLine("Program for displaying pattern of *.");
//        Console.Write("Enter the maximum number of *: (Top to Middle line)");
//        int n = Convert.ToInt32(Console.ReadLine());

//        //loop to print first half or equilateral triangle
//        for (int i = 1; i <= n; i++)
//        {
//            //for loop to add space
//            for (int j = 1; j <= (n - i); j++)
//            {
//                Console.Write(" ");
//            }
//            //for loop to print *, for each line 
//            //k < i *2
//            //so for example, if i =1, it will print star for 1 times, as loop will work  until k < 2, that is 1 time
//            // when i = 2, condition will be k < 4, means it will print star for 3 times
//            // and so on.
//            for (int k = 1; k < i * 2; k++)
//            {
//                Console.Write("*");
//            }
//            Console.WriteLine();
//        }

//        //loop to print inverted equilateral triangle
//        for (int i = n - 1; i >= 1; i--)
//        {
//            //for loop to add space
//            for (int j = 1; j <= (n - i); j++)
//            {
//                Console.Write(" ");
//            }
//            //for loop to print *, for each line 
//            //k < i *2
//            //so for example, if i =1, it will print star for 1 times, as loop will work  until k < 2, that is 1 time
//            // when i = 2, condition will be k < 4, means it will print star for 3 times
//            // and so on.
//            for (int k = 1; k < i * 2; k++)
//            {
//                Console.Write("*");
//            }
//            Console.WriteLine();
//        }

//        Console.WriteLine();
//    }
////}
