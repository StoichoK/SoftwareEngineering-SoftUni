using System;

namespace ExcellentOrNot
{
    class ExcellentOrNot
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());

            if (number >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
