using System;
using System.Globalization;

namespace C_Sharp_Basics
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the Number");
            int number = Convert.ToInt32(Console.ReadLine());
            Pattern_2(number);
            Console.ReadLine();
        }
        public static void Pattern_2(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
