// S2.1. Составить программу:
// а) вычисления значения функции y=7x^2+3x+6 при любом значении x;
// б) вычисления значения функции x=12a2+7a+12 при любом значении а.

Console.Write("Введите число a: ");

int a = Convert.ToInt32(Console.ReadLine());

int x = 12 * Convert.ToInt32(Math.Pow(a, 2)) + 7 * a + 12;

Console.WriteLine($"x = {x}");