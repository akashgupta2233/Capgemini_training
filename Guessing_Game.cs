using System;

class Program
{
    static void Main()
    {
        int secretNumber = 42; 
        int guess;

        Console.WriteLine("Guess the secret number!");

        do
        {
            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine());

            if (guess < secretNumber)
            {
                Console.WriteLine("Too low, try again.");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Too high, try again.");
            }

        } while (guess != secretNumber);

        Console.WriteLine("Congratulations! You guessed the secret number!");
    }
}
