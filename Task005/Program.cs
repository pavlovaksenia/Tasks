// Написать программу вычисления значения функции y = f(a)
Console.WriteLine("Введите a");
double a = Convert.ToDouble (Console.ReadLine());
double function (double a)
{
    double f = a*3;
    return f;
}
Console.Write("Функция от а равняется ");
Console.WriteLine(function(a));