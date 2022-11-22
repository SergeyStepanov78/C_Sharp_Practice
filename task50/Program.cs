/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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

void FindNumber(int[,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] == number)
            {
                Console.WriteLine($"элемент {number} найден в массиве");
            }
            else Console.WriteLine($"элемент {number} не найден в массиве");
        }
    }
}

PrintArray(GetArray(rows, columns));

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

FindNumber(GetArray, number); // Argument 1: cannot convert from 'method group' to 'int[*,*]'
                            // не понимаю, что и где исправить