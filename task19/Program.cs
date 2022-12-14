/*
Задача 19:
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

// Console.Write("Enter 5-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number >= 10000 && number < 100000)
// {
//     int digit1 = number / 10000;
//     int digit2 = number / 1000 % 10;
//     int digit3 = number / 100 % 10;
//     int digit4 = number / 10 % 10;
//     int digit5 = number % 10;
//     // Console.WriteLine($"{digit1}, {digit2},  {digit3},  {digit4},  {digit5}");
//     if (digit1 == digit5 && digit2 == digit4)
//     {
//         Console.WriteLine("This number is palindrome");
//     }
//     else
//     {
//         Console.WriteLine("This number is not palindrome");
//     }

// }
// else Console.WriteLine("This is not 5-digit number");

/*
Решение-2 используя метод
В чем разница делать метод void (ничего не возвращающий) или int (возвращающий)?
*/

int FindDigitsFromNumber(int number)
{
    if (number >= 10000 && number < 100000)
    {
        int digit1 = number / 10000;
        int digit2 = number / 1000 % 10;
        int digit4 = number / 10 % 10;
        int digit5 = number % 10;
        if (digit1 == digit5 && digit2 == digit4)
        {
            Console.WriteLine("This number is palindrome");
        }
        else 
        {
            Console.WriteLine("This number is not palindrome");
        }
    }
    else 
    {
        Console.WriteLine("This is not 5-digit number");
    }
    return number;
}
Console.Write("Enter 5-digit number: ");
int isPalindrome = Convert.ToInt32(Console.ReadLine());
FindDigitsFromNumber(isPalindrome);

/*
Console.Write(digit1 == digit5 && digit2 == digit4 ? "This number is palindrome" : "This number is not palindrome");
это тернарный оператор
*/
