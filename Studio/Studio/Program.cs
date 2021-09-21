using System;

namespace Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of a circle.");
            double pi = Math.PI;
            double r = double.Parse(Console.ReadLine());
            double a = pi * r * r;
            double c = 2 * pi * r;
            double d = 2 * pi;
            Console.WriteLine("The area of a circle of radius " + r + " is: " + a);
            Console.WriteLine("The circumference of a circle of radius " + r + " is: " + c);
            Console.WriteLine("The diameter of a circle of radius " + r + " is: " + d);
            Console.WriteLine("Enter how many miles per gallon your car gets.");
            double galPerCircumference = double.Parse(Console.ReadLine()) / c;
            Console.WriteLine("It will take " + galPerCircumference + " gallons of gas for your car to go around a circle with a radius of " + r + " and a circumference of " + c + ".");

        }
    }
}
