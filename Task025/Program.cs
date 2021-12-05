//Найти сумму чисел от 1 до А
Console.WriteLine("Введите число А");
int A = Convert.ToInt32 (Console.ReadLine());
int Sum (int n)
{
    if (n==1) return 1;
    else return n+Sum(n-1);
}
Console.WriteLine($"Сумма чисел от 1 до {A}");
Console.WriteLine(Sum(A));