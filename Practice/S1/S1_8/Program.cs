// S1.8. Составить программу вывода на экран в одну строку четырех любых чисел  с одним пробелом между ними.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите четвертое число: ");
int d = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} {b} {c} {d}");