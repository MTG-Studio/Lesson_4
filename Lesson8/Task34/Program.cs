// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

string GetRandomArray()
{
    Console.Write("Введите количество элементов массива: ");
    int q = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[q];
    Random rand = new Random();
    for(int i = 0; i < q; i++)
        arr[i] = rand.Next(100, 999);

    Console.WriteLine("[{0}]", string.Join(", ", arr));
    return string.Join(", ", arr);
}
void GetEven()
{
    int q = GetRandomArray().Length;
    for(int i = 0; i < q; i++)
        
    Console.WriteLine(GetRandomArray());
}
GetEven();