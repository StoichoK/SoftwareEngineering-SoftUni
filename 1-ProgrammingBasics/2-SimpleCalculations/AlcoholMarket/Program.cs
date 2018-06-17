using System;

namespace AlcoholMarket
{
    class AlcoholMarket
    {
        static void Main()
        {
            decimal whiskeyCost = decimal.Parse(Console.ReadLine());
            decimal beerLiters = decimal.Parse(Console.ReadLine());
            decimal wineLiters = decimal.Parse(Console.ReadLine());
            decimal bradniesLiters = decimal.Parse(Console.ReadLine());
            decimal whiskeyLiters = decimal.Parse(Console.ReadLine());

            decimal bradniesCost = whiskeyCost / 2m;
            decimal wineCost = bradniesCost - (bradniesCost * 0.40m);
            decimal beerCost = bradniesCost - (bradniesCost * 0.80m);

            decimal whiskerLitersCost = whiskeyLiters * whiskeyCost;
            decimal beerLitersCost = beerLiters * beerCost;
            decimal wineLitersCost = wineLiters * wineCost;
            decimal bradniesLitersCost = bradniesLiters * bradniesCost;


            decimal result = bradniesLitersCost + wineLitersCost + beerLitersCost + whiskerLitersCost;

            Console.WriteLine($"{result:f2}");
        }
    }
}
