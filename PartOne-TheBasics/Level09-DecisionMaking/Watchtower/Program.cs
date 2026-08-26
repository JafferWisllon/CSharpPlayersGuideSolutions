Console.Write("x: ");
var x = Convert.ToInt32(Console.ReadLine());

Console.Write("y: ");
var y = Convert.ToInt32(Console.ReadLine());

if (x < 0)
{
    if(y < 0)
        Console.WriteLine("The enemy is to the NW");
    else if(y == 0)
        Console.WriteLine("The enemy is to the W");
    else
        Console.WriteLine("The enemy is to the SW");
}
else if (x == 0)
{
    if(y > 0)
        Console.WriteLine("The enemy is to the N");
    else if(y == 0)
        Console.WriteLine("The enemy is here");
    else
        Console.WriteLine("The enemy is to the S");
}
else
{
    if(y > 0)
        Console.WriteLine("The enemy is to the NE");
    else if(y == 0)
        Console.WriteLine("The enemy is to the E");
    else
        Console.WriteLine("The enemy is to the SE");
}