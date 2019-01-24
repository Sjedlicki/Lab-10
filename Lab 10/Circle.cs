using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Circle
    {
        private double radius;

        public Circle(double r)
        {
            this.radius = r;
        }

        public double CalculateCircumference()
        {
            // Circumference = 2 * P * R
            double circ;
            circ = 2 * Math.PI * radius;
            return circ;
        }

        public string CalculateFormattedCircumference()
        {            
            double x = Math.Round(CalculateCircumference(), 2);
            return x.ToString();
        }

        public double CalculateArea()
        {
            // A = PI * (R * R)

            double x = Math.PI * (radius * radius);
            return x;
        }

        public string CalulateFormattedArea()
        {
            double x = Math.Round(CalculateArea(), 2);
            return x.ToString();
        }

        private string FormatNumber(double x)
        {
            string stuff = x.ToString();
            return stuff;
        }

        public void PrintInfo()
        {
            Console.WriteLine("\nRadius: "+ radius);
            //Console.WriteLine("\nCircumference: " + CalculateCircumference());
            Console.WriteLine("\nCircumference: " + CalculateFormattedCircumference());
            //Console.WriteLine("\nArea: " + CalculateArea());
            Console.WriteLine("\nArea: " + CalulateFormattedArea());
        }
    }
}
