using System;

namespace OperationsBetweenNumbers
{
    class OperationsBetweenNumbers
    {
        static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            char operator1 = char.Parse(Console.ReadLine());

            double result = 0.0;

            if (operator1 == '+')
            {
                result = number1 + number2;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} {operator1} {number2} = {result} - even");
                }
                else if (result % 2 != 0)
                {
                    Console.WriteLine($"{number1} {operator1} {number2} = {result} - odd");
                }
            }
            else if (operator1 == '-')
            {
                result = number1 - number2;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} {operator1} {number2} = {result} - even");
                }
                else if (result % 2 != 0)
                {
                    Console.WriteLine($"{number1} {operator1} {number2} = {result} - odd");
                }
            }
            else if (operator1 == '*')
            {
                result = number1 * number2;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} {operator1} {number2} = {result} - even");
                }
                else if (result % 2 != 0)
                {
                    Console.WriteLine($"{number1} {operator1} {number2} = {result} - odd");
                }
            }
            else if (operator1 == '/')
            {
                if (number1 == 0 || number2 == 0)
                {
                    Console.WriteLine($"Cannot divide {Math.Max(number1, number2)} by zero");
                }
                else
                {
                    result = (double)number1 / number2;
                    Console.WriteLine("{0} {1} {2} = {3:f2}", number1, operator1, number2, result);
                }
            }
            else if (operator1 == '%')
            {
                if (number1 == 0 || number2 == 0)
                {
                    Console.WriteLine($"Cannot divide {Math.Max(number1, number2)} by zero");
                }
                else
                {
                    result = number1 % number2;
                    Console.WriteLine($"{number1} {operator1} {number2} = {result}");
                }
            }
        }
    }
}
