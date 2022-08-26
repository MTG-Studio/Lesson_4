// Задача 64: Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

void InputNumbers(out int min, out int max)
{
    Console.Write("Введите число M: ");
    min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N: ");
    max = Convert.ToInt32(Console.ReadLine());
}

void PrintNaturalNumbers(int min, int max)
{
    for (int i = min; i < max; i++)
    {
        Console.Write($"{min}, ");
        min++;
    }
    Console.WriteLine(max);
}

InputNumbers(out int M, out int N);
PrintNaturalNumbers(M, N);