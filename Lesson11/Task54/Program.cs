/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
*/
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

int[,] MatrixSort(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = j + 1, x = 0; k < matrix.GetLength(1); k++)    // x - вспомогательная переменная
            {
                if (matrix[i, j] > matrix[i, k])
                {
                    x = matrix[i, k];
                    matrix[i, k] = matrix[i, j];
                    matrix[i, j] = x;
                }
                else x = matrix[i, j];
            }
        }
    }
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
Console.WriteLine("Исходный двумерный массив: ");
PrintMatrix(array);
array = MatrixSort(array);
Console.WriteLine("Массив с упорядоченными элементами каждой строки: ");
PrintMatrix(array);