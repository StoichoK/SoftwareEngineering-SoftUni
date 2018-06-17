using System;

namespace HotelRoom
{
    class HotelRoom
    {
        static void Main()
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());

            decimal priceStudio = 0.0m;
            decimal priceApartment = 0.0m;

            if (month == "may" || month == "october")
            {
                if (nights > 14)
                {
                    priceStudio = 50.00m - ((50.00m * 30) / 100);
                    priceApartment = 65.00m - ((65.00m * 10) / 100);
                }
                else if (nights > 7 && nights <= 14)
                {
                    priceApartment = 65.00m;
                    priceStudio = 50.00m - ((50.00m * 5) / 100);
                }
                else
                {
                    priceApartment = 65.00m;
                    priceStudio = 50.00m;
                }
            }
            else if (month == "june" || month == "september")
            {
                if (nights > 14)
                {
                    priceStudio = 75.20m - ((75.20m * 20) / 100);
                    priceApartment = 68.70m - ((68.70m * 10) / 100);
                }
                else
                {
                    priceApartment = 68.70m;
                    priceStudio = 75.20m;
                }
            }
            else
            {
                if (nights > 14)
                {
                    priceStudio = 76.00m;
                    priceApartment = 77.00m - ((77.00m * 10) / 100);
                }
                else
                {
                    priceStudio = 76.00m;
                    priceApartment = 77.00m;
                }
            }

            Console.WriteLine("Apartment: {0:f2} lv.", nights * priceApartment);
            Console.WriteLine("Studio: {0:f2} lv.", nights * priceStudio);
        }
    }
}
