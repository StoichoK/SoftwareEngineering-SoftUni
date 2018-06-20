using System;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var sum = 0;
            var sum1 = 0;

            for (int i = 0; i < n; i++)
            {
                int n2 = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sum = sum + n2;
                }
                else
                {
                    sum1 = sum1 + n2;
                }
            }

            if (sum1 == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum1 - sum)}");
            }
        }
    }
}
