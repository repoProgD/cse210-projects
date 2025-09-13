public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine(_entryText);
        Console.WriteLine($"Date: {_date}; Prompt: {_promptText}");
    }
    
    // I need to format before saving it to a file
    public override string ToString()
    {
        return ($"{_date} | {_promptText} | {_entryText}");
    }
}