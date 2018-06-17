using System;

namespace DanceHall
{
    class DanceHall
    {
        static void Main()
        {
            double length = double.Parse(Console.ReadLine()) * 100;
            double width = double.Parse(Console.ReadLine()) * 100;
            double sideA = double.Parse(Console.ReadLine()) * 100;

            var area = length * width;
            var areaWardrobe = sideA * sideA;
            var areaBench = area / 10;
            var freeSpace = area - areaWardrobe - areaBench;
            var dancers = freeSpace / (40 + 7000);

            Console.WriteLine(Math.Floor(dancers));
        }
    }
}
