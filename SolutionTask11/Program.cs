// // Решение Арта

// int number = new Random().Next(100,1000);
// Console.WriteLine(number);
// int numberFierst = number/100;
// int numberThree = number%10;
// Console.WriteLine(" Число " + numberFierst + numberThree);

// //Решение Кирилла

int number = new Random().Next(100,1000);
Console.Write("Число случайное: ");
Console.WriteLine(number);

int n1 = number/100;
int n2 = number%10;

Console.Write("Че получилось: ");
Console.WriteLine(" " + n1 + n2);
