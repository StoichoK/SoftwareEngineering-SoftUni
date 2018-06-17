using System;

namespace Volleyball
{
    class Volleyball
    {
        static void Main()
        {
            string year = Console.ReadLine().ToLower();
            int holidaysInYear = int.Parse(Console.ReadLine());
            int weekendsInHome = int.Parse(Console.ReadLine());

            var weekendsInSofia = 48 - weekendsInHome;
            var saturdayGamesInSofia = weekendsInSofia * 3.0 / 4;

            var gamesInSofiaInHolidays = holidaysInYear * 2.0 / 3;

            var totalGames = saturdayGamesInSofia + weekendsInHome + gamesInSofiaInHolidays;

            if (year == "normal")
            {
                Console.WriteLine(Math.Truncate(totalGames));
            }

            else if (year == "leap")
            {
                var Percent = totalGames * 0.15;
                Console.WriteLine(Math.Truncate(totalGames + Percent));
            }
        }
    }
}
