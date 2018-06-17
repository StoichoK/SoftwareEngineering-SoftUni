using System;

namespace TransportPrice
{
    class TransportPrice
    {
        static void Main()
        {
            int km = int.Parse(Console.ReadLine());
            string time = Console.ReadLine().ToLower();


            var taxi = 0.0m;
            var bus = 0.0m;
            var train = 0.0m;

            if (km > 0 && km < 20)
            {
                if (time == "day")
                {
                    taxi = 0.79m;
                }
                else if (time == "night")
                {
                    taxi = 0.90m;
                }

                taxi = 0.70m + (km * taxi);
                Console.WriteLine("{0:f2}", taxi);
            }

            else if (km >= 20 && km < 100)
            {
                if (time == "day" || time == "night")
                {
                    bus = 0.09m;
                }

                bus = km * bus;
                Console.WriteLine("{0:f2}", bus);
            }

            else if (km >= 100)
            {
                if (time == "day" || time == "night")
                {
                    train = 0.06m;
                }

                train = km * train;
                Console.WriteLine("{0:f2}", train);
            }
        }
    }
}
