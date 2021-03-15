using System;

namespace Project4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tip Calculator");
            string choice = "y";
            while (choice == "y") {
                Console.WriteLine("Cost of the meal: ");
                Double mealCost = Double.Parse(Console.ReadLine());
                Double tipFifteen = (mealCost * .15);
                Double tipTwenty = (mealCost * .20);
                Double tipTwentyFive = (mealCost * .25);
            }
            Console.WriteLine("Goodbye");
        }
    }
}
