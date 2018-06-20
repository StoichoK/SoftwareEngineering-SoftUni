using System;

namespace OddEvenPosition
{
    class OddEvenPosition
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double maxNEven = double.MinValue;
            double minNEven = double.MaxValue;

            double maxNOdd = double.MinValue;
            double minNOdd = double.MaxValue;

            var sumEven = 0.0;
            var sumOdd = 0.0;

            for (int i = 0; i < n; i++)
            {
                double n2 = double.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    if (maxNEven < n2)
                    {
                        maxNEven = n2;
                    }

                    if (minNEven > n2)
                    {
                        minNEven = n2;
                    }

                    sumEven += n2;

                }
                else
                {
                    if (maxNOdd < n2)
                    {
                        maxNOdd = n2;
                    }

                    if (minNOdd > n2)
                    {
                        minNOdd = n2;
                    }

                    sumOdd += n2;
                }
            }

            if (n == 0)
            {
                Console.WriteLine($"OddSum = {sumOdd}");
                Console.WriteLine($"OddMin = No");
                Console.WriteLine($"OddMax = No");
                Console.WriteLine($"EvenSum = {sumEven}");
                Console.WriteLine($"EvenMin = No");
                Console.WriteLine($"EvenMax = No");
            }
            else
            {
                if (minNEven == double.MaxValue && maxNEven == double.MinValue)
                {
                    Console.WriteLine($"OddSum = {sumOdd}");
                    Console.WriteLine($"OddMin = {minNOdd}");
                    Console.WriteLine($"OddMax = {maxNOdd}");
                    Console.WriteLine($"EvenSum = {sumEven}");
                    Console.WriteLine($"EvenMin = No");
                    Console.WriteLine($"EvenMax = No");
                }
                else if (minNOdd == double.MaxValue && maxNOdd == double.MinValue)
                {
                    Console.WriteLine($"OddSum = {sumOdd}");
                    Console.WriteLine($"OddMin = No");
                    Console.WriteLine($"OddMax = No");
                    Console.WriteLine($"EvenSum = {sumEven}");
                    Console.WriteLine($"EvenMin = {minNEven}");
                    Console.WriteLine($"EvenMax = {maxNEven}");
                }
                else
                {
                    Console.WriteLine($"OddSum = {sumOdd}");
                    Console.WriteLine($"OddMin = {minNOdd}");
                    Console.WriteLine($"OddMax = {maxNOdd}");
                    Console.WriteLine($"EvenSum = {sumEven}");
                    Console.WriteLine($"EvenMin = {minNEven}");
                    Console.WriteLine($"EvenMax = {maxNEven}");
                }
            }
        }
    }
}
