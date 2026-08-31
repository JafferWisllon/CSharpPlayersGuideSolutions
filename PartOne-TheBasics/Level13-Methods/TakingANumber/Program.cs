int num = AskForNunber("What is the airspeed velocity of an unladen swallow? ");
Console.WriteLine(num);

int numberInRange = AskForNumberInRange("What is the airspeed velocity of an unladen swallow? ", 10, 50);
Console.WriteLine(numberInRange);
int AskForNunber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        var num = AskForNunber(text);
        if (num <= min || num >= max)
            continue;
        return num;
    }   
}