int NumberA = new Random().Next(1, 10); // диапозон будет от 1 до 9
Console.WriteLine(NumberA);
int NumberB = new Random().Next(1, 10);
Console.WriteLine(NumberB);
int  result = (NumberA + NumberB);
Console.WriteLine($"    {NumberA}+{NumberB} = {result}");


