using System.Reflection;

namespace ExtensionMethods;

public static class StringExtension
{
    public static string ShortTo(this string str, int length)
    {
        if (str.Length <= 0)
            throw new TargetParameterCountException("string length should be greater than 0.");

        var words = str.Split(' ');

        return words.Length < length ? str : string.Join(' ', words.Take(length)) + "...";
    }
}