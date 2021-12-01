// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите значение числа n ");
string text = Console.ReadLine();
int n = text[text.Length - 1] - '0';
Console.WriteLine("Последняя цифра числа", n);
