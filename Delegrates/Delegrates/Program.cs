namespace Delegrates;

class Program
{
    public static void Main(string[] args)
    {
        var processor = new PhotoProcessor();

        var filers = new PhotoFilters();
        Action<Photo> filterHandler = filers.ApplyBrightness;
        filterHandler += filers.ApplyContract;
        filterHandler += RemoveRedEye;

        processor.Process("image.png", filterHandler);
    }

    private static void RemoveRedEye(Photo photo)
    {
        Console.WriteLine("Removed red eye");
    }
}