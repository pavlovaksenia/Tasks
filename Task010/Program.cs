// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите значение трехзначного числа");
int N = Convert.ToInt32 (Console.ReadLine());
int mod = N % 100/10;
Console.Write("Вторая цифра числа ");
Console.WriteLine(mod);
