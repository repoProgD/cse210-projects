using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment assignment1 = new Assignment("Juan Perez", "Math");
        MathAssignment mAssigment1 = new MathAssignment("Claudio Ramirez", "Math", "7", "1-8");
        WrittingAssignment wAssignment1 = new WrittingAssignment("Mary Waters", "European History", "The causes of World War II by Mary Waters");

        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(mAssigment1.GetHomeWorkList());
        Console.WriteLine(wAssignment1.GetWritingInformation());

    }
}