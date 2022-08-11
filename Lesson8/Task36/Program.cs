// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void GetSumEvenPos(int[] arr, int quan)
{
    int sumEvenPos = 0;
    for (int i = 1; i < quan; i += 2)
        sumEvenPos += arr[i];

    Console.WriteLine(sumEvenPos);
}

Console.Write("Введите количество элементов массива: ");
int quantity = Convert.ToInt32(Console.ReadLine());
int[] array = new int[quantity];
Random rand = new Random();
for (int i = 0; i < quantity; i++)
    array[i] = rand.Next(-100, 100);
Console.WriteLine("[{0}]", string.Join(", ", array));

GetSumEvenPos(array, quantity);