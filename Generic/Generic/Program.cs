namespace Generic;

class Program
{
    public static void Main(string[] args)
    {
        var utilities = new Utilities<int>();
        var max = utilities.Max(1, 2);

        var book = new Book();
        book.Price = 200;

        var discount = new DiscountCalculator<Product>();
        Console.WriteLine($"Discount is {discount.CalculateDicount(book)}");

        var intStruct = new Nullable<int>(5);
        Console.WriteLine(intStruct.GetDefaultOrNull());
    }
}