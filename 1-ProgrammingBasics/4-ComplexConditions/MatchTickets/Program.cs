using System;

namespace MatchTickets
{
    class MatchTickets
    {
        static void Main()
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            int people = int.Parse(Console.ReadLine());

            decimal transport = 0.0m;

            if (people >= 1 && people <= 4)
            {
                transport = (budget * 75) / 100;
            }
            else if (people >= 5 && people <= 9)
            {
                transport = (budget * 60) / 100;
            }
            else if (people >= 10 && people <= 24)
            {
                transport = (budget * 50) / 100;
            }
            else if (people >= 25 && people <= 49)
            {
                transport = (budget * 40) / 100;
            }
            else if (people >= 50)
            {
                transport = (budget * 25) / 100;
            }

            decimal balance = budget - transport;
            decimal needMoney = 0.0m;

            if (category == "vip")
            {
                needMoney = people * 499.99m;
            }
            else if (category == "normal")
            {
                needMoney = people * 249.99m;
            }

            if (balance > needMoney)
            {
                Console.WriteLine($"Yes! You have {balance - needMoney} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {needMoney - balance} leva." );
            }
        }
    }
}
