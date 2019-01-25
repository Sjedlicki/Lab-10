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
            bool run = true;
            while (run == true && i < 3)
            {
                bool isNumber = double.TryParse(Console.ReadLine(), out double output);
                if (i < 3)
                {
                    if (isNumber == true && i < 3)
                    {
                        return output;
                    }

                    else if (isNumber == false && i <= 3)
                    {                         
                        Console.Write("Invalid, Try again: ");
                        i++;
                    }
                }
                else
                {
                    Console.WriteLine("Maximum number of attempts reached");
                    run = false;
                }
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
                i++;
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
