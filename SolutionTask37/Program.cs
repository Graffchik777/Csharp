int[] FillingArray()
{
    //Выходной массив
    int[] outArray = new int[123];
    //Буферная переменная
    int i = 0;
    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();
    while (i < 123)
    {
        //Получаем новое значение
        outArray[i] = numberSintezator.Next();
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
    while (i < inputArray.Length)
    {
        //Выводим эллемент массива
        Console.Write(inputArray[i] + "," + " ");
        //Увеличиваем инкремент
        i++;
    }
    //Выводит эллемент массива
    // Console.WriteLine(inputArray[i]);
}

//Метод решения задачи 37 наивный
int[] ColculateTask(int[] inputArray)
{
    int[] resultArray = new int[inputArray.Length / 2 + 1];
    int i = 0;
    while (i < resultArray.Length)
    {
        resultArray[i] = inputArray[i] * inputArray[inputArray.Length - 1 - i];
        i++;
    }
    return resultArray;
}

int[] buferArray = FillingArray();
PrintIntArray(buferArray);
int[] resultArray = ColculateTask(buferArray);
PrintIntArray(resultArray);