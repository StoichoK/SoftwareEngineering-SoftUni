using System;

namespace BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            var bonus = 0.0;

            if (number <= 100)
            {
                bonus = 5;
            }
            else if (number > 100 && number <= 1000)
            {
                bonus = number * 0.2;
            }
            else if (number > 1000)
            {
                bonus = number * 0.1;
            }

            var bonus1 = 0.0;

            if (number % 2 == 0)
            {
                bonus1 = 1;
            }
            else if (number % 10 == 5)
            {
                bonus1 = 2;
            }

            Console.WriteLine(bonus + bonus1);
            Console.WriteLine(number + bonus + bonus1);
        }
    }
}
