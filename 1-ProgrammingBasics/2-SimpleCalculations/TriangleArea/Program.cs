using System;

namespace TriangleArea
{
    class TriangleArea
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine($"Triangle area = {Math.Round((side * height) / 2, 2)}");
        }
    }
}
