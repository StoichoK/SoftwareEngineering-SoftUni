using System;

namespace HalfSumElement
{
    class HalfSumElement
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var sum = 0;
            int maxN = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int n2 = int.Parse(Console.ReadLine());

                if (maxN < n2)
                {
                    maxN = n2;
                }

                sum += n2;
            }

            var sumWhithoutMaxN = sum - maxN;

            if (maxN == sumWhithoutMaxN)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumWhithoutMaxN}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxN - sumWhithoutMaxN)}");
            }
        }
    }
}
