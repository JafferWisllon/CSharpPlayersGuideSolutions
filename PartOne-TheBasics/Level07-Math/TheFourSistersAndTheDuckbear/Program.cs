Console.Write("Total eggs: ");
var eggs = int.Parse(Console.ReadLine()!);

var perSisters = eggs / 4;
var duckbear = eggs % 4;

Console.WriteLine("Total eggs per sisters: " + perSisters); 
Console.WriteLine("Total to duckbear: " + duckbear); 