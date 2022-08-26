// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
//------------------------------------------------------------------------

Console.Clear();

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int temp = m;

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}


PrintSumma(m, n, temp = 0);

void PrintSumma(int m, int n, int summa)
{
    summa = summa + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов: {summa} ");
        return;
    }
    PrintSumma(m, n - 1, summa);
}


