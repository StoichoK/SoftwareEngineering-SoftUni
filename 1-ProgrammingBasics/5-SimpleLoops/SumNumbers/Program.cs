using System;

namespace SumNumbers
{
    class SumNumbers
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < num1; i++)
            {
                int num2 = int.Parse(Console.ReadLine());

                sum = sum + num2;
            }

            Console.WriteLine(sum);
        }
    }
}
