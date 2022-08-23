// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//-------------------------------------------------------------------------------------

Console.WriteLine("Скока строk? ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Скока столбиков?  ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[lines, columns];
ArrayRandDigits(numbers);
PrintArray(numbers);

void ArrayRandDigits(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-99, 99)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("]");
        Console.WriteLine("");
    }
}