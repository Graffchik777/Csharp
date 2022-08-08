Console.Clear();

Console.WriteLine("Настарт! Внимание! Наливааай... ");
string RandomNumber = Console.ReadLine()??"";
System.Random numberSintezator = new Random();

void VariantNifigaNeNaiv()

{
    
    int i = 0;
    Console.Write("[");
    while(i < 9-1)
    {
        Console.Write(numberSintezator.Next(5,20)+",");
        i++;
    }
    {
    Console.Write(numberSintezator.Next(5,20));
    Console.WriteLine("] ");
    }
    Console.WriteLine("                                           ");
    Console.WriteLine("Получилось!! разделить массив(ответ) и камандную строку)))");
    Console.WriteLine("                                           ");
       


}
VariantNifigaNeNaiv();
