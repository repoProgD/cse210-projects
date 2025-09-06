using System;

class Program
{
    static void Main(string[] args)
    {
        float average;
        int sum = 0;
        int maximun;
        int number = -1;
        List<int> numbers = new List<int> { };
        Console.WriteLine("Enter a list of numbers, type 0 when finished:");
        /*Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());*/

        do
        {

            Console.WriteLine("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);

        } while (number != 0);

        maximun = numbers[0];

        foreach (int num in numbers)
        {
            sum += num;
            if (num > maximun)
            {
                maximun = num;
            }

        }
        average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The maximun is {maximun}");
    }
}