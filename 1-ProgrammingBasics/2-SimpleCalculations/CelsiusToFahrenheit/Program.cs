using System;

namespace CelsiusToFahrenheit
{
    class CelsiusToFahrenheit
    {
        static void Main()
        {
            double celsius = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round((celsius * 1.8) + 32, 2));
        }
    }
}
