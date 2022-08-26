// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

void InputNumbers(out int m, out int n)
{
    Console.Write("Введите число m: ");
    m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число n: ");
    n = Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m != 0 && n == 0) return Akkerman(m - 1 ,1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

InputNumbers(out int numberM, out int numberN);
int result = Akkerman(numberM, numberN);
Console.WriteLine($"A(m,n) = {result}");