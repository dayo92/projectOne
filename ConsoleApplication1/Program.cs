
using System;

namespace ConsoleApplication1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("TileCost Calculator"); 
            
            Console.WriteLine("Please enter width that is needed?");
            string requestedWidth = Console.ReadLine();
            
            Console.WriteLine("Please enter length that is needed?");
            string requestedLength = Console.ReadLine();
            
            Console.WriteLine("Please enter the cost per flooring that is needed?");
            string costPerUnit = Console.ReadLine();
            
            Int32.TryParse(requestedWidth, out int width);
            Int32.TryParse(requestedLength, out int length);
            Int32.TryParse(costPerUnit, out int cost);
            
            int total = width * length * cost;
            
            Console.WriteLine("Total cost is £" + total);
            
            // Additional difficulty
            const double HOUR_RATE = 86;
            const double SQAURE_FEET = 20;
            const string TRIANGLE = "Triangle";
            const string CIRCLE = "Circle";
            
            double calculateShape = 0;
            
            
            Console.WriteLine("Please select what shape you would like to calculate: (T) for Triangle or (C) for Circle: ");
            string selectedShape = Console.ReadLine().ToLower();
            
            string shape = selectedShape == "c" ? CIRCLE : TRIANGLE;
             
            Console.Write("Please enter " + shape +" width: ");
            double shapeWidth = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Please enter " + shape + " length: ");
            double shapeLength = Convert.ToDouble(Console.ReadLine());

            if (shape == CIRCLE)
            {
                calculateShape = shapeWidth * shapeLength;
            }
            if(shape == TRIANGLE)
            {
                calculateShape = 0.5 * shapeWidth * shapeLength;
            }
            
            Console.WriteLine("The " + shape +" size is " + calculateShape);

            double jobCosts = calculateShape / SQAURE_FEET * HOUR_RATE;
            Console.WriteLine("Total cost of labor for installing " + shape +" is £" + jobCosts + ".");
        }
    }
}