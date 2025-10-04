using System;

public class Activity
{   // Implementation detais -private class variables-
    private string _name;
    private string _description;
    private int _duration;
    private string v;

    // More implementation details: Protected methods (used by children classes only)
    protected string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    protected string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    protected int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }

    // constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public Activity(string v)
    {
        this.v = v;
    }

    // public methods (interface)
    // starting message

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"\n***** {Name} Activity *****");
        Console.WriteLine(Description + "\n");

        Console.Write("Enter lenght of the activity (seconds): ");
        Duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nStarting in a few seconds, get ready.");
        ShowCountDown();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n Nice Job, keep it up!");
        ShowSpinner(3);
        // protected string Name - protected int Duration
        Console.WriteLine($"\nYou have completed the {Name} activity, which lasted for {Duration} seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>
        {
            "|", "/", "-", "\\"
        };

        /*DateTime starttime = DateTime.Now;*/
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        // counter for the while loop
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000); // pause for 1 second
            Console.Write("\b \b"); // \b back-arrow special char. Erases the current char

            i++;

            // preventing index out of range exception
            if (i >= animationStrings.Count)
            {
                i = 0;
            }


        }

        Console.WriteLine("\nDone.");

        
    }


    public void ShowCountDown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
        Console.WriteLine("\nDone.");
    }
}