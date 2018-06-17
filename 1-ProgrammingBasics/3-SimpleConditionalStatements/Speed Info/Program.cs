using System;


namespace Speed_Info
{
    class Speed_Info
    {
        static void Main()
        {
            double speedNumber = double.Parse(Console.ReadLine());

            if (speedNumber <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (speedNumber > 10 && speedNumber <= 50)
            {
                Console.WriteLine("average");
            }
            else if (speedNumber > 50 && speedNumber <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (speedNumber > 150 && speedNumber <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
