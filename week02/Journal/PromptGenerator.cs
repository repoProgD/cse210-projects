public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "How are you feeling today?",
        "What's the most interesting thing you've done today?",
        "How are your goals going?",
        "What's something interesting you've learned recently?",
        "Is there anything that have made you feel blessed today?",
    };

    public Random _random = new Random();

    public string GetRandomPrompt()
    {
        int randomIndex = _random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }
}