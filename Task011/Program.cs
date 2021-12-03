// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int numberRandom = new Random().Next(10,100);
Console.WriteLine($"Число из отрезка [10, 99] равно {numberRandom}");
if (numberRandom % 10 > numberRandom / 10)
Console.WriteLine($"Наибольшая цифра числа равна {numberRandom % 10}");
else
Console.WriteLine($"Наибольшая цифра числа равна {numberRandom / 10}");