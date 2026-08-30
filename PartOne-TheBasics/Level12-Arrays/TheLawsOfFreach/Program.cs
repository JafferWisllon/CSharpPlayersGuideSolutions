int[] array =  new int[] {4, 51, -7, 13, -99, 15, -8, 45, 90};
int smallest = int.MaxValue;

foreach (var number in array)
{
    if (number < smallest)
        smallest = number;
}

Console.WriteLine($"The smallest number: {smallest}");

int sum = 0;
foreach (var number in array)
    sum += number;

float average = (float)sum / array.Length;
Console.WriteLine($"Average: {average}");