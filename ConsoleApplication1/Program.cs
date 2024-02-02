
using System;

namespace ConsoleApplication1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            const double HOUR_RATE = 86;
            const double SQUARE_FEET = 20;
           
            const char SHAPE_CIRCLE = 'c';
            const char SHAPE_TRIANGLE = 't';
            const char SHAPE_RECTANGLE = 'r';
            
            Console.WriteLine("TileCost Calculator"); 
            
            Console.WriteLine("Please select what shape you would like to calculate: (T) for Triangle, (R) for Rectangle or (C) for Circle: ");
            string selectedShape = Console.ReadLine().ToLower();
            char shapeCharacter = selectedShape.ToCharArray()[0];
            double calculateShape = 0;

            if(SHAPE_RECTANGLE != shapeCharacter && SHAPE_CIRCLE != shapeCharacter && SHAPE_TRIANGLE != shapeCharacter)
            {
                Console.WriteLine("Invalid shape selected.");
                return;
            }
            
            if (SHAPE_CIRCLE == shapeCharacter)
            {
                Console.Write("Please enter Circle radius: ");
                string requestedRadius = Console.ReadLine();
                
                Int32.TryParse(requestedRadius, out int radius);
                
                calculateShape = Math.PI * radius * radius;
            }
            if(SHAPE_TRIANGLE == shapeCharacter)
            {
                Console.Write("Please enter Triangle base: ");
                string requestedBase = Console.ReadLine();
                Console.Write("Please enter Triangle height: ");
                string requestedHeight = Console.ReadLine();
                
                Int32.TryParse(requestedBase, out int baseNeeded);
                Int32.TryParse(requestedHeight, out int height);
                
                calculateShape = 0.5 * baseNeeded * height;
            }
            if(SHAPE_RECTANGLE == shapeCharacter)
            {
                Console.Write("Please enter Rectangle width: ");
                string requestedWidth = Console.ReadLine();
                Console.Write("Please enter Rectangle length: ");
                string requestedLength = Console.ReadLine();
                
                Int32.TryParse(requestedWidth, out int width);
                Int32.TryParse(requestedLength, out int length);
                
                calculateShape = width * length;
            }
            
            Console.WriteLine("The selected shape size is " + Math.Round(calculateShape,2) + ".");

            Console.WriteLine("Please enter the cost per unit of flooring: ");
            string costPerUnit = Console.ReadLine();
            Int32.TryParse(costPerUnit, out int cost);

            double totalCost = SQUARE_FEET * cost;
            Console.WriteLine("Total cost for the flooring is £" + Math.Round(totalCost,2));

            double jobCosts = calculateShape / SQUARE_FEET * HOUR_RATE;
            Console.WriteLine("Total cost of labor for installing the flooring is £" + Math.Round(jobCosts,2));
            
            Console.WriteLine("The combined total cost will be £" + Math.Round(jobCosts + totalCost,2));

        }
    }
}