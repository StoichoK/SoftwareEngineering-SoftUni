using System;

namespace USDtoBGN
{
    class USDtoBGN
    {
        static void Main()
        {
            decimal USD = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"{Math.Round(USD * 1.79549m, 2)} BGN");
        }
    }
}
