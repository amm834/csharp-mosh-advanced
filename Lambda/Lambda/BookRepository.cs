namespace Lambda;

public class BookRepository
{
    public List<Book> GetBooks() => new List<Book>()
    {
        new Book() {Title = "I don't know", Price = 300},
        new Book() {Title = "I don't know 2", Price = 400},
    };
}