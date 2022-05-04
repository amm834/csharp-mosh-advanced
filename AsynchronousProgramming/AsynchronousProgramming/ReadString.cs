public class ReadString
{
    public async Task<string> Read()
    {
        var reader = new StreamReader(@"c:\tmp\log.txt");
        var line = await reader.ReadLineAsync();
        return line;
    }
}