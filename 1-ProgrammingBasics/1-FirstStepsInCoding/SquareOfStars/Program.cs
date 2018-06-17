using System;

namespace SquareOfStars
{
    class SquareOfStars
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', number));

            for (int i = 1; i <= number - 2; i++)
            {
                Console.WriteLine("*" + new string(' ', number - 2) + "*");
            }

            Console.WriteLine(new string('*', number));
        }
    }
}
