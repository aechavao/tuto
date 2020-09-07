using System;

namespace tuto
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://docs.microsoft.com/es-es/dotnet/csharp/tutorials/intro-to-csharp/hello-world
            string aFriend = "Bill";
            Console.WriteLine(aFriend);
            aFriend = "Maira";
            Console.WriteLine(aFriend);
            string firstFriend = "Maria";
            string secondFriend = "Sage";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");
            string trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            //// error de inferencia //descomentar
            //var nombre = "Luis";
            //nombre = 3;
        }
    }
}
