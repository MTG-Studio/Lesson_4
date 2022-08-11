// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void GetEvenQuantity(int[] arr, int quan)
{
    int evenQuan = 0;
    for (int i = 0; i < quan; i++)
        if (arr[i] % 2 == 0)
            evenQuan++;
    Console.WriteLine($"Количество четных чисел в массиве {evenQuan}");
}

Console.Write("Введите количество элементов массива: ");
int quantity = Convert.ToInt32(Console.ReadLine());
int[] array = new int[quantity];
Random rand = new Random();
for (int i = 0; i < quantity; i++)
    array[i] = rand.Next(100, 1000);
Console.WriteLine("[{0}]", string.Join(", ", array));

GetEvenQuantity(array, quantity);