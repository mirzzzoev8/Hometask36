namespace Task3;
public abstract class AbstractBook : Readable
{
    protected string Title { get; set; }
    protected string Author { get; set; }

    public AbstractBook(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void Read()
    {
        Console.WriteLine($"Read the book: {Title} by {Author}");
    }
}

