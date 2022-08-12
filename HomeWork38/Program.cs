Console.Clear();


Console.WriteLine("Введите его! Размер не имеет значения!");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];

FillingArray(numbers);
Console.WriteLine("Вот он, наш массивчик: ");
PrintInArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"всеголишь {numbers.Length} чисел");
Console.WriteLine($"Самое большое его значение = {max}, самое маленькое значение = {min}");
Console.WriteLine($"Разница между ними имеет значение = {(max - min),2}");


void FillingArray(double[] numbers)
{
    int i = 0;
    while ( i < numbers.Length)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000) / 100);
                 i++;
        }
        
}

void PrintInArray(double[] numbers)
{
    int i = 0;
    Console.Write("[ ");
    while (i < numbers.Length )
        {
            Console.Write(numbers[i] + " ");
             i++;
        }
   
    Console.Write("]");
    Console.WriteLine();
}
