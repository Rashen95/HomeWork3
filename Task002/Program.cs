// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void distance(double a, double b, double c, double d, double e, double f)
{
    Console.WriteLine($"Расстояние между точками равно {Math.Round(Math.Sqrt(Math.Pow(a - d, 2) + Math.Pow(b - e, 2) + Math.Pow(c - f, 2)), 2)}");
}

Console.WriteLine("Введите координаты двух точек в 3D и я рассчитаю расстояние между ними");

Console.Write("Координата x первой точки: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата y первой точки: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата z первой точки: ");
double za = Convert.ToDouble(Console.ReadLine());

Console.Write("Координата x второй точки: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата y второй точки: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата z второй точки: ");
double zb = Convert.ToDouble(Console.ReadLine());

distance(xa, ya, za, xb, yb, zb);