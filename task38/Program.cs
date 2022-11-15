/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
int[] CreateRandomArray(int size)
{
    int[] RandomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        RandomArray[i] = new Random().Next(1,20);
    }
    return RandomArray;
}

Console.Write("Введите размер массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());

int[] myRandomArray = CreateRandomArray(sizeArr);
Console.WriteLine($"[{String.Join(",", myRandomArray)}]");

void DiffMaxAndMin(int[] arr)
{
    int min = arr[0];
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max)
        {
            max = arr[i];
        }
        else if(arr[i] < min)
        {
            min = arr[i];
        }
    }
    Console.WriteLine($"разница между максиммальным и минимальным значениями = {max - min}");
    // Console.WriteLine(min);
}
DiffMaxAndMin(myRandomArray);