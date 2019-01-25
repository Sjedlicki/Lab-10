using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Validator
    {
        public Validator()
        {

        }

        public static double IsNumber()
        {
            // int i is used to counter number of failed attemps (errors)
            // if i exceeds value then the loop breaks
            int i = 0;
            int x = 3;

            bool run = true;
            while (run == true && i < 3)
            {
                bool isNumber = double.TryParse(Console.ReadLine(), out double output);
                if (isNumber == true && i < 3)
                {
                    return output;
                }
                else if (i >= 2)
                {
                    Console.WriteLine("\nMaximum number of attempts reached");
                    break;
                }
                x--;
                Console.WriteLine("\n" + x + " attempts remaining");
                Console.Write("\n" + "Invalid input. Please enter a number: ");
                i = i + 1;                
                run = true;
            }
            return -1;            
        }

        // int i is used to count the number of times the person reruns the program
        public static bool Continue(int i)
        {
            Console.Write("\nWould you like to calculate another circle? (y/n) ");
            string go = Console.ReadLine().ToLower();

            bool run;
            if (go == "y")
            {                
                Console.Clear();
                run = true;
            }
            else if (go == "n")
            {
                Console.WriteLine("\nYou created " + i + " Circle objects");
                Console.WriteLine("\nThanks for using our calculator\nGoodbye!\n");
                run = false;
            }
            else
            {                
                Console.WriteLine("Invalid. Try Again!");
                run = Continue(i);
            }
            return run;
        }
    }
}