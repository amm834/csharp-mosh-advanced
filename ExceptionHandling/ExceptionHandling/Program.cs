using ExceptionHandling;

StreamReader? reader = null;
try
{
    reader = new StreamReader(@"c:\not_found.txt");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    reader?.Dispose();
}