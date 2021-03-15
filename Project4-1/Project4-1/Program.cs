using System;

namespace Project4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the squares and cubes table");
            string choice = "y";
            while (choice == "y")
            {
                Console.WriteLine("Enter an integer: ");
                int userInt = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Number   " + "Squared   " + "Cubed   " + "\n"+
                                    "======   " + "======   " + "======   ");
                for (int i = 1; i <= userInt; i++)
                {

                
                int intSq = (i * i);
                int intCu = (i * i * i);
                
                    Console.WriteLine(i + "        " + intSq + "        " + intCu);
                
                }
                Console.WriteLine("continue? (y/n): ");
                choice = Console.ReadLine();
            }

            Console.WriteLine("goodbye");
        }
    }
}
