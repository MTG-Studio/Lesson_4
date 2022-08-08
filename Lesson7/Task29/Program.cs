// Задача 29: Напишите метод(ы), который задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void Array()
{
    Console.Write("Введите количество элементов массива: ");
    int q = Convert.ToInt32(Console.ReadLine());
    string? n;
    string?[] arr = new string[q];
    for (int i = 1; i <= q; i++)
    {
        Console.Write($"Введите {i}-й элемент массива: ");
        n = Console.ReadLine();
        arr[i - 1] = n;
    }
    Console.WriteLine("[{0}]", string.Join(", ", arr));
}
Array();