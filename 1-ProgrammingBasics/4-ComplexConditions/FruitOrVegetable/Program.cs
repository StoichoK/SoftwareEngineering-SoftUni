using System;

namespace FruitOrVegetable
{
    class FruitOrVegetable
    {
        static void Main()
        {
            string product = Console.ReadLine().ToLower();

            switch (product)
            {
                // FRUIT
                case "banana":
                    Console.WriteLine("fruit");
                    break;
                case "apple":
                    Console.WriteLine("fruit");
                    break;
                case "kiwi":
                    Console.WriteLine("fruit");
                    break;
                case "cherry":
                    Console.WriteLine("fruit");
                    break;
                case "lemon":
                    Console.WriteLine("fruit");
                    break;
                case "grapes":
                    Console.WriteLine("fruit");
                    break;

                // VEGETABLES 
                case "tomato":
                    Console.WriteLine("vegetable");
                    break;
                case "cucumber":
                    Console.WriteLine("vegetable");
                    break;
                case "pepper":
                    Console.WriteLine("vegetable");
                    break;
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;

                // UNKNOWN
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
