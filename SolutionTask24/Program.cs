Console.Clear();
Console.Write("Введите число ");

long inputNamber = int.Parse(Console.ReadLine());
long t;

void VariantSimple()
{
    long sumOfNumbers = 0;
    for (long i = 1; i <= inputNamber; i++)
    {
        sumOfNumbers += i;
    }
    Console.WriteLine("Сумма чисел от 1 до " + inputNamber + " = " + sumOfNumbers);

}

void VariantGauss()
{
    long sumOfNumbers = 0;
    sumOfNumbers = ((1 + inputNamber) * inputNamber) / 2;

    Console.WriteLine("Сумма чисел от 1 до " + inputNamber + " = " + sumOfNumbers);

}

t = Environment.TickCount;

VariantSimple();
    Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);
t = Environment.TickCount;
VariantGauss();
 Console.WriteLine("Gausse time: {0} ms", Environment.TickCount - t);