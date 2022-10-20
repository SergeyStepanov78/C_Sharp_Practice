// 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day >= 1 && day <= 5) Console.WriteLine("Не выходной");

else if (day == 6 || day == 7) Console.WriteLine("Выходной");

else Console.WriteLine("Номер не соответствует никакому дню недели");