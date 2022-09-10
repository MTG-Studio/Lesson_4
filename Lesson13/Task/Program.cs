// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string?[] GetArray()
{
    Console.Write("Введите длину массива: ");
    int length = Convert.ToInt32(Console.ReadLine());
    string?[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void CutArray(string?[] array, out string[] cutArray, out int cutArrayLength)
{
    cutArrayLength = 0;
    cutArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]!.Length <= 3)
        {
            cutArray[cutArrayLength] = array[i]!;
            cutArrayLength++;
        }
    }
}

string?[] arr = GetArray();

string?[] cutArr = new string[arr.Length];
int cutArrLength;
CutArray(arr, out cutArr, out cutArrLength);
Array.Resize(ref cutArr, cutArrLength);

Console.Write("[{0}]", string.Join(", ", arr));
Console.WriteLine(" -> [{0}]", string.Join(", ", cutArr));