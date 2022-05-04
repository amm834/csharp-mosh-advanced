namespace ExceptionHandling;

class Program
{
    public static void Main(string[] args)
    {
        var api = new YoutubeWebService();
        api.FetchApi();
    }
}