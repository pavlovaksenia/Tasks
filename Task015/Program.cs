// Дано число. Проверить кратно ли оно 7 и 23
int numberRandom = new Random().Next(7,10000);
Console.WriteLine($"Выбрано число {numberRandom}");
if (numberRandom % 7 == 0)
Console.WriteLine($" Число {numberRandom} кратно 7");
else
Console.WriteLine($" Число {numberRandom} не кратно 7");
if (numberRandom % 23 == 0)
Console.WriteLine($" Число {numberRandom} кратно 23");
else
Console.WriteLine($" Число {numberRandom} не кратно 23");
