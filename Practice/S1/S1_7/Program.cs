// S1.7. Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.

Console.Write("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{x}  {y}  {z}");