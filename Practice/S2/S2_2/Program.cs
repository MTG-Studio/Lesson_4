// S2.2. Дана сторона квадрата. Найти его периметр.

Console.Write("Введите длину стороны квадрата: ");

string? a = Console.ReadLine();
double r;
bool result = double.TryParse(a, out r);

if (result == true && Convert.ToDouble(a) > 0)
{
    double p = Convert.ToDouble(a) * 4;
    Console.WriteLine($"Периметр квадрата равен {p}");
}
else
{
    Console.WriteLine("Введено неверное значение");
}