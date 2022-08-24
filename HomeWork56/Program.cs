// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// //-----------------------------------------------------------------

Console.Clear();

Console.WriteLine("введите размер квадратного массива");
int square = Convert.ToInt32(Console.ReadLine());
int[,] digits = new int[square, square];
int minSumma = Int32.MaxValue;
int Row = 0;

ArrayRandDigitals(digits);
PrintArray(digits);

void ArrayRandDigitals(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


void ArraySortDigits(int[,] array)
{

    for (int i = 0; i < digits.GetLength(0); i++)
    {

        int summa = 0;
        for (int j = 0; j < digits.GetLength(1); j++)
        {
            summa = summa + digits[i, j];
        }
        if (summa < minSumma)
        {
            minSumma = summa;
            Row++;
        }

    }
}

ArraySortDigits(digits);
Console.WriteLine("Самая маленькая сумма в строчке: " + (Row) + ", А сумма равна:" + (minSumma));

