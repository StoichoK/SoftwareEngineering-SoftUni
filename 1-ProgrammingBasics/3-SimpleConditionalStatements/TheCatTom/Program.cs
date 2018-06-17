using System;

namespace TheCatTom
{
    class TheCatTom
    {
        static void Main()
        {
            int restDays = int.Parse(Console.ReadLine());

            int workDays = 365 - restDays;

            int minutesGameInRestDays = 127 * restDays;
            int minutesGameInWorkDays = 63 * workDays;
            int totalMinutesGamePerYear = minutesGameInRestDays + minutesGameInWorkDays;

            if (totalMinutesGamePerYear > 30000)
            {
                var result = totalMinutesGamePerYear - 30000;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{result / 60} hours and {result % 60} minutes more for play");
            }
            else if (totalMinutesGamePerYear < 30000)
            {
                var result = 30000 - totalMinutesGamePerYear;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{result / 60} hours and {result % 60} minutes less for play");
            }

        }
    }
}
