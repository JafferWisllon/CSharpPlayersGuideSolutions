int[] dtos = new int[5];

for (int i = 0; i < dtos.Length; i++)
{
    Console.Write("Choose a number: ");
    var number = Convert.ToInt32(Console.ReadLine());

    dtos[i] = number;
}

int[] copy = new int[5];
for(int i = 0; i < dtos.Length; i++)
    copy[i] = dtos[i];

for (int a = 0; a < copy.Length; a++)
    Console.WriteLine($"Original: {dtos[a]} - Copy: {copy[a]}");
