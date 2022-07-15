Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int M = 1; //Число, от которого идет просмотр

if (M % 2 == 0)
{
    M = M + 0;
}
else
{
    M = M + 1;
}

while (M <= N)
{
    Console.Write(M + " ");
    M = M + 2;
}
Console.WriteLine();