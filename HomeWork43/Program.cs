
void CrossPoint(double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = ((k2 * b1 - k1 * b2) / (k2 - k1)) + b1; 

    if (k1 == k2) 
         Console.Write("С такимим вводными -  прямые не пересекаются!");
    else
         Console.Write($"Вводные нормальные! Точка пересечения заданных прямых: ({x}; {y})");
}

Console.WriteLine("Вводим b1: ");
int b1 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Ввводим k1: ");
int k1 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Вводим b2: ");
int b2 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Вводим k2: ");
int k2 = int.Parse(Console.ReadLine() ?? "");

CrossPoint(k1, b1, k2, b2);

