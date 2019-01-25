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
                Console.Write("Enter radius: ");

                // Creating new Circle object c and calling class Validator method is number
                // to check that the input contains a number
                Circle c = new Circle(Validator.IsNumber());

                c.PrintInfo();
                run = Validator.Continue(i++);
            }
            Console.WriteLine("Press any to exit...");
            Console.ReadKey();
        }
    }
}
