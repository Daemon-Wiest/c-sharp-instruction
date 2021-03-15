using System;

namespace Project4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greatest Common Divisor Finder");
            string choice = "y";
            while (choice == "y")
            {
                Console.WriteLine("enter first number");
                int userInt1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("enter second number");
                int userInt2 = Int32.Parse(Console.ReadLine());
                int divisor;
                while (userInt1 != 0)
                {
                    userInt1 -= userInt2;
                }
            }

            Console.WriteLine("goodbye");
        }
    }
}
