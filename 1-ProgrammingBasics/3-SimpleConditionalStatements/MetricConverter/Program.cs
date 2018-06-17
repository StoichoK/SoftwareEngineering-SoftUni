using System;

namespace Metric_Converter
{
    class MetricConverter
    {
        static void Main()
        {
            double unit = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine().ToLower();
            string outputUnit = Console.ReadLine().ToLower();

            if (inputUnit == "mm")
            {
                unit /= 1000;
            }
            else if (inputUnit == "cm")
            {
                unit /= 100;
            }
            else if (inputUnit == "mi")
            {
                unit /= 0.000621371192;
            }
            else if (inputUnit == "in")
            {
                unit /= 39.3700787;
            }
            else if (inputUnit == "km")
            {
                unit /= 0.001;
            }
            else if (inputUnit == "ft")
            {
                unit /= 3.2808399;
            }
            else if (inputUnit == "yd")
            {
                unit /= 1.0936133;
            }

            if (outputUnit == "mm")
            {
                unit *= 1000;
            }
            else if (outputUnit == "cm")
            {
                unit *= 100;
            }
            else if (outputUnit == "mi")
            {
                unit *= 0.000621371192;
            }
            else if (outputUnit == "in")
            {
                unit *= 39.3700787;
            }
            else if (outputUnit == "km")
            {
                unit *= 0.001;
            }
            else if (outputUnit == "ft")
            {
                unit *= 3.2808399;
            }
            else if (outputUnit == "yd")
            {
                unit *= 1.0936133;
            }

            Console.WriteLine(unit + $" {outputUnit}");
        }
    }
}
