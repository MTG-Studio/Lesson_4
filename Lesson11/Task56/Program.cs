/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] GetMatrix()
{
    Console.Write($"Введите количество строк двумерного массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите количество столбцов двумерного массива: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = rand.Next(-10, 10);
        }
    }
    return matrix;
}

void SumStrings(int[,] matrix)
{
    int minstr = 0, summin = 0;
    for (int i = 0, sum = 0; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (i == 0 || sum < summin)
        {
            summin = sum;
            minstr = i;
        }
    }
    Console.WriteLine($"Минимальная сумма {summin}");
    Console.WriteLine($"Строка, содержащая минимальную сумму: {minstr + 1}");

}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] array = GetMatrix();
Console.WriteLine("Исходный двумерный массив: ");
PrintMatrix(array);
SumStrings(array);