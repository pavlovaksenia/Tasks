// Программа проверяет пятизначное число на палиндромом.
int numberRandom = new Random().Next(10000, 100000);
Console.WriteLine($"Выбрано число {numberRandom}");
if (numberRandom % 10 == numberRandom/10000 && numberRandom % 100/10 == numberRandom/1000%10)
Console.WriteLine($"{numberRandom} палиндром");
else
Console.WriteLine($"{numberRandom} не палиндром");




