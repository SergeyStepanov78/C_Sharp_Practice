/*
Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void NumFromNTo1(int n)
{
    {
        Console.Write($"{n} ");
        n--;
        if (n < 1) return;
        NumFromNTo1(n);
    }
    Console.WriteLine();
}

int i = new Random().Next(5, 10);
NumFromNTo1(i);