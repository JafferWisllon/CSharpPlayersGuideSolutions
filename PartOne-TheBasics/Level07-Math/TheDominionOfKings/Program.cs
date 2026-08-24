Console.Write("How many provinces: ");
int provinces = Convert.ToInt32(Console.ReadLine());

Console.Write("How many duchies: ");
int duchies = Convert.ToInt32(Console.ReadLine());

Console.Write("How many states: ");
int states = Convert.ToInt32(Console.ReadLine());

int total = (provinces * 6) + (duchies * 3) + (states * 1);
Console.WriteLine("Total score: " + total);