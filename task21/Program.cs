/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
формула для 3D: 
{Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) *  1.0), 0.5)}"
*/

Console.Write("Enter coordinate point by X1 axis: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter coordinate point by X2 axis: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter coordinate point by Y1 axis: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter coordinate point by Y2 axis: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter coordinate point by Z1 axis: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter coordinate point by Z2 axis: ");
int z2 = Convert.ToInt32(Console.ReadLine());

if (x1 != 0 && y1 != 0 && z1 != 0)
{
    double distance = (Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) *  1.0), 0.5));
    Console.WriteLine($"Расстояние между точками = {distance}");
}
else
{
    Console.WriteLine("Одна или две точки находятся на оси");
}