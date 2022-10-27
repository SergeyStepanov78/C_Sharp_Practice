/*
Задача 23
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

// Console.Write("Enter number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int count = 1;
// while(number >= count)
// {
//     int cube = Convert.ToInt32(Math.Pow(count, 3));
//     Console.Write(cube + " ");
//     count++;
// }

/*
Решение с методом
*/

void CubePow(int number)
{
    int count = 1;
    while (number >= count)
    {
        int cube = Convert.ToInt32(Math.Pow(count, 3));
        Console.Write(cube + " ");
        count++;
    }
}
Console.Write("Enter number: ");
int cubeNumber = Convert.ToInt32(Console.ReadLine());
CubePow(cubeNumber);
Console.WriteLine();
