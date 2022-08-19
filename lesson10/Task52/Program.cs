// Задача 52. Задайте двумерный массив из целых чисел размера NxN.
// Укажите два числа,означающие строки, которые нужно поменять местами.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
9 8 7 2
число 1 -1
число 2 -3 

Итог:
1 2 7 4
5 3 2 9
8 4 2 4
9 2 7 8
*/

int[,] GetMatrix()
{
    Console.Write($"Введите размер двумерного массива (NxN): ");
    int rows = Convert.ToInt32(Console.ReadLine());
    int cols = rows;
    int[,] matrix = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = rand.Next(-100, 100);
        }
    }
    return matrix;
}

int[,] ChangeRows(int[,] matrix)
{
    Console.Write("Введите число, означающее строку, которую будем заменять на другую: ");
    int row1 = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.Write("Введите число, означающее строку, с которой будем менять первую: ");
    int row2 = Convert.ToInt32(Console.ReadLine()) - 1;
    if (row1 < matrix.GetLength(0) && row2 < matrix.GetLength(0))
    {
        for (int j = 0, k = 0; j < matrix.GetLength(0); j++)
        {
            k = matrix[row1, j];
            matrix[row1, j] = matrix[row2, j];
            matrix[row2, j] = k;
        }
    }
    else Console.WriteLine("Введите корректные исходные данные");
    return matrix;
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
PrintMatrix(array);
array = ChangeRows(array);
PrintMatrix(array);
