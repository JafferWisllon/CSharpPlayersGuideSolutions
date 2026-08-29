int number;

do
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    number = Convert.ToInt32(Console.ReadLine());
}
while (number < 0 || number > 100);

Console.Clear();

Console.WriteLine("User 2, guess the number.");
int guess;
do
{
    Console.Write("What is your next guess? ");
    guess = Convert.ToInt32(Console.ReadLine());
    if (guess!= number)
        if( guess > number)
            Console.WriteLine($"{guess} is too high.");
        else
            Console.WriteLine($"{guess} is too low.");
} while (guess != number);

Console.WriteLine("You guessed the number!");