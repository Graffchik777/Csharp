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
//Метод инвертирует элементы массива
int[] ColculateTask(int[] inputArray)
{
    int[] outputArray = new int[12];
    int i = 0;
    while (i < 12)
    {
        outputArray[i] = inputArray[i] * (-1);
        i++;
    }
    return outputArray;
}

// Метод для инвертирования массива "ТИЛЬДА"
int[] InvertArrayTilda(int[] inputArray)
{
    //Буферная переменная
    int i = 0;
    //Пробегаем все элементы массива
    while (i < inputArray.Length)
    {
        //Инвертируем эллемент
        inputArray[i] = (~inputArray[i]) +1;
        i++;
    }
    return inputArray;

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


int[] bufferArray= FillingArray();
PrintIntArray(bufferArray);
int[] resultArray=ColculateTask(bufferArray);
PrintIntArray(resultArray);
resultArray=InvertArrayTilda(bufferArray);
PrintIntArray(resultArray);
