// ** Написать программу перемножения матриц

int[,] GetMatrix(string numberOfMatrix)
{
    Console.Write($"Введите количество строк {numberOfMatrix} матрицы: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите количество столбцов {numberOfMatrix} матрицы: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = rand.Next(0, 100);
        }
    }
    return matrix;
}

void PrintMatrix(string name, int[,] matrix)
{
    Console.WriteLine($"Матрица {name}:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void ProductMatrix(int[,] matrixFirst, int[,] matrixSecond)
{
    int[,] product = new int[matrixFirst.GetLength(0), matrixSecond.GetLength(1)];

    if (matrixFirst.GetLength(1) != matrixSecond.GetLength(0))
        Console.WriteLine("Матрицы не могут быть перемножены");
    else
    {
        Console.WriteLine("Произведение матриц: ");
        for (int i = 0; i < matrixFirst.GetLength(0); i++)
        {
            for (int j = 0; j < matrixSecond.GetLength(1); j++)
            {
                product[i, j] = 0;
                for (int k = 0; k < matrixFirst.GetLength(1); k++)
                {
                    product[i, j] += matrixFirst[i, k] * matrixSecond[k, j];
                }
                Console.Write($"{product[i, j]}  ");
            }
            Console.WriteLine();
        }
    }
}

int[,] matrix1 = GetMatrix("первой");
int[,] matrix2 = GetMatrix("второй");
PrintMatrix("первая", matrix1);
PrintMatrix("вторая", matrix2);
ProductMatrix(matrix1, matrix2);