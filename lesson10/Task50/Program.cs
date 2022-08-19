// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет
// задача посложнее - вводить позицию в одну строку. символ-разделитель - запятая

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
            matrix[i, j] = rand.Next(-100, 100);
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

void ShowMatrixElement(int[,] matrix)
{
    Console.Write("Введите через запятую позицию элемента массива: ");
    string? text = Console.ReadLine();
    string[] position = text!.Split(new char[] { ',' });
    int i = Convert.ToInt32(position[0]) - 1;
    int j = Convert.ToInt32(position[1]) - 1;
    if (i < matrix.GetLength(0) && j < matrix.GetLength(1))
        Console.WriteLine(matrix[i, j]);
    else Console.WriteLine("Такого числа в массиве нет");
}

int[,] matrix1 = GetMatrix();
PrintMatrix(matrix1);
ShowMatrixElement(matrix1);