using System;

namespace MethodsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to methods app");
            int nbr = GetInt("enter a whole number: ");



            Console.WriteLine("number entered: " + nbr);




            Console.WriteLine("goodbye");
        }
        private static int GetInt(String prompt)
        {
            int nbr = 0;
            Boolean success = false;
            while (!success)
            {
                Console.Write(prompt);
                try
                {
                    nbr = Int32.Parse(Console.ReadLine());
                    success = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("invalid whole number, try again");
                    throw e;
                }
            }
            return nbr;
        }

    }
}
