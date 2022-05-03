namespace Linq;

class BookRepository
{
    public IEnumerable<Book> GetBooks() => new List<Book>()
    {
        new Book() {Title = "PHP", Price = 20},
        new Book() {Title = "JS", Price = 30},
        new Book() {Title = "C#", Price = 10},
        new Book() {Title = "Java", Price = 2},
    };
}