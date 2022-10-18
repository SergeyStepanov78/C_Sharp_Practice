//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Enter first number: ");
// int firstnumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter second number: ");
// int secondnumber = Convert.ToInt32(Console.ReadLine());

int firstnumber = new Random().Next(-100, 100);
Console.WriteLine("First number: " + firstnumber);

int secondnumber = new Random().Next(-100, 100);
Console.WriteLine("Second number: " + secondnumber);

if (firstnumber > secondnumber)
{
    Console.WriteLine("Большее число: " + firstnumber + " " + "Меньшее число: " + secondnumber);
}
else 
{
    Console.WriteLine("Меньшее число: " + firstnumber + " " + "Большее число: " + secondnumber);
}