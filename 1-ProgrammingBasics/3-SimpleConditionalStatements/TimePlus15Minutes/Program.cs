using System;

namespace TimePlus15Minutes
{
    class TimePlus15Minutes
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            var hourInMinutes = hours * 60;
            var minutesSum = minutes + hourInMinutes + 15;

            var hoursPlusFiveteen = (minutesSum / 60) % 24;
            var minutesPlusFiveteen = minutesSum % 60;

            Console.WriteLine("{0}:{1:00}", hoursPlusFiveteen, minutesPlusFiveteen);
        }
    }
}
