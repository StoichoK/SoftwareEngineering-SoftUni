using System;

namespace CharityCampaign
{
    class CharityCampaign
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int confectioner = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            var cakesPrisePerDay = 45 * cakes;
            var wafflesPrisePerDay = 5.80 * waffles;
            var pancakesPrisePerDay = 3.20 * pancakes;
            var totalPriseAllPerDay = (cakesPrisePerDay + wafflesPrisePerDay + pancakesPrisePerDay) * confectioner;
            var totalPrise = totalPriseAllPerDay * days;
            var costs = totalPrise * 0.125;
            var result = totalPrise - costs;

            Console.WriteLine($"{result:f2}");
        }
    }
}
