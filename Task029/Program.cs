// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число N");
int N = Convert.ToInt32 (Console.ReadLine());
int cup (int n)
{
    if (n==1) return 1;
    else return n*cup(n-1);
}
Console.WriteLine($"Произведение чисел от 1 до {N}");
Console.WriteLine(cup(N));
