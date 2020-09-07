using System;

namespace tuto
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://docs.microsoft.com/es-es/dotnet/csharp/tutorials/intro-to-csharp/branches-and-loops
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Hello World! The counter is {i}");
            }

            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }

            int sum = 0;
            for (int number = 1; number < 21; number++)
            {
                if (number % 3 == 0)
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine($"The sum is {sum}");
        }
    }
}
