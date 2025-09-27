public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();

    }

    public void AddComment(Comment c)
    {
        _comments.Add(c);
    }

    public int CountComments()
    {
        return _comments.Count;
    }

    public string GetDisplayText()
    {
        string info = $"Title: {_title}\nAuthor: {_author}\nLength: {_length} seg\nComments: {CountComments()}\n";

        foreach (Comment c in _comments)
        {
            info += "- " + c.GetDisplayText() + "\n";
        }

        return info;
 
    }
    

}