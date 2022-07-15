Console.Write("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int z = Convert.ToInt32(Console.ReadLine());
int max;

if (x > y)
{
    if (x > z)
    {
        max = x;
    }
    else
    {
        max = z;
    }
}
else
    if (y > z)
    {
        max = y;
    }
    else
    {
        max = z;
    }

Console.WriteLine("Максимальное число равно: " + max);