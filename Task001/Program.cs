// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void palindrome(double a)
{
    if (a < 0)
    {
        a = Math.Abs(a);
    }
    if (a % 1 > 0)
    {
        Console.WriteLine("Введено не целое число!");
    }
    else if (a < 10000 || a > 99999)
    {
        Console.WriteLine("Вы ввели не пятизначное число!");
    }
    else if (Math.Floor(a / 1000) == a % 10 * 10 + Math.Floor(a % 100 / 10))
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

Console.Write("Введите пятизначное число, а я скажу является ли оно палиндромом: ");
double number = Convert.ToDouble(Console.ReadLine());
palindrome(number);