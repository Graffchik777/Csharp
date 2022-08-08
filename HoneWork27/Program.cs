Console.Clear();
Console.Write("Введите любое число: ");
string numberN = Console.ReadLine()??"";
int Number = int.Parse(numberN);

  int SummaNum(int numberN)
  {
    int counter = Convert.ToString(Number).Length;
    int advance = 0;
    int result = 0;

    for(int i = 0; i < counter; i++)
    {
      
      advance = numberN - (numberN % 10);
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }

int sumNumber = SummaNum(Number);
Console.WriteLine("Сумма всех циферок в числе: " + sumNumber);
