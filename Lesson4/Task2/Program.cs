Console.Write("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("Наибольшее число: " + x + ", Наименьшее число: " + y);
}
else
    if (x < y)
    {
        Console.WriteLine("Наибольшее число: " + y + ", Наименьшее число: " + x);
    }
    else
    {
        Console.WriteLine("Числа равны");
    }