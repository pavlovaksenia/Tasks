// Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите значение трехзначного числа");
/*string text = Console.ReadLine();
int N = text[text.Length - 1];
Console.WriteLine($"Последняя цифра числа - {N}");
*/
int N = Convert.ToInt32 (Console.ReadLine());
int mod = N % 10;
Console.Write("Последняя цифра числа ");
Console.WriteLine(mod);
