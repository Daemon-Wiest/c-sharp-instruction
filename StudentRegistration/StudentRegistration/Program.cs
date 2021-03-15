using System;

namespace StudentRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student registration Form");
            Console.Write("Enter first name: ");
            string fName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lName = Console.ReadLine();
            Console.Write("Enter year of birth: ");
            int bYear = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Welcome " + fName + " " + lName + "!"+ "\n"+
                                "Your registration is complete."+"\n"+
                                "Your temporary password is: "+ fName+"*"+bYear);

        }
    }
}
