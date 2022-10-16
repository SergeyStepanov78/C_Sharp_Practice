// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.Write("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());

int number = new Random().Next(1, 100);
Console.WriteLine(number);

if (number % 2 == 0)
{
    Console.WriteLine("Вы ввели четное число");
}
else
{
    Console.WriteLine("Вы ввели нечетное число");
}