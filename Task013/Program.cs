// Выяснить, кратно ли число заданному, если нет, вывести остаток
Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32 (Console.ReadLine());
if (numberA % numberB == 0)
Console.WriteLine ("Число А кратно числу В");
else
{
  Console.WriteLine ($"Остаток деления числа А на число В равен {numberA % numberB}");  
}