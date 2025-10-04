public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    // Constructor -> base Constructor -> Activity(name, description) => base(name, description)
    public ListingActivity() :
    base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>

        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();

        Console.WriteLine("\n List as many items as you can until time runs out.");
        Console.WriteLine($"*****  {_prompts}  *****");
        Console.WriteLine("\n You may start");
        ShowCountDown();

        List<string> list = GetListFromUser();

        _count = list.Count();

        Console.WriteLine($"\n There are {_count} items in your list");
        ShowSpinner(5);

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        return _prompts[i];
    }

    private List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        Console.WriteLine("\n Please list your items. Then, press any key after each one of them.");

        while (DateTime.Now < endTime)
        {
            Console.Write("-> ");
            string input = Console.ReadLine();
            responses.Add(input);
        }

        return responses;
    }

}