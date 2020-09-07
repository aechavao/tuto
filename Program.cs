using System;

namespace tuto
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://docs.microsoft.com/es-es/dotnet/csharp/tutorials/intro-to-csharp/numbers-in-csharp
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");

            double da = 19;
            double db = 23;
            double dc = 8;
            double dd = (da + db) / dc;
            Console.WriteLine(dd);
            double dmax = double.MaxValue;
            double dmin = double.MinValue;
            Console.WriteLine($"The range of double is {dmin} to {dmax}");
            double third = 1.0 / 3.0;
            Console.WriteLine(third);
        }
    }
}
