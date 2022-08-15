Console.Clear();

Console.Write($"Нажмите сколько хотите циферок: ");
int i = Convert.ToInt32(Console.ReadLine());
int[] arrayDigit = new int[i];

void InputDigits(int j)

{
    j = 0;
    while (j < i)
    {
        Console.Write($"Нажмите {j + 1} циферку: ");
        arrayDigit[j] = Convert.ToInt32(Console.ReadLine());
        j++;
    }

}

int Compare(int[] arrayDigit)
{
    int count = 0;
    for (int j = 0; j < arrayDigit.Length; j++)
    {
        if (arrayDigit[j] > 0)
            count += 1;
    }
    return count;
}

InputDigits(i);
Console.WriteLine(" ");
Console.WriteLine($"ПоложительнАх циферок: {Compare(arrayDigit)} ");
Console.WriteLine(" ");
