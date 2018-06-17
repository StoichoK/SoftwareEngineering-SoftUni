using System;

namespace CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main()
        {
            decimal sum = decimal.Parse(Console.ReadLine());
            string inCurrency = Console.ReadLine().ToUpper();
            string outCurrency = Console.ReadLine().ToUpper();

            decimal value = 0.0m;

            if (inCurrency == "BGN")
            {
                value = 1m;
            }
            else if (inCurrency == "USD")
            {
                value = 1.79549m;
            }
            else if (inCurrency == "EUR")
            {
                value = 1.95583m;
            }
            else if (inCurrency == "GBP")
            {
                value = 2.53405m;
            }

            decimal value1 = 0.0m;

            if (outCurrency == "BGN")
            {
                value1 = 1m;
            }
            else if (outCurrency == "USD")
            {
                value1 = 1.79549m;
            }
            else if (outCurrency == "EUR")
            {
                value1 = 1.95583m;
            }
            else if (outCurrency == "GBP")
            {
                value1 = 2.53405m;
            }

            Console.WriteLine($"{Math.Round((sum * value) / value1, 2)} {outCurrency}");
        }
    }
}
