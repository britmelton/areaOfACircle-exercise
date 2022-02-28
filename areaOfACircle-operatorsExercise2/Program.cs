using System;

namespace areaOfACircle_operatorsExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //In class exercise
            /*Create a method that will Calculate the area of a circle based on its radius
             * Allow a user to input a value for r in the console */

            Console.WriteLine("\n\nwhat is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);
            Console.WriteLine($"\nThe area of a circle with radius of {radius} is {area}");

        }

        public static double AreaOfCircle(double radius)
        {

            return Math.PI * radius * radius;

        }
    }
    
}
