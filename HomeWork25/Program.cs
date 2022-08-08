// Console.WriteLine("Введите число A: ");
// //string NumberA = Console.ReadLine();
// int NumberA = Convert.ToInt32(Console.ReadLine());

// //int numberA = (int) (Console.ReadLine());
// Console.WriteLine("Введите число B: ");
// //string NumberB = Console.ReadLine();
// int NumberB = Convert.ToInt32(Console.ReadLine());
// // int numberB = (int) Console.ReadLine();


Console.Clear();
Console.WriteLine("Введите число A: ");
int NumberA = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int NumberB = Convert.ToInt16(Console.ReadLine());

int Exp(int NumberA, int NumberB)
{
//   int result = 1;
//   for(int i=1; i <= NumberB; i++)
//   {
//     result = result * NumberA;
//   }
    int result = (int) Math.Pow(NumberA, NumberB);
    return result;
}
int Expon()
{
  int expon = Exp(NumberA, NumberB);
  Console.WriteLine("Ответ: " + expon);
  return expon;
}
Console.Write(Exp(NumberA, NumberB));

