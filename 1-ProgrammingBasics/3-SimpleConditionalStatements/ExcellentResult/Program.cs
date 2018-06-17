using System;

namespace ExcellentResult
{
    class ExcellentResult
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());

            if (number >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
