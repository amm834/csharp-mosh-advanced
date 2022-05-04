class Program
{
    public static async Task Main(string[] args)
    {
        var readString = new ReadString();
        var line = await readString.Read();
        Console.WriteLine(line);
        Console.WriteLine("Done");
    }
}