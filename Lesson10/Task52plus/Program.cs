// ИЛИ можно сдать одну задачу с поворотом матрицы

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

int[,] MatrixRotate(int[,] matrix)
{
    int length0 = matrix.GetLength(0) - 1;
    for (int x = 0, field = length0; x < (matrix.GetLength(0) / 2); x++, field--)
        for (int i = x, j = x, k = 0; j < field; j++)
        {
            k = matrix[i, j];
            matrix[i, j] = matrix[j, length0 - i];
            matrix[j, length0 - i] = matrix[length0 - i, length0 - j];
            matrix[length0 - i, length0 - j] = matrix[length0 - j, i];
            matrix[length0 - j, i] = k;
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
Console.WriteLine("Исходная матрица: ");
PrintMatrix(array);
array = MatrixRotate(array);
Console.WriteLine("Повёрнутая против часовой стрелки матрица: ");
PrintMatrix(array);