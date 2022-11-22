/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int rows = new Random().Next(3, 5);
int columns = new Random().Next(3, 5);

int[,] GetArray(int rows, int columns)
{
    int[,] resultArr = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArr[i, j] = new Random().Next(10);
        }
    }
    return resultArr;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void AverageSumCollumn(int[,] arr)
{
    float sum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum = sum + arr[0, j];
        }
        sum = sum / arr.GetLength(0);
    }
    Console.WriteLine(sum + ";");
}

PrintArray(GetArray(rows, columns));
AverageSumCollumn(GetArray);