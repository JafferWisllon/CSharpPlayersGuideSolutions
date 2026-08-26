var number = Convert.ToInt32(Console.ReadLine());
var isEven = (number % 2) == 0;

if (isEven)
    Console.WriteLine("Tick");
else
    Console.WriteLine("Tocks");