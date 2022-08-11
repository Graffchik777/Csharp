// Переменные для накопления результата

int positivSum = 0;
int negativSum = 0;

// Метод возвращает массив заполненный случайными числами от -9 до 9
int[] FillingArray()
{
    //Выходной массив
    int[] outArray = new int[12];
    //Буферная переменная
    int i = 0;
    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();
    while (i < 12)
    {
        //Получаем новое значение
        outArray[i] = numberSintezator.Next(-9, 10);
        //Увеличиваем инкримент
        i++;
    }
    //Возвращаем значение
    return outArray;
}
//Метод подсчета положительных и отрицательных значений
void ColculateTask(int[] outArray)
{
    int i = 0;
    while (i < 12)
    {
        if (outArray[i] > 0)
        {
            positivSum++;
        }
        else
        {
            negativSum++;
        }
        i++;
    }
}
//Выводим результат на консоль
void PrintResult()
{
    Console.WriteLine(positivSum);
    Console.WriteLine(negativSum);
}

//Метод печатает массив
void PrintIntArray(int[] inputArray)
{
    //Буферная переменная
    int i = 0;
    // Пробегаем все эллементы массива
    while (i < inputArray.Length - 1)
    {
        //Выводим эллемент массива
        Console.Write(inputArray[i] + "," + " ");
        //Увеличиваем инкремент
        i++;
    }
    //Выводит эллемент массива
    Console.WriteLine(inputArray[i]);
}

void VariantNaiv()

{
    int[] bufferArray = FillingArray();
    PrintIntArray(bufferArray);
    ColculateTask(bufferArray);
    PrintResult();
}
//Метод решения задачи 31 "наивный"
int t;
t = Environment.TickCount;
Console.WriteLine("Naiv time: {0} ms", Environment.TickCount - t);
VariantNaiv();