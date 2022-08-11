// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void GetMaxMinDif(int[] arr, int quan)
{
    int max = arr[0];
    int min = arr[0];
    for (int i = 0; i < (quan - 1); i++)
    {
        if (max < arr[i + 1]) max = arr[i + 1];
        if (min > arr[i + 1]) min = arr[i + 1];
    }
    Console.WriteLine($"max = {max}, min = {min}, dif = {max - min}");
}

Console.Write("Введите количество элементов массива: ");
int quantity = Convert.ToInt32(Console.ReadLine());
int[] array = new int[quantity];
Random rand = new Random();
for (int i = 0; i < quantity; i++)
    array[i] = rand.Next(0, 100);
Console.WriteLine("[{0}]", string.Join(", ", array));

GetMaxMinDif(array, quantity);