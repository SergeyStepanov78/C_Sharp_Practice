﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Enter integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int count  = 1;
while (count < number)
{
    if (count % 2 == 0) Console.Write(count + " ");
    count++;
}
Console.WriteLine();