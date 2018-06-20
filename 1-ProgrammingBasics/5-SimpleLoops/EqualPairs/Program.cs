using System;

namespace EqualPairs
{
    class EqualPairs
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int firstCouple = int.Parse(Console.ReadLine());
            int firstCouple1 = int.Parse(Console.ReadLine());

            var sumOfFirstCoule = firstCouple + firstCouple1;

            var difference = 0;

            for (int i = 0; i < n - 1; i++)
            {
                int othersCouples = int.Parse(Console.ReadLine());
                int othersCouples1 = int.Parse(Console.ReadLine());

                var sumOfOthersCouples = othersCouples + othersCouples1;

                var diffSum = Math.Abs(sumOfOthersCouples - sumOfFirstCoule);

                if (diffSum > difference)
                {
                    difference = diffSum;
                }

                sumOfFirstCoule = sumOfOthersCouples;
            }

            if (difference == 0)
            {
                Console.WriteLine($"Yes, value={sumOfFirstCoule}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={difference}");
            }
        }
    }
}
