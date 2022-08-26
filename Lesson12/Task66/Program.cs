// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void InputNumbers(out int min, out int max)
{
    Console.Write("Введите число M: ");
    min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N: ");
    max = Convert.ToInt32(Console.ReadLine());
}

void PrintSum(int min, int max)
{
    int sum = 0;
    for (int i = min; i <= max; i++, min++)
        sum += min;
    Console.WriteLine(sum);
}

InputNumbers(out int M, out int N);
PrintSum(M, N);