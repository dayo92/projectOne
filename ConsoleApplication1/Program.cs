
using System;

namespace ConsoleApplication1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        
        
        public static void Main(string[] args)
        {
            // First excerise 
            string introductionText = "TileCost Calculator";
            
            Console.WriteLine(introductionText);
            
            Console.WriteLine("Please enter width that is needed?");
            string requestedWidth = Console.ReadLine();
            
            Console.WriteLine("Please enter length that is needed?");
            string requestedLength = Console.ReadLine();
            
            
            Console.WriteLine("Please enter the cost per flooring that is needed?");
            string costPerUnit = Console.ReadLine();
            
            Console.WriteLine("I need " + requestedWidth + " in width.");
            Console.WriteLine("I need " +  requestedLength + " in length.");
            Console.WriteLine("And the cost per unit is £" + costPerUnit + ".");
            
            Int32.TryParse(requestedWidth, out int width);
            Int32.TryParse(requestedLength, out int length);
            Int32.TryParse(costPerUnit, out int cost);
            
            int total = width * length * cost;
            
            Console.WriteLine("Total cost is £" + total);
            
            // Additional difficulty
            Console.Write("Please select what shape you would like to calculate Triangle or Cricle:");
             string selectedShape = Console.ReadLine().ToLower();
             double calculateShape;
             const double hourRate = 86;
             const double sqaureFeet = 20;
             double jobCosts;

            if (selectedShape == "cricle")
            {
                // shape 1
                Console.Write("Please enter the crilcle width: ");
                double circleWidth = Convert.ToDouble(Console.ReadLine());
            
                Console.Write("Enter the cricle length: ");
                double circleLength = Convert.ToDouble(Console.ReadLine());
            
                calculateShape = circleWidth * circleLength;
                Console.WriteLine("The cricle size is " + calculateShape);
                
                jobCosts = calculateShape / sqaureFeet * hourRate;
                Console.WriteLine("Total cost of labor for installing " + selectedShape +" is £" + jobCosts + ".");

            }
            if (selectedShape == "triangle")
            {
                // Shape 2
                Console.Write("Please enter triangle width: ");
                double circleWidth = Convert.ToDouble(Console.ReadLine());
            
                Console.Write("Please enter triangle length:");
                double circleLength = Convert.ToDouble(Console.ReadLine());
            
                calculateShape = 0.5 * circleWidth * circleLength;
                Console.WriteLine("The triangle size is " + calculateShape + ".");

               jobCosts = calculateShape / sqaureFeet * hourRate;
               
               
               Console.WriteLine("Total cost of labor for installing " + selectedShape +" is £" + jobCosts + ".");

            }
        }
    }
}