using System;

namespace Histogram
{
    class Histogram
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;
            var p5 = 0.0;

            for (int i = 0; i < n; i++)
            {
                int n2 = int.Parse(Console.ReadLine());

                if (n2 < 200)
                {
                    p1++;
                }
                else if (n2 >= 200 && n2 <= 399)
                {
                    p2++;
                }
                else if (n2 >= 400 && n2 <= 599)
                {
                    p3++;
                }
                else if (n2 >= 600 && n2 <= 799)
                {
                    p4++;
                }
                else if (n2 >= 800)
                {
                    p5++;
                }
            }

            Console.WriteLine("{0:f2}%", p1 = p1 / n * 100);
            Console.WriteLine("{0:f2}%", p2 = p2 / n * 100);
            Console.WriteLine("{0:f2}%", p3 = p3 / n * 100);
            Console.WriteLine("{0:f2}%", p4 = p4 / n * 100);
            Console.WriteLine("{0:f2}%", p5 = p5 / n * 100);
        }
    }
}
