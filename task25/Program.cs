﻿/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

void Exponentiation(int number, int power)
{
    int result = 1;
    for (int i = 0; i < power; i++)
    {
        result = result * number;
    }
    Console.WriteLine(result);
}
Exponentiation(3, 5);