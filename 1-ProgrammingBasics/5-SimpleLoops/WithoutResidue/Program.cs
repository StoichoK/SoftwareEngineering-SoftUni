using System;

namespace WithoutResidue
{
    class WithoutResidue
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var p1 = 0d;
            var p2 = 0d;
            var p3 = 0d;

            for (int i = 0; i < n; i++)
            {
                int n2 = int.Parse(Console.ReadLine());

                if (n2 % 2 == 0)
                {
                    p1++;
                }
                if (n2 % 3 == 0)
                {
                    p2++;
                }
                if (n2 % 4 == 0)
                {
                    p3++;
                }
            }

            Console.WriteLine("{0:f2}%", p1 / n * 100);
            Console.WriteLine("{0:f2}%", p2 / n * 100);
            Console.WriteLine("{0:f2}%", p3 / n * 100);
        }
    }
}
