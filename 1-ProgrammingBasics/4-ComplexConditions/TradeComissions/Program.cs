using System;

namespace TradeComissions
{
    class TradeComissions
    {
        static void Main()
        {
            string town = Console.ReadLine().ToLower();
            decimal volume = decimal.Parse(Console.ReadLine());

            decimal percent = -1.0m;

            if (0 <= volume && volume <= 500)
            {
                if (town == "sofia")
                {
                    percent = 0.05m;
                }
                else if (town == "varna")
                {
                    percent = 0.045m; 
                }
                else if (town == "plovdiv")
                {
                    percent = 0.055m;
                }
            }

            else if (500 < volume && volume <= 1000)
            {
                if (town == "sofia")
                {
                    percent = 0.07m;
                }
                else if (town == "varna")
                {
                    percent = 0.075m;
                }
                else if (town == "plovdiv")
                {
                    percent = 0.08m;
                }
            }

            else if (1000 < volume && volume <= 10000)
            {
                if (town == "sofia")
                {
                    percent = 0.08m;
                }
                else if (town == "varna")
                {
                    percent = 0.1m;
                }
                else if (town == "plovdiv")
                {
                    percent = 0.12m;
                }
            } 
            else if (10000 < volume)
            {
                if (town == "sofia")
                {
                    percent = 0.12m;
                }
                else if (town == "varna")
                {
                    percent = 0.13m;
                }
                else if (town == "plovdiv")
                {
                    percent = 0.145m;
                }
            }

            if (percent != -1.0m)
            {
                Console.WriteLine("{0:f2}", percent * volume);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
