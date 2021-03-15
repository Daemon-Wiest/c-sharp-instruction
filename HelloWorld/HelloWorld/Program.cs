using System; //similar to a package statement, similar to an import?

namespace HelloWorld //functions like a package
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n1 = 6;
            int n2 = 7;
            Console.WriteLine(n1 + n2);
            Console.Write("enter a whole number");
            int n3 = Int32.Parse(Console.ReadLine()); //the whole number entered by the user is a string, we need to cast it as an int, and c# doesnt have methods such as "sc.nextInt"
            Console.Write("Enter first name:  ");
            string fName = Console.ReadLine();//lower case s in string automatically translated to a capital S, maybe other way around, but they are interchangeable
            Console.Write("Enter last name:  ");
            String lName = Console.ReadLine();
            String fullName = fName +" "+ lName;
            Console.WriteLine(fullName);
            String choice = "y";
            while (choice.Equals("y")) //no equalsignorecase, method has a capital first letter
            {
                Console.Write("Enter Color Name: (r/g/b)");
                String color = Console.ReadLine();
                if (color=="r")
                {
                    Console.WriteLine("Red was picked");
                }
                else if (color == "g")
                {
                    Console.WriteLine("Green was picked");
                }
                else if (color == "b")
                {
                    Console.WriteLine("Blue was picked");
                }
                Console.WriteLine("continue? y/n");
                choice = Console.ReadLine();
            }
            Console.WriteLine("bye");
        }
    }
}
