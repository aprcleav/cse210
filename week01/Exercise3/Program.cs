using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";

        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            while (guess != number)
            {
                Console.Write("What is your guess? ");
                string userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);
                guessCount += 1;

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
            }

            if (guess == number)
            {
                Console.WriteLine($"You guessed it! It took you {guessCount} guesses.");
            }

        Console.Write("Do you want to play again? (yes or no) ");
        response = Console.ReadLine();
        }
        
    }
}