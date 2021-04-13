using System;
using System.Collections.Generic;
using System.Text;

namespace project12_2
{
    class MyConsole
    {
        public static String getString(String prompt)
        {
            Console.WriteLine(prompt);
            String s = Console.ReadLine();  // read user entry
              // discard any other data entered on the line
            return s;
        }

        public static int getInt(String prompt)
        {
            int i = 0;
            Boolean isValid = false;
            while (!isValid)
            {
                Console.WriteLine(prompt);
                try
                {

                    i = Convert.ToInt32(Console.ReadLine());
                    isValid = true;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Error! Invalid integer. Try again.");
                }
                
            }
            return i;
        }

       /*public static int getInt(String prompt, int min, int max)
        {
            int i = 0;
            Boolean isValid = false;
            while (!isValid)
            {
                i = getInt(prompt);
                if (i <= min)
                {
                    System.out.println(
                            "Error! Number must be greater than " + min + ".");
                }
                else if (i >= max)
                {
                    System.out.println(
                            "Error! Number must be less than " + max + ".");
                }
                else
                {
                    isValid = true;
                }
            }
            return i;
        }

        public static double getDouble(String prompt)
        {
            double d = 0;
            boolean isValid = false;
            while (!isValid)
            {
                System.out.print(prompt);
                if (sc.hasNextDouble())
                {
                    d = sc.nextDouble();
                    isValid = true;
                }
                else
                {
                    System.out.println("Error! Invalid number. Try again.");
                }
                sc.nextLine();  // discard any other data entered on the line
            }
            return d;
        }

        public static double getDouble(String prompt, double min, double max)
        {
            double d = 0;
            boolean isValid = false;
            while (!isValid)
            {
                d = getDouble(prompt);
                if (d <= min)
                {
                    System.out.println(
                            "Error! Number must be greater than " + min + ".");
                }
                else if (d >= max)
                {
                    System.out.println(
                            "Error! Number must be less than " + max + ".");
                }
                else
                {
                    isValid = true;
                }
            }
            return d;
        }

    }

*/
}
}
