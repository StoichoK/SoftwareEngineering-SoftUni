using System;

namespace Cinema
{
    class Cinema
    {
        static void Main()
        {

            /*
            Comment:   Solution 1 -
            */

            //string projection = Console.ReadLine().ToLower();
            //int rows = int.Parse(Console.ReadLine());
            //int columns = int.Parse(Console.ReadLine());

            //var places = rows * columns;
            //decimal priceProjection = -1.0m;


            //if (projection == "premiere")
            //{
            //    priceProjection = 12.00m;
            //}
            //else if (projection == "normal")
            //{
            //    priceProjection = 7.50m;
            //}
            //else if (projection == "discount")
            //{
            //    priceProjection = 5.00m;
            //}

            //Console.WriteLine("{0:f2}", places * priceProjection);


            /*
            Comment:   Solution 2 -
            */

            string projection = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            var places = rows * columns;
            decimal priceProjection = -1.0m;

            switch (projection)
            {
                case "premiere":
                    priceProjection = 12.00m;
                    break;
                case "normal":
                    priceProjection = 7.50m;
                    break;
                case "discount":
                    priceProjection = 5.00m;
                    break;
            }

            Console.WriteLine("{0:f2}", places * priceProjection);
        }
    }
}
