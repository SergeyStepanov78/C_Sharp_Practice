/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 4+5+6+7+8
*/

int m = new Random().Next(1, 5);
int n = new Random().Next(6, 10);
int sum = 0;

void SumRange(int m, int n, int sum)
{
    sum = sum + m;
    if (m == n)
    {
        Console.WriteLine("сумма = " + sum);
        return;
    }
    SumRange(m + 1, n, sum);
}

SumRange(m, n, sum);