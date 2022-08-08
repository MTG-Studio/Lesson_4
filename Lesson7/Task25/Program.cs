// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Pow(double x, double y)
{ 
    double result = Math.Pow(x, y);
    Console.WriteLine($"A в степени B равно {result}");
}
Console.Write("Введите число A: ");
double A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
double B = Convert.ToInt32(Console.ReadLine());
Pow(A, B);