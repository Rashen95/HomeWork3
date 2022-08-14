// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void cubeNumber(double a)
{
    int number = 1;
    if (a <= 0 || a % 1 > 0)
    {
        Console.WriteLine("Введено неверное число");
    }
    else
    {
        while (number < a)
        {
            Console.Write($"{Math.Pow(number, 3)}, ");
            number++;
        }
        Console.Write($"{Math.Pow(number, 3)}");
    }
}

Console.Write("Введите любое целое положительное число, а я выведу все числа до него включительно в кубе: ");
double number = Convert.ToDouble(Console.ReadLine());
cubeNumber(number);