using System;

class Program
{
    static void Main(string[] args)
    {
        
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2023;
        job1._endYear = 2025;

        /*job1.Display();*/

        Job job2 = new Job();
        job2._jobTitle = "Web Developer";
        job2._company = "Google";
        job2._startYear = 2022;
        job2._endYear = 2025;

        /*Console.WriteLine(job2._company);*/


        Resume myResume = new Resume();
        myResume._name = "Diego Ledesma";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        myResume.Display();
    }
}
