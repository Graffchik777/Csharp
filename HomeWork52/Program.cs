//Задача 52. 
//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//----------------------------------------------------------------------

Console.WriteLine("Скока строчек?");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Скока столбиков?");
int b = Convert.ToInt32(Console.ReadLine());

int[,] digits = new int[a, b];
ArrayRandDigits(digits);



int j = 0;
while (j < digits.GetLength(1))
{
    int i = 0;
    double avarage = 0;
    while (i < digits.GetLength(0))
    {
        avarage = (avarage + digits[i, j]);
        i++;
    }

    avarage = avarage / a;
    Console.Write(avarage + "; ");
    j++;
}



Console.WriteLine();
PrintArray(digits);



void ArrayRandDigits(int[,] array)
{
    int i = 0;
    while (i < array.GetLength(0))
    {
        int j = 0;
        while (j < array.GetLength(1))
        {
            array[i, j] = new Random().Next(0, 10);
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
            Console.Write(array[i, j] + ", ");
            j++;
        }
        i++;
        Console.Write(" ]");
        Console.WriteLine(" ");
    }
}