// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

Console.Clear();
int numberM = ReadData("Задайте число M");
int numberN = ReadData("Задайте число N");

if (numberM < numberN)
{
    NaturalNamberPrinter(numberM, numberN);
}
else
{
    NaturalNamberPrinter(numberN, numberM);
}


int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}

int sum =0;

void NaturalNamberPrinter(int m, int n)
{
    if (m - 1 == n) return;
    Console.Write(m + " ");
    NaturalNamberPrinter(m + 1, n);
}