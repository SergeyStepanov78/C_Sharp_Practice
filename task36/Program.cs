/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int[] CreateRandomArray(int size)
{
    int[] RandomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        RandomArray[i] = new Random().Next(10);
    }
    return RandomArray;
}

Console.Write("Введите размер массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());

int[] myRandomArray = CreateRandomArray(sizeArr);
Console.WriteLine($"[{String.Join(",", myRandomArray)}]");

void FindSumNegative(int[] arr)
{
    int sumNegative = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sumNegative = sumNegative + arr[i];
        }
    }
    Console.WriteLine($"сумма чисел нечетных индексов = {sumNegative}");
}
FindSumNegative(myRandomArray);