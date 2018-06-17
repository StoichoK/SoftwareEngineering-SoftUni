using System;

namespace FruitShop
{
    class FruitShop
    {
        static void Main()
        {
            string fruits = Console.ReadLine().ToLower();
            string dayOfWeek = Console.ReadLine().ToLower();
            decimal quantity = decimal.Parse(Console.ReadLine());

            decimal price = 0.0m;

            if (dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday" || dayOfWeek == "thursday" || dayOfWeek == "friday")
            {
                switch (fruits)
                {
                    case "banana":
                        price = 2.50m;
                        break;
                    case "apple":
                        price = 1.20m;
                        break;
                    case "orange":
                        price = 0.85m;
                        break;
                    case "grapefruit":
                        price = 1.45m;
                        break;
                    case "kiwi":
                        price = 2.70m;
                        break;
                    case "pineapple":
                        price = 5.50m;
                        break;
                    case "grapes":
                        price = 3.85m;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            else if (dayOfWeek == "saturday" || dayOfWeek == "sunday")
            {
                switch (fruits)
                {
                    case "banana":
                        price = 2.70m;
                        break;
                    case "apple":
                        price = 1.25m;
                        break;
                    case "orange":
                        price = 0.90m;
                        break;
                    case "grapefruit":
                        price = 1.60m;
                        break;
                    case "kiwi":
                        price = 3.00m;
                        break;
                    case "pineapple":
                        price = 5.60m;
                        break;
                    case "grapes":
                        price = 4.20m;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            else
            {
                Console.WriteLine("error");
            }

            Console.WriteLine("{0:f2}", price * quantity);
        }
    }
}
