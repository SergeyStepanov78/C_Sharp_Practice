/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int m = 3;
int n = 2;
FindAkerman(m, n);

int FindAkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return FindAkerman(m - 1, 1);
    if (m > 0 && n > 0)
        return FindAkerman(m - 1, FindAkerman(m, n - 1));
    return FindAkerman(m, n);
}

Console.WriteLine($"{FindAkerman(m, n)}");