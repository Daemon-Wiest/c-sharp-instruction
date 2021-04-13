using System;

namespace bmdb_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please create a movie in the database");
            
            Console.WriteLine("Enter the movie title");
            
            Console.WriteLine("Enter the movie rating");
            Console.WriteLine("Enter the movie release year");
            Console.WriteLine("Enter the movie director");
            Movie m1 = new Movie;

            Console.WriteLine("goodbye");
        }
    }
}
