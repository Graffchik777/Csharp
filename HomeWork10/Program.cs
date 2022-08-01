Console.Write("Запишем число: ");
string? namber = Console.ReadLine();
//int namber = new Random().Next(100,1000);
//Console.WriteLine(namber);
string stringNum = namber.ToString();
Console.Write("От числа осталась серидинка: ");
Console.Write(stringNum[1]);


