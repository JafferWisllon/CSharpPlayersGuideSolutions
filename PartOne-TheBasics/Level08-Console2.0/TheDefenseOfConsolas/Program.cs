Console.Title = "Defense of Consolas";

Console.WriteLine("Target row");
var row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Target Column: ");
var column = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Red;

var firstPosition = $"({row}, {column-1})";
var secondPosition = $"({row-1}, {column})";
var thirdPosition = $"({row}, {column+1})";
var fouthPosition = $"({row+1}, {column})";

Console.WriteLine("Deploy to:");
Console.WriteLine(firstPosition);
Console.WriteLine(secondPosition);
Console.WriteLine(thirdPosition);
Console.WriteLine(fouthPosition);

Console.Beep();