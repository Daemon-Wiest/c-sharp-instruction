using System;

namespace project12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The wizard inventory game \n");
            String[] Inventory = new string[4];
                Inventory[0] = "wooden staff";
                Inventory[1] = "wizard hat";
                Inventory[2] = "cloth shoes";
                Inventory[3] = "potion of invisibility";
                String[] MiscItems = new string[4];
                MiscItems[0] = "shining sword";
                MiscItems[1] = "wizard robes";
                MiscItems[2] = "a cool rock";
                MiscItems[3] = "some kinda rat thing";
            
            
            Console.WriteLine("Do you wish to mess about with the wizards inventory? y/n");
            string choice = Console.ReadLine();
            while (choice != "n")
            {
                Console.WriteLine("COMMAND MENU" + "\n" + "show - Show all items" + "\n" + "grab - Grab an item" + "\n" + "edit - Edit an item" + "\n" + "drop - Drop an item" + "\n" + "exit - Exit program");
                
                    String CaseChoice = (Console.ReadLine());
                switch (CaseChoice)
                {
                    case "show":
                        for (int i = 0; i < Inventory.Length; i++)
                        {
                            String item = (string)Inventory.GetValue(i);
                            int itemnumber = i + 1;
                            Console.WriteLine($"{itemnumber}. {item}");
                        }
                        break;
                    case "grab":
                        for (int i = 0; i < MiscItems.Length; i++)
                        {
                            Random randitem = new Random();
                            int grounditem = randitem.Next(MiscItems.Length);
                            
                            Console.WriteLine($"Name: {MiscItems[grounditem]} \n {MiscItems[grounditem]} was added");
                        }
                        break;
                    case "edit":
                        int number = MyConsole.getInt("Number: ");
                        if (number < 1 || number > Inventory.Length)
                        {
                            Console.WriteLine("Invalid number entered");
                        }
                        else
                        {
                            Console.WriteLine("Item Number: " + number);
                            Console.WriteLine("Updated Name: ");
                            Inventory[number-1] = Console.ReadLine();
                            Console.WriteLine($"Item number {number} is now named {Inventory[number-1]}");
                        }

                        break;
                    case "drop":
                        number = MyConsole.getInt("Number: ");
                        Console.WriteLine($"Item number {number} was dropped");
                        Inventory[number-1] = null;
                        break;
                    case "exit":
                        choice = "n";
                        break;

                    default:
                        Console.WriteLine("please enter a valid command");
                        break;
                }
            }
            
        }
    }
}
