using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade: ");
        string value = Console.ReadLine();
        int grade = int.Parse(value);

        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
             letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
             letter = "E";
        }
        ;

        Console.WriteLine($"Your letter grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course.");
        }

        else
        {
            Console.WriteLine("You did not pass the course.");
        }

    }
}

