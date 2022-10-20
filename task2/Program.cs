// 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int number2 = Convert.ToInt32(new Random().Next(100, 110));
// Console.WriteLine(number2);

Console.Write("Enter three-digit number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 / 100 == 0) Console.WriteLine("Третьей цифры нет");

else if (number2 / 100 > 9) Console.WriteLine("Вы ввели не трехзначное число");

else
{
number2 = number2 % 10;
Console.WriteLine($"третья цифра это {number2}");
}