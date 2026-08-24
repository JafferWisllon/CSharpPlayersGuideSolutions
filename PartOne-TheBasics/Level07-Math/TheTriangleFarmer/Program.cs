Console.Write("Triangle base size: ");
var baseSize = float.Parse(Console.ReadLine()!);

Console.Write("Triangle height: ");
var height = float.Parse(Console.ReadLine()!);

var area = (baseSize * height) / 2;
Console.WriteLine("Triangle area: " + area);