DateTime? date = null;
DateTime date2 = date ?? date.GetValueOrDefault();

Console.WriteLine(date.GetValueOrDefault());
Console.WriteLine(date.HasValue);

Console.WriteLine(date2);