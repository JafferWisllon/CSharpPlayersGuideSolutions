Console.WriteLine("The following items are available:");
Console.WriteLine("1 – Rope");
Console.WriteLine("2 – Torches");
Console.WriteLine("3 – Climbing Equipment");
Console.WriteLine("4 – Clean Water");
Console.WriteLine("5 – Machete");
Console.WriteLine("6 – Canoe");
Console.WriteLine("7 – Food Supplies");
Console.Write("What number do you want to see the price of? ");
var item = Convert.ToInt32(Console.ReadLine());

Console.Write("What's your name? ");
var name = Console.ReadLine();

string itemName = item switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies"
};

int price = item switch
{
    1 => 10,
    2 => 16,
    3 => 24,
    4 => 2,
    5 => 20,
    6 => 200,
    7 => 2
};

double discount = name == "Jaffer" ? 0.5 : 1;

Console.WriteLine($"{itemName} coast: {price * discount} gold");