/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int[] CreateRandomArray(int size, int start, int end)
{
    int[] RandomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

Console.WriteLine("Введите размер массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое трехзначное число массива: ");
int firstNumArr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее трехзначное число массива: ");
int lastNumArr = Convert.ToInt32(Console.ReadLine());

int[] myRandomArray = CreateRandomArray(sizeArr, firstNumArr, lastNumArr);
Console.WriteLine($"[{String.Join(",", myRandomArray)}]");

void ShowPositiveNum(int[] arr)
{
    int countPositive = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            Console.Write(arr[i] + " ");
            countPositive ++;
        }
    }
    Console.WriteLine("- количество положительных чисел = " + countPositive);
}
ShowPositiveNum(myRandomArray);