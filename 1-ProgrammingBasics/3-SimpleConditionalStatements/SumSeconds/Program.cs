using System;

namespace SumSeconds
{
    class SumSeconds
    {
        static void Main()
        {

            /*
            Comment:   Solution 1 -
            */

            //int racer = int.Parse(Console.ReadLine());
            //int racer1 = int.Parse(Console.ReadLine());
            //int racer2 = int.Parse(Console.ReadLine());

            //int result = racer + racer1 + racer2;

            //if (result >= 0 && result <= 59)
            //{
            //    Console.WriteLine("0:{0:00}", result);
            //}
            //else if (result > 59 && result <= 119)
            //{
            //    Console.WriteLine("1:{0:00}", result - 60);
            //}
            //else if (result > 120 && result <= 179)
            //{
            //    Console.WriteLine("2:{0:00}", result - 120);
            //}


            /*
            Comment:   Solution 2 -
            */

            int racer = int.Parse(Console.ReadLine());
            int racer1 = int.Parse(Console.ReadLine());
            int racer2 = int.Parse(Console.ReadLine());

            var result = racer + racer1 + racer2;

            var Hour = result / 60;
            var Sec = result % 60;

            Console.WriteLine("{0}:{1:00}", Hour, Sec);
        }
    }
}
