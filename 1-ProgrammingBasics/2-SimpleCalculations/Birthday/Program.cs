using System;

namespace Birthday
{
    class Birthday
    {
        static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            var volume = length * width * height;
            var volume2 = volume * 0.001;
            var percent2 = percent * 0.01;
            var result = volume2 * (1 - percent2);

            Console.WriteLine($"{result:f3}");
        }
    }
}
