using System;

namespace CircleAreaAndPerimeter
{
    class CircleAreaAndPerimeter
    {
        static void Main()
        {
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"Area = {Math.PI * radius * radius}");
            Console.WriteLine($"Perimeter = {2 * Math.PI * radius}");
        }
    }
}