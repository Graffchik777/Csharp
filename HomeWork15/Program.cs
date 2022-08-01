Console.WriteLine("Какой день недели по счету: ");
int WeekDayNumber = Convert.ToInt32(Console.ReadLine());

    if(WeekDayNumber == 6 || WeekDayNumber == 7) 
  {
      Console.WriteLine("Че, выходной? - Да!!!");
  }
        if(WeekDayNumber < 1 || WeekDayNumber > 7)
{
    Console.WriteLine("Я еще в отпуске, или уже в отпуске");
      }
    {
     if(WeekDayNumber >1 || WeekDayNumber <5)   
     Console.WriteLine("Опять на работу?!((");
}
