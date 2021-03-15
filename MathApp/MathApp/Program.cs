using System;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the math app");
            Console.WriteLine("Random #, dice roll");
            String choice = "y";
            Random r = new Random();
            while (choice == "y")
            {
                int die = r.Next(1, 7);//inclusive of the min, exclusive of the max, max of 7 lets the roll go up to 6
                Console.WriteLine(die);
                Console.WriteLine("Again? y/n");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Lets round some numbers");
            double d1 = 57.123456789;
            Console.WriteLine(d1);
            //format to 2 decimal places
            Console.WriteLine(Math.Round(d1, 2));
            //format to 5 decimal places
            Console.WriteLine(Math.Round(d1, 5));
            //format to 6 decimal places
            Console.WriteLine(Math.Round(d1, 6));
            Console.WriteLine("lets format a currency");
            double price = 59.78;
            Console.WriteLine(price.ToString("C")); //tostring ops differently, but similar concept. 
                                                    


            Console.WriteLine("Bye");
        }
    }
}
