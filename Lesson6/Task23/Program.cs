// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int M = 1;

while (M <= N)
{
    Console.Write ($"{Math.Pow(M, 3)} ");
    M++;
}
Console.WriteLine();