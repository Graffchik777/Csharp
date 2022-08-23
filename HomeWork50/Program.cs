// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
//------------------------------------------------------------------------------
Console.WriteLine("Номер строчки?");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("А номер столбика?");
int b = Convert.ToInt32(Console.ReadLine());
int[,] digits = new int[5, 5];

ArrayRandDigits(digits);

if (a > digits.GetLength(0) || b > digits.GetLength(1))
{
    Console.WriteLine("Нету такого числа!");
}
else
{
    Console.WriteLine($"значение элемента {a} строки и {b} столбца равно {digits[a - 1, b - 1]}");
}

PrintArray(digits);

void ArrayRandDigits(int[,] array)
{
    int i = 0; 
    while (i < array.GetLength(0))
    {
        int j = 0;
        while (j < array.GetLength(1))
        {
            array[i, j] = new Random().Next(0, 100) / 10;
            j++;
        }
        i++; 
    }
    
}

void PrintArray(int[,] array)
{
    int i = 0; 
    while (i < array.GetLength(0))
    {
        int j = 0;
        Console.Write("[ ");
        while (j < array.GetLength(1))
        {
            Console.Write(array[i, j] + " " + " ");
            j++;
        }
       i++; 
        Console.Write("]");
        Console.WriteLine("");
    }
    
}