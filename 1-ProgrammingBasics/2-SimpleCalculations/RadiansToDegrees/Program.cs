using System;

namespace RadiansToDegrees
{
    class RadiansToDegrees
    {
        static void Main()
        {
            double rad = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round((rad * 180) / Math.PI, 2));
        }
    }
}
