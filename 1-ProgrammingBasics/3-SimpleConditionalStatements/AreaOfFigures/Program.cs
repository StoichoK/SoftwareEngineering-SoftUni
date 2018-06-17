using System;


namespace AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main()
        {
            string figure = Console.ReadLine().ToLower();

            var result = 0.0;

            if (figure == "square")
            {
                double lengthA = double.Parse(Console.ReadLine());

                result = lengthA * lengthA;

                Console.WriteLine("{0:f3}", result);
            }
            else if (figure == "rectangle")
            {
                double lengthA = double.Parse(Console.ReadLine());
                double lengthB = double.Parse(Console.ReadLine());

                result = lengthA * lengthB;

                Console.WriteLine("{0:f3}", result);
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                result = Math.PI * radius * radius;

                Console.WriteLine("{0:f3}", result);
            }
            else if (figure == "triangle")
            {
                double lengthA = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                result = (lengthA * height) / 2;

                Console.WriteLine("{0:f3}", result);
            }

        }
    }
}
