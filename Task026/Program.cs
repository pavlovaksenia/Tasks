// Возведите число А в натуральную степень B используя цикл
Console.WriteLine("Введите число А");
int A = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32 (Console.ReadLine());
int Quotient (int n)
{
    int q = A*B;
    return q;
}
Console.Write($"{A}^{B} = ");
Console.WriteLine(Quotient(A*B));