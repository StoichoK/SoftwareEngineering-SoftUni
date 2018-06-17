using System;

namespace Harvest
{
    class Harvest
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            var totalGrapes = x * y;
            var winePerOneLiter = (0.40 * totalGrapes) / 2.5;

            if (winePerOneLiter >= z)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(winePerOneLiter)} liters.");
                Console.WriteLine($"{Math.Ceiling(winePerOneLiter - z)} liters left -> {Math.Ceiling((winePerOneLiter - z) / n)} liters per person.");
            }
            else if (winePerOneLiter < z)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(z - winePerOneLiter)} liters wine needed.");
            }
        }
    }
}
