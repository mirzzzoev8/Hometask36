namespace Task3;
public class Book : AbstractBook, Borrowable
{
    public Book(string title, string author) : base(title, author) { }

    public void Borrow()
    {
        Console.WriteLine($"Book {Title} by {Author}  borrowed");
    }

    public void ReturnBook()
    {
        Console.WriteLine($"Book {Title} by {Author}  returnd");
    }
}
