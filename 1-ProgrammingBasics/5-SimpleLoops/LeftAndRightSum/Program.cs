using System;

namespace LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int leftSum = 0;

            for (int i = 0; i < n; i++)
            {
                int n2 = int.Parse(Console.ReadLine());

                leftSum = leftSum + n2;
            }

            int rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                int n2 = int.Parse(Console.ReadLine());

                rightSum = rightSum + n2;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}
