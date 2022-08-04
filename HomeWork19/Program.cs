Console.Write("Введите пятизначное число:     ");
string? number = Console.ReadLine();

void PolliNum(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Число: {number} это Палиндром.");
  }
 else Console.WriteLine($"Число: {number} не ЭТО  не палиТдром");
}
if (number!.Length == 5)
{
  PolliNum(number);
}

