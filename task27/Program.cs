/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

void SumDigitsInNumber(int number)
{
    int lastDigit = 0;
    int sum = 0;
    while (number > 0)
    {
        lastDigit = number % 10;
        sum = sum + lastDigit;
        number = number / 10;
    }
    Console.WriteLine("sum = " + sum);
}
SumDigitsInNumber(452);