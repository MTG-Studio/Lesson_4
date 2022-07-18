// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int x = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int l = x.ToString().Length;    // длина числа


if (l > 2)
{
    int a = Convert.ToInt32(Math.Pow(10, l - 2));   // для поиска остатка
    int b = Convert.ToInt32(Math.Pow(10, l - 3));   // для поиска частного
    int x3 = x % a / b;

    Console.WriteLine(x3);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}