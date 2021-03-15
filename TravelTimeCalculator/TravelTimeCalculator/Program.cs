using System;

namespace TravelTimeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the travel time calculator");
            Console.WriteLine("enter miles traveled: ");
            int milesTrav = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter speed (mph): ");
            int speedMph = Int32.Parse(Console.ReadLine());
            int hoursTrav = (milesTrav / speedMph);
                int remainder;
            int minutesTrav = Math.DivRem(milesTrav, speedMph, out remainder);

            Console.WriteLine("Estimated travel time \n" +
                                "--------------------");
            Console.WriteLine("Hours traveled: "+hoursTrav);
            Console.WriteLine("Minutes traveled: "+remainder);

        }
    }
}
