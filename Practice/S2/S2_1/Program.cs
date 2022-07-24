// S2.1. Составить программу:
// а) вычисления значения функции y=7x^2+3x+6 при любом значении x;
// б) вычисления значения функции x=12a2+7a+12 при любом значении а.

Console.Write("Введите число x: ");

int x = Convert.ToInt32(Console.ReadLine());

int y = 7 * Convert.ToInt32(Math.Pow(x, 2)) + 3 * x + 6;

Console.WriteLine($"y = {y}");