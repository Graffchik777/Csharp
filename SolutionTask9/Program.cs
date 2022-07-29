System.Random namberSintezator = new Random();

int namber = namberSintezator.Next(10, 99);
Console.WriteLine(namber);


int firstNamber = namber / 10;
int secondNamber = namber % 10;

if (firstNamber > secondNamber)
{
    Console.WriteLine(firstNamber);
}
else
{
    Console.WriteLine(secondNamber);
}