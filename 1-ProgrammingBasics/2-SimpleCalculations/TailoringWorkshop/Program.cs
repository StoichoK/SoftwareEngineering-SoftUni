using System;

namespace TailoringWorkshop
{
    class TailoringWorkshop
    {
        static void Main()
        {
            int rectangularTables = int.Parse(Console.ReadLine());
            double lengthTables = double.Parse(Console.ReadLine());
            double widthTables = double.Parse(Console.ReadLine());

            var areaTablecloths = rectangularTables * (lengthTables + 2 * 0.30) * (widthTables + 2 * 0.30);
            var areaSquare = rectangularTables * (lengthTables / 2) * (lengthTables / 2);

            Console.WriteLine($"{(areaTablecloths * 7) + (areaSquare * 9):f2} USD");
            Console.WriteLine($"{(areaTablecloths * 7 + areaSquare * 9) * 1.85:f2} BGN");

        }
    }
}
