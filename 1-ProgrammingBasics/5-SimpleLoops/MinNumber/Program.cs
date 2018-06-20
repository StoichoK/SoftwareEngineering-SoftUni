using System;

namespace MinNumber
{
    class MinNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int n2 = int.Parse(Console.ReadLine());

                if (n2 < min)
                {
                    min = n2;
                }
            }

            Console.WriteLine(min);
        }
    }
}
