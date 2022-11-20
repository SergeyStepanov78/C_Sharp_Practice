﻿/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
x = (b2 - b1) / (k1 - k2)
*/
Console.WriteLine("Введите значения для: b1, k1, b2, k2: ");

double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());

void GetPoint(double b1, double b2, double k1, double k2)
{
    double dotX = 0;
    double dotY = 0;
    if (b1 == b2 && k1 == k2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if (k1 == k2)
    {
        Console.WriteLine("Точка пересечения отсутствует, прямые паралельны");
    }
    else
    {
        dotX = (b2 - b1) / (k1 - k2);
        dotY = k2 * dotX + b2;
        Console.WriteLine($"Координаты пересечения двух прямых: {dotX}{dotY}");
    }
}
GetPoint(b1, b2, k1, k2);