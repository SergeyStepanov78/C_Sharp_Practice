// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Enter first number: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number: ");
int thirdnumber = Convert.ToInt32(Console.ReadLine());

if (firstnumber > secondnumber && firstnumber > thirdnumber)
{
    Console.WriteLine("Max value: " + firstnumber);
}

else if (secondnumber > firstnumber && secondnumber > thirdnumber)
{
    Console.WriteLine("Max value: " + secondnumber);
}

else 
{
 Console.WriteLine("Max value: " + thirdnumber);
}