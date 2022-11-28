/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int firstArrRows = new Random().Next(3, 5);
int firstArrColumns = new Random().Next(3, 5);

int secondArrRows = new Random().Next(3, 5);
int secondArrColumns = new Random().Next(3, 5);

int[,] firstArray = GetArray(firstArrRows, firstArrColumns);
PrintArray(firstArray);

Console.WriteLine();

int[,] secondArray = GetArray(secondArrRows, secondArrColumns);
PrintArray(secondArray);

int[,] GetArray(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = new Random().Next(10);
        }
    }
    return arr;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ProductArray(int[,] arr1, int[,] arr2)
{
    int[,] resultArr = new int[arr1.GetLength(0), arr2.GetLength(1)];
    if (firstArrColumns != secondArrRows)
    {
        Console.WriteLine("Матрицы не согласованы, операция не выполнима");
        return resultArr;
    }
    else
    {
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                for (int k = 0; k < arr1.GetLength(1); k++)
                {
                    resultArr[i, j] += arr1[i, k] * arr2[k, j];
                }
            }
        }
    }
    Console.WriteLine("Результирующая матрица будет: ");
    return resultArr;
}

PrintArray(ProductArray(firstArray, secondArray));