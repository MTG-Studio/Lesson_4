// S1.1. Вывести на экран число  с точностью до сотых.

Console.Write("Введите любое число: ");

double x = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);

Console.WriteLine(x);