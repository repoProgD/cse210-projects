using System;

class Program
{
    static void Main(string[] args)
    {
        
        int guess;
        int attempts = 0;

        Random randomGenerator = new Random();
        int value = randomGenerator.Next(1, 101);

        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < value)
            {
                Console.WriteLine("The number is too low; guess a higher number.");
            }
            else if (guess > value)
            {
                Console.WriteLine("The number is too high; guess a lower number.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the number!");
            }
            attempts++;
        }while (guess != value);

        Console.WriteLine($"You found the number in {attempts} attempts.");

    }

}