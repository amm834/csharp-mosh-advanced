namespace Lambda;

public class Program
{
    public static void Main()
    {
        var books = new BookRepository().GetBooks();
        var cheapBooks = books.FindAll(books => books.Price < 500);
        foreach (var book in cheapBooks)
        {
            Console.WriteLine(book.Title);
            Console.WriteLine(book.Price);
        }
    }
}