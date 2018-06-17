using System;
using System.Globalization;

namespace DaysAfterBirth
{
    class DaysAfterBirth
    {
        static void Main()
        {
            string dateStr = Console.ReadLine();

            DateTime date = DateTime.ParseExact(dateStr, "dd-MM-yyyy", CultureInfo.InvariantCulture).AddDays(999);

            Console.WriteLine(date.ToString("dd-MM-yyyy"));
        }
    }
}
