// Удалить вторую цифру трехзначного числа
int numberRandom = new Random().Next(99,1000);
Console.WriteLine($"Выбрано трехзначное число {numberRandom}");
int numNew1 = numberRandom % 10;
int numNew2 = numberRandom / 100;
Console.WriteLine ($"Удалив вторую цифру числа, получим {numNew2}{numNew1}");