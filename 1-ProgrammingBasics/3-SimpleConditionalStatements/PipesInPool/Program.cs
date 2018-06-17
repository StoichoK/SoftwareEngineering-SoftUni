using System;

namespace PipesInPool
{
    class PipesInPool
    {
        static void Main()
        {
            int volume = int.Parse(Console.ReadLine());
            int pipe1 = int.Parse(Console.ReadLine());
            int pipe2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            var totalLitersPipe1 = pipe1 * hours;
            var totalLitersPipe2 = pipe2 * hours;
            var totalLiters = totalLitersPipe1 + totalLitersPipe2;

            if (totalLiters <= volume)
            {
                Console.WriteLine($"The pool is {Math.Truncate((totalLiters / volume) * 100)}% full. Pipe 1: {Math.Truncate((totalLitersPipe1 / totalLiters) * 100)}%. Pipe 2: {Math.Truncate((totalLitersPipe2 / totalLiters) * 100)}%.");
            }
            else if (totalLiters > volume)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1:f1} liters.", hours, totalLiters - volume);
            }

        }
    }
}
