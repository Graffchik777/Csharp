Console.Clear();
System.Random numberSintezator = new Random();

void VariantNive()
{
    int i = 0;
    Console.Write("[");
    while(i < 8-1)
    {
        Console.Write(numberSintezator.Next(0,2)+",");
        i++;
    }
    Console.Write(numberSintezator.Next(0,2));
    Console.Write("]");
}
VariantNive();
