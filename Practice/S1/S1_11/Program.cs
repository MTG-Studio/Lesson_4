// S1.11. Составить программу вывода на экран «столбиком» четырех любых чисел.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите четвертое число: ");
int d = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a}\n{b}\n{c}\n{d}");