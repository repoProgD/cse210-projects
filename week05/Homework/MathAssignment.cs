public class MathAssignment : Assignment
{
    string _textbookSection;
    string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;

    }

    public string GetHomeWorkList()
    {
        return $"Read section {_textbookSection} and solve problems {_problems}";
    }

}