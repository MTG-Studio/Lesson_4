/* Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:

1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/

Console.Write("Введите размер матрицы NxN: ");
int length = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[length, length];

int[,] GetMatrix(int[,] array)
{
    int len0 = array.GetLength(0) - 1;
    int k = 1;  // первое число
    for (int i = 0, field = len0; i < len0; i++, len0--, field -= 2)
    {
        for (int j = 0; j < field; j++, k++)
        {
            array[i, j + i] = k;
            array[j + i, len0] = k + field;
            array[len0, len0 - j] = k + field * 2;
            array[len0 - j, i] = k + field * 3;
        }
        k = k + field * 3;
    }
    if (matrix.GetLength(0) % 2 == 1) array[array.GetLength(0) / 2, array.GetLength(0) / 2] = k;
    return array;
}


void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

}

GetMatrix(matrix);
PrintMatrix(matrix);