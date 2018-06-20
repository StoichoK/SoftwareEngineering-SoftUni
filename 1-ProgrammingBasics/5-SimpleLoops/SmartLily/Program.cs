using System;

namespace SmartLily
{
    class SmartLily
    {
        static void Main()
        {
            int ageLili = int.Parse(Console.ReadLine());
            decimal priceWashMachine = decimal.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());

            var moneyForBirthday = 0.0m;
            var money = 0.0m;
            var brotherTake = 0.0m;
            var sumPriceToy = 0.0m;

            for (int i = 1; i <= ageLili; i++)
            {
                if (i % 2 != 0)
                {
                    sumPriceToy += priceToy;
                }
                else if (i % 2 == 0)
                {
                    moneyForBirthday += 10;
                    money = money + moneyForBirthday;
                    
                    brotherTake++;
                }
            }

            var totalMoney = (money + sumPriceToy) - brotherTake;

            if (totalMoney >= priceWashMachine)
            {
                Console.WriteLine("Yes! {0:f2}", totalMoney - priceWashMachine);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", priceWashMachine - totalMoney);
            }
        }
    }
}
