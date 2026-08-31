CountDown(10);

void CountDown(int counter)
{
    if (counter <= 0) return;
    Console.WriteLine(counter);
    CountDown(counter - 1);
}