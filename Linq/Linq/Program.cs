namespace Linq;

class Program
{
    public static void Main(string[] args)
    {
        var books = new BookRepository().GetBooks();

        // query version
        // var books = from book in books where book.Price < 10;

        var cheapBooks = books
            .Where(book => book.Price > 5)
            .OrderBy(book => book.Title)
            .Select(book => book.Title);

        foreach (var cheapBook in cheapBooks)
        {
            Console.WriteLine(cheapBook);
        }

        var pagedBooks = books
            .Skip(2)
            .Take(3);
        var totalPrice = books.Sum(book => book.Price);
        Console.WriteLine(totalPrice);
    }
}