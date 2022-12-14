//=========================================================================================================
// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива. 
// Разбор на семинаре
//=========================================================================================================

// метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(-10, 10);
            j++;
        }
        i++;
    }
    return outArray;
}

void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + "\t");
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}

// Метод меняет местами первую ипоследнюю строчку
// Принимает двумерный массив
// Возвращает модефицированный входной массив
int[,] RotateRowFirstLast(int[,] inputArray)
{
    int bufferElement = 0;
    int i = 0; int j = 0;
    while (i < inputArray.GetLength(0))
    {
        //Блок ротации элементов в столбце
        bufferElement = inputArray[i, 0];
        inputArray[i, 0] = inputArray[i, inputArray.GetLength(0) - 2];
        inputArray[i, inputArray.GetLength(0) - 2] = bufferElement;
        i++;
    }
    return inputArray;
}


 int[,] twoDimArray = FillTwoDimArray(4, 4);
 PrintTwoDimArray(twoDimArray);

 Console.WriteLine();
 //----------------------------------------------------------
 PrintTwoDimArray(RotateRowFirstLast(twoDimArray));
 //--------------------------------------------------