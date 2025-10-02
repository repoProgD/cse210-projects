public class WrittingAssignment : Assignment
{
    string _title;

    public WrittingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{GetStudentName()} , {GetTopicName()}, {_title}";
    }

}