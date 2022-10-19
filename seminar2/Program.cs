// Seminar 2

// Console.Write($"какая-то_строка = {max}"); // Интерполяция, Внутрь строки встраивается значение переменной в фигур. скобки {},  и перед строкой ставим знак доллара $

// ======================================================================

// Программа: switch с днями недели

// Console.Clear(); 
// Console.Write("Введите порядковый номер дня недели: ");

// int day = Convert.ToInt32(Console.ReadLine()); 

// switch (day)
// {
//     case 1: day = 1;
//     Console.WriteLine("Введенное число соответствует понедельнику");
//     break;
//     case 2: day = 2;
//     Console.WriteLine("Введенное число соответствует вторнику");
//     break;
//     case 3: day = 3;
//     Console.WriteLine("Введенное число соответствует среде");
//     break;
//     case 4: day = 4;
//     Console.WriteLine("Введенное число соответствует четвергу");
//     break;
//     case 5: day = 5;
//     Console.WriteLine("Введенное число соответствует пятнице");
//     break;
//     case 6: day = 6;
//     Console.WriteLine("Введенное число соответствует субботе");
//     break;
//     case 7: day = 7;
//     Console.WriteLine("Введенное число соответствует воскресенью");
//     break;
//     default:
//     Console.WriteLine("Введено некорректное число. Число должно быть от 1 до 7");
//     break;
// }

// =======================================================================

// Программа выводит случ число из отрезка [10, 99] и показывает наибольшую цифру числа.

// if (number / 10 > number % 10);

// ======================================================================

// 1. Программа выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);

// int a = number / 100; // находим первую цифру. Например: 427/100 = 4,27. Так как тип int, то остаток отбрасывается
// int c = number % 10;  // находим третью цифру остаток от деления на 10. Например: 427%10=42,7 - остаток 7 

// Console.WriteLine($"{a} {c}"); // вывод получившегося числа 1ый способ
// Console.WriteLine(a*10 + c); // вывод получившегося числа 2ой способ

// =====================================================================

// 2. Программа принимает на вход два числа и выводит, является ли второе число кратным
//    первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// Console.Write("Enter first number: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter second number: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number2 % number1 == 0)
// {
//     Console.WriteLine($"Число {number2} кратно {number1}"); // Интерполяция
// }
// else 
// {
//     Console.WriteLine($"Число {number2} не кратно {number1}"); // Интерполяция 
// }

// ========================================================================

// 3. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно 
//    одновременно 7 и 23.

// Console.Write("Please, enter your number: ");
// Int32.TryParse(Console.ReadLine(),out int number);

// if ((number % 7 == 0) && (number % 23 == 0))
// {
//     Console.WriteLine($"Число {number} делится на 7 и на 23");
// }
// else
// {
//     Console.WriteLine($"Число {number} не делится на 7 и на 23");
// }

// =========================================================================

// 4. Напишите программу, которая принимает на вход два числа и проверяет, 
//    является ли одно число квадратом другого.

// Console.Write("Please, enter your first number: ");
// // Int32.TryParse(Console.ReadLine(),out int number1); // конвертированние строки в целое число
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please, enter your second number: ");
// Int32.TryParse(Console.ReadLine(),out int number2);

// if (number2 * number2 == number1)
// {
//     Console.WriteLine($"Число {number1} является квадратом {number2}");
// }
// else if (number1 * number1 == number2)
// {
//     Console.WriteLine($"Число {number2} является квадратом {number1}");
// }
// else
// {
//     Console.WriteLine($"Ни одно из чисел не является квадратом второго");
// }

//==============================================================================