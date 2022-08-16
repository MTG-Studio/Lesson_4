// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] GetArray()
{
    Console.Write("Введите количество чисел в массиве: ");
    int[] array = new int[Convert.ToInt32(Console.ReadLine())];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-е число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());        
    }
    return array;
}

int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) count++;
    return count;
}

int[] arr = GetArray();
int countPositive = CountPositive(arr);
Console.WriteLine($"Массив введенных чисел: {string.Join(", ", arr)}");
Console.WriteLine($"Количество чисел больше 0: {countPositive}");