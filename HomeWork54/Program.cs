//Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
//------------------------------------------------------------------------
Console.Clear();
Console.WriteLine("Скока строк?");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Скока столбиков?");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] digits = new int[lines, columns];

ArrayRandDigits(digits);
Console.WriteLine();
Console.WriteLine("Че было: ");
PrintArray(digits);

void ArraySortDigits(int[,] array)
{
    for (int i = 0; i < digits.GetLength(0); i++)
    {
        for (int j = 0; j < digits.GetLength(1) - 1; j++)
        {
            for (int sort = 0; sort < digits.GetLength(1) - 1; sort++)
            {
                if (digits[i, sort] < digits[i, sort + 1])
                {
                    int temp = 0;
                    temp = digits[i, sort];
                    digits[i, sort] = digits[i, sort + 1];
                    digits[i, sort + 1] = temp;
                }
            }
        }
    }
}




void ArrayRandDigits(int[,] array)
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
            Console.Write(array[i, j] + "  ");
        }
        Console.Write("]");
        Console.WriteLine(" ");
    }
}


ArraySortDigits(digits);
Console.WriteLine();
Console.WriteLine("Че стало: ");
PrintArray(digits);
