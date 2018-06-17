using System;

namespace _2DRectangleArea
{
    class _2DRectangleArea
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double areaA = Math.Max(x1, x2) - Math.Min(x1, x2);
            double areaB = Math.Max(y1, y2) - Math.Min(y1, y2);

            Console.WriteLine(areaA * areaB);
            Console.WriteLine(2 * (areaA + areaB));
        }
    }
}
