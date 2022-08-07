Console.Clear();
Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();
int inputNum = int.Parse(inputLine);
int t;

t = Environment.TickCount;
Console.WriteLine(sumNums(inputNum));
Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);

t = Environment.TickCount;
Console.WriteLine(mulRecursia(inputNum));
Console.WriteLine("Recurs time: {0} ms", Environment.TickCount - t);

int sumNums(int num)
{
int sum = 1;
for (int i = 1; i <= inputNum; i++)
{
//sum *= i;
sum = sum * i;
}
return sum;
}

int mulRecursia(int num)
{
    if(num == 1)
    {
        return 1;
    }
    else
    {
        return num * mulRecursia(num-1);
    }
    }



