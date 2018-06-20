using System;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int n2 = int.Parse(Console.ReadLine());

                if (n2 > max)
                {
                    max = n2;
                }
            }

            Console.WriteLine(max);
        }
    }
}
