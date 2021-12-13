// Возведите число А в натуральную степень B используя цикл
Console.WriteLine("Введите число А");
int A = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32 (Console.ReadLine());
int deg = 1;
for(int i=1; i<=B; i++)
{
    deg = deg * A;
}
Console.WriteLine($"{A}^{B} = {deg}");