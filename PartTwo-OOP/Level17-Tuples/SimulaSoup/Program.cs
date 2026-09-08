var type = AskType();
var ingredient = AskMainIngredient();
var seasoning = AskSeasoning();

Console.WriteLine("Making soup...");
DisplaySoup((type, ingredient, seasoning));

SoupType AskType()
{
    Console.Write("Choose one soap type: [soup|stew|gumbo] ");
    var choice = Console.ReadLine()!.Trim().ToLower();

    return choice switch
    {
        "soup" => SoupType.Soup,
        "stew" => SoupType.Stew,
        "gumbo" => SoupType.Gumbo
    };
}

MainIngredient AskMainIngredient()
{
    Console.Write("Choose main ingredient: [mushrooms|chicken|carrots|potatoes] ");
    var choice = Console.ReadLine()!.Trim().ToLower();

    return choice switch
    {
        "mushrooms" => MainIngredient.Mushrooms,
        "chicken" => MainIngredient.Chicken,
        "carrots" => MainIngredient.Carrots,
        "potatoes" => MainIngredient.Potatoes
    };
}

Seasoning AskSeasoning()
{
    Console.Write("Choose one soap type: [spicy|salty|sweet] ");
    var choice = Console.ReadLine()!.Trim().ToLower();

    return choice switch
    {
        "spicy" => Seasoning.Spicy,
        "salty" => Seasoning.Salty,
        "sweet" => Seasoning.Sweet
    };
}

void DisplaySoup((SoupType type, MainIngredient ingredient, Seasoning seasoning) order) 
    => Console.WriteLine($"{order.seasoning} {order.ingredient} {order.type}");

enum SoupType { Soup, Stew, Gumbo }

enum MainIngredient { Mushrooms, Chicken, Carrots, Potatoes }

enum Seasoning { Spicy, Salty, Sweet }

