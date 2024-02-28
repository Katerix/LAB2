namespace LAB2;

public class Note
{
    public Note()
    {
        Title = "Your daily message:";
        Content = "You slay!";
    }

    public Note(string title, string content)
    {
        Title = title;
        Content = content;
    }

    public string Title { get; set; }

    public string Content { get; set; }
}