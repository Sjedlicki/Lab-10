using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        public static int i = 1;
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Welcome to the circle calulator");

                Console.Write("Enter a radius: ");
                double.TryParse(Console.ReadLine(), out double radius);

                Circle c = new Circle(radius);

                c.PrintInfo();
                run = Continue();
            }
        }

        public static bool Continue()
        {    
            Console.Write("\nWould you like to calculate another circle? (y/n) ");
            string go = Console.ReadLine().ToLower();

            bool run1;
            if (go == "y")
            {
                i++;
                Console.Clear();
                run1 = true;
            }
            else if (go == "n")
            {
                Console.WriteLine("\nYou created " + i + " Circle objects");
                Console.WriteLine("\nThanks for using our calculator\nGoodbye!\n");
                run1 = false;
            }
            else
            {
                Console.WriteLine("Invalid. Try Again!");
                run1 = Continue();
            }
            return run1;
        }

    }
}
