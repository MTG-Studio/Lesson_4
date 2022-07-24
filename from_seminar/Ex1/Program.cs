
double Distance(double[] b, double[] c)
{
    double ab = b[0] - c[0];
    double ac = b[1] - c[1];
    return Math.Sqrt(ab * ab + ac * ac);
}

double[] x = { 0, 0 };
double[] y = { 1, 1 };
Console.WriteLine($"dis = {Distance(x, y)}");
