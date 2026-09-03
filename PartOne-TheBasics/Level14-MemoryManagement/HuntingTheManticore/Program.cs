int manticoreInitialPoints = 10, manticoreCurrentPoints = 10;
int cityInitialPoints = 15, cityCurrentPoints = 15;
int rounds = 1;

Console.Write("Player 1, how far away from the city do you want to station the Manticore?(0-100) ");
var cityDistance = Convert.ToInt32(Console.ReadLine());

Console.Clear();

Console.WriteLine("Player 2, it is your turn.");
while (manticoreCurrentPoints > 0 && cityCurrentPoints > 0)
{
    Console.WriteLine("-----------------------------------------------------------");
    int damage;
    Console.WriteLine($"STATUS: Round: {rounds} City: {cityCurrentPoints}/{cityInitialPoints} Manticore: {manticoreCurrentPoints}/{manticoreInitialPoints}");
    if (rounds % 3 == 0 && rounds % 5 == 0)
        damage = 10;
    else if (rounds % 3 == 0 || rounds % 5 == 0)
        damage = 3;
    else
        damage = 1;
    Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");
    
    Console.Write("Enter desired cannon range: ");
    var target = Convert.ToInt32(Console.ReadLine());

    if (target > cityDistance)
        Console.WriteLine("That round OVERSHOT the target.");
    else if (target < cityDistance)
        Console.WriteLine("That round FELL SHORT of the target.");
    else
    {
        Console.WriteLine("That round was a DIRECT HIT!");
        manticoreCurrentPoints -= damage;
    }

    if (manticoreCurrentPoints > 0)
        cityCurrentPoints -= 1;

    rounds++;
}

Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");