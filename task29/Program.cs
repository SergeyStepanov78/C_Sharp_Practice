/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] GetArr(int size)
{
    int[] arr1 = new int [size];
    for (int i = 0; i < size; i++)
    {
        arr1[i] = new Random().Next(100);
    }
    return arr1;
}
int[] array = GetArr(8);
Console.WriteLine($"[{String.Join(",", array)}]");