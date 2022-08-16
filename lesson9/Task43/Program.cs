// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

// Решение методом Крамера
// k1 * x - y + b1 = 0;  =>  k1 * x - y = -b1;
// k2 * x - y + b2 = 0;  =>  k2 * x - y = -b2;

void IntersectionPoint(double c1, double a1, double c2, double a2)
{
    double delta = a1 * (-1) - (-1) * a2;
    double deltax = -c1 * (-1) - (-c2) * (-1);
    double deltay = a1 * (-c2) - (-c1) * a2;

    if (delta == 0) Console.WriteLine("Точек пересечения нет или их бесконечное количество");
    else
    {
        double x = deltax / delta;
        double y = deltay / delta;
        Console.WriteLine($"x = {x}, y = {y}");
    }
}

Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

IntersectionPoint(b1, k1, b2, k2);