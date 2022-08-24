// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// -------------------------------------------------------

Console.Clear();

int x = InputInt("Размер матриц: ");
Console.WriteLine(" ");
int[,] matrixA = new int[x, x];
int[,] matrixB = new int[x, x];
ArrayRandDigitals(matrixA);
ArrayRandDigitals(matrixB);
int[,] matrixC = new int[x, x];


int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void ArrayRandDigitals(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5); 
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
        Console.WriteLine(" ");
    }
}

for (int i = 0; i < x; i++)
{
    for (int j = 0; j < x; j++)
    {
        for (int z = 0; z < x; z++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, z] * matrixB[z, j]);
        }
    }
}
Console.WriteLine("Матрица А: ");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В: ");
PrintArray(matrixB);
Console.WriteLine();
Console.WriteLine("Умножим матрицы  А на В: ");
PrintArray(matrixC);