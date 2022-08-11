// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void Sum(int x)
{
    int sum = 0;
    x = Math.Abs(x);    // На случай ввода отрицательного числа
    for (; x > 0; x /= 10) sum += x % 10;
    Console.WriteLine($"Сумма цифр в числе равна {sum}");
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Sum(a);