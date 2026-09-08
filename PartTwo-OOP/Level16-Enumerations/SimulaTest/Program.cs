ChestState currentState = ChestState.Locked;

while (true)
{
    Console.Write($"The chest is {currentState}. What do you want to do? ");
    var action = Console.ReadLine()!.Trim().ToLower();
    
    if (currentState == ChestState.Locked && action.Equals("unlock"))
        currentState = ChestState.Closed;
    else if (currentState == ChestState.Closed && action.Equals("open"))
        currentState = ChestState.Open;
    else if (currentState == ChestState.Open && action.Equals("close"))
        currentState = ChestState.Closed;
    else
        break;
}

enum ChestState
{
    Locked,
    Closed,
    Open,
}

