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


//Метод решения задачи 33 наивный
bool ColculateTask(int[] inputArray, int searchNumber)
{
    bool resultSearch = false;
    int i = 0;
    while (i < 12)
    {
        if (inputArray[i] == searchNumber)
        {
            resultSearch = true;
            break;
        }

        i++;
    }
    return resultSearch;
}

int[] buferArray = FillingArray();
PrintIntArray(buferArray);
Console.WriteLine("Введите число для поиска:  ");
int searchNumber = int.Parse(Console.ReadLine());

Console.WriteLine(ColculateTask(buferArray, searchNumber));
