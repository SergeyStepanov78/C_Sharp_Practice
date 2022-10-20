// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Enter three-digit number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

number1 = number1 / 10 % 10;

Console.WriteLine($"Вторая цифра = {number1}");