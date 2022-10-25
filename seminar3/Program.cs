/*
Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

// int GetQuarterFromCoordinate(int userX, int userY) //функция GetQuarterFromCoordinate 
// {
//     int quarter = 0;
//     if (userX > 0 && userY > 0)
//     {
//         quarter = 1;
//     }
//     else if (userX < 0 && userY > 0)
//     {
//         quarter = 2;
//     }
//     else if (userX < 0 && userY < 0)
//     {
//         quarter = 3;
//     }
//     else if (userX > 0 && userY < 0)
//     {
//         quarter = 4;
//     }
//     return quarter;
// }
// Console.Write("Введите координату Х: ");
// int userX = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y: ");
// int userY = Convert.ToInt32(Console.ReadLine());

// int quarter = GetQuarterFromCoordinate(userX, userY); // вызываем функцию 
// if (quarter != 0) // проверка-исключение на 0
// {
//     Console.WriteLine($"Точка с координатами [{userX}:{userY}] находится в {quarter} четверти");
// }
// else
// {
//     Console.ForegroundColor = ConsoleColor.Cyan; // устанавливаем цвет для сообщения 
//     Console.WriteLine($"Точка с координатами [{userX}:{userY}] находится на одной из осей");
//     Console.ResetColor();
// }

/*===================================================================================

Задача 18: Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

// void Coordinate(int Quarter)

// {
//     if (Quarter == 1)
//     {
//         Console.WriteLine("x >0 and y >0");
//     }

//     else if (Quarter == 2)
//     {
//         Console.WriteLine("x < 0 and y >0");
//     }

//     else if (Quarter == 3)
//     {
//         Console.WriteLine("x < 0 and y <0");
//     }
//     else if (Quarter == 4)
//     {
//         Console.WriteLine("x > 0 and y <0");
//     }
//     else
//     {
//         Console.WriteLine("Некорректная четверть");
//     }
// }

/* ==============================================================================

Задача 21: Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21

d = √(xb - xa)2 + (yb - ya)2 - формула нахождения расстояния в 2D по координатам 
*/

// Console.Clear();
// double GetCoordinateDistance(int x1, int y1, int x2, int y2)
// {
//     double s = 0;
//     s = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); //Pow для возведения в степень. Sqrt вычисление кв.корня
//     return s;
// }
// Console.WriteLine("enter coordinates: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());

// double distance = GetCoordinateDistance(x1, y1, x2, y2);

// Console.WriteLine(Math.Round(distance, 3)); //Round() округляет до значения указаного после запятой

/* ==========================================================================

Задача 22: Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

// void sqr(int N)
// {
//     if (N > 0)
//     {
//         int count = 1;
//         while (count < N)
//         {
//             int result = count * count;
//             Console.Write(result + ", ");
//             count++;
//         }
//         Console.WriteLine(N * N);
//     }
//     else
//     {
//         Console.WriteLine("Введите число больше 1");
//     }
// }
// Console.Write("enter number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// sqr(N);

/* ===================================================================

d = √(xb - xa)2 + (yb - ya)2 - формула нахождения расстояния в 2D по координатам.

формула для 3D: 
{Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) *  1.0), 0.5)}"

палиндром - одинаково в обе стороны. а роза упала на лапу азора - это строка. 
сравнением первой и последней

математика элегантей, не массивами 
*/