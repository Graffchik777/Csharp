// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

Console.WriteLine(" ");
Console.WriteLine("Скока челенов в этом массиве?");

int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillingArray(numbers);

Console.WriteLine("Во чё вышло: ");

PrintInArray(numbers);
int summa = 0;

for (int i = 0; i < numbers.Length; i += 2)
    summa = summa + numbers[i];

Console.WriteLine($"всего {numbers.Length} чисел");
Console.WriteLine($"сумма всех челенов на нечётных местах = {summa}");
Console.WriteLine(" ");


int[] FillingArray(int[] numbers)
{
    for (int j = 0; j < numbers.Length; j++)
    {
        numbers[j] = new Random().Next(-10, 10);
    }
    return numbers;
}

int[] PrintInArray(int[] numbers)
{
    int j = 0;

    Console.WriteLine(" ");
    Console.Write("[");
    while (j < numbers.Length - 1)
    {
        Console.Write(numbers[j] + ",");
        j++;
    }
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine(" ");

    return numbers;
}

