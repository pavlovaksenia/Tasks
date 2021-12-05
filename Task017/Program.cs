// По двум заданным числам проверять является ли одно квадратом другого
int numberRandomA = new Random().Next();
int numberRandomB = new Random().Next();
if (numberRandomA == numberRandomB*numberRandomB)
Console.WriteLine($"{numberRandomA} является квадратом {numberRandomB}");
else
Console.WriteLine($"{numberRandomA} не является квадратом {numberRandomB}");
if (numberRandomB == numberRandomA*numberRandomA)
Console.WriteLine($"{numberRandomB} является квадратом {numberRandomA}");
else
Console.WriteLine($"{numberRandomB} не является квадратом {numberRandomA}");