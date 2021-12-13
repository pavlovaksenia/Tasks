// Найти третью цифру числа или сообщить, что её нет
int numberRandom = new Random().Next();
Console.WriteLine($"Выбрано число {numberRandom}");

if (numberRandom > 99)
Console.WriteLine($"{numberRandom.ToString()[2]}");
else
Console.WriteLine("Третьей цифры нет");