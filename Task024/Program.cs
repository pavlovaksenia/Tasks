// Найти кубы чисел от 1 до N
Console.WriteLine("Введите значение N");
int N = Convert.ToInt32 (Console.ReadLine());
for(int i=1; i<=N; i++)
Console.WriteLine($"{i}^3={i*i*i}");//($"{i}^3={Math.Pow(i, 3)}");
