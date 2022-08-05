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

// #include <iostream>
// int main()
// {
//     int ch = -12328;
//     std::cout<<
//         ((ch % 10 == ch / 10000 && (ch /10) % 10 == (ch / 1000) % 10) ? 
//         "it's palindrome" :
//         "it isn'n palindrome");
//     return 0;
// } 
КАК ЭТОТ КОД ПЕРЕПИСАТЬ В С#