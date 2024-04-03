// найти сумму ((-1)^n*x^2n)/(2n)!;
Console.Write("Введите число x:");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число y:");
double y = Convert.ToDouble(Console.ReadLine());
double result = 0;
for (int n = 0;n<=y;n++)
{
    result += (Math.Pow(-1, n) * Math.Pow(x, 2 * n)) / Factorial(2*n);
}
Console.WriteLine(result);

double Factorial(double n)
{
    double f = 1;
    for(double j =1;j<=n;j++)
    {
        f *= j;
    }
    return f;
}


