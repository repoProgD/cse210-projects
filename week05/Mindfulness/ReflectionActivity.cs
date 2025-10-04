class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    // Constructor -> base Constructor -> Activity(name, description) => base(name, description)
    public ReflectionActivity() :
    base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();

        Console.WriteLine("\n Once you have something in mind, press any key to continue...");
        Console.ReadKey();

        Console.WriteLine("\nNow think about the following related questions");
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.Write($"\n {question}");
            ShowSpinner(5);
            Console.WriteLine();

        }

        DisplayEndingMessage();
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int i = random.Next(_questions.Count);
        return _questions[i];
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        return _prompts[i];
    }


    private void DisplayPrompt()
    {
        string selectedPrompt = GetRandomPrompt();
        Console.WriteLine("\n Consider the next prompt: \n");
        Console.WriteLine($"*****  {selectedPrompt}   *****");
    }

}