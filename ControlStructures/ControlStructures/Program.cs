using System;

namespace ControlStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ch.4 control structures");
            int dow = 1;
            switch (dow)
            {
                case 1: 
                    Console.WriteLine("monday");
                        break;
                case 2:
                    Console.WriteLine("teusday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                case 7:
                    Console.WriteLine("sunday");
                    break;
                default: Console.WriteLine("invalid day of week");
                    break;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("loop #: " + i);
            }





            Console.WriteLine("goodbye");
        }
    }
}
