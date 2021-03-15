using System;

namespace GradeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Letter Grade Converter");
            String choice = "y";
            while (choice=="y")
            {
                Console.WriteLine("enter numerical grade: ");
                int numGrade = Int32.Parse(Console.ReadLine());
                if (numGrade>88)
                {
                    Console.WriteLine("Letter Grade: A");
                }
                if (numGrade > 88)
                {
                    Console.WriteLine("Letter Grade: A");
                }
                if (numGrade > 88)
                {
                    Console.WriteLine("Letter Grade: A");
                }
                if (numGrade > 88)
                {
                    Console.WriteLine("Letter Grade: A");
                }
                if (numGrade > 88)
                {
                    Console.WriteLine("Letter Grade: A");
                }
            }

            

        }
    }
}
