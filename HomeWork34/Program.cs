Console.Clear();

int[] digitals = new int[19];
Console.WriteLine("Массивчик собрали: ");
Console.WriteLine(" ");

void FillingArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int PositiveNumber(int[] array)
{
    int quanity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            quanity++;
        }
    }
    return quanity;
}

FillingArray(digitals, 100, 1000);
WriteArray(digitals);
Console.WriteLine();

int quanity = PositiveNumber(digitals);
Console.WriteLine($"Чётных чисел тута: {quanity}");
Console.WriteLine(" ");

