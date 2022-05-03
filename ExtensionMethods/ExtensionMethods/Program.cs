
namespace ExtensionMethods;

class Program
{
    public static void Main(string[] args)
    {
        var post = "This post is really long long long long long long long post";
        var shortedOne = post.ShortTo(5);
        Console.WriteLine(shortedOne);
    }
}