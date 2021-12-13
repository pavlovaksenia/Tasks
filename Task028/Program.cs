// Подсчитать сумму цифр в числе
int numberRandom = new Random().Next(6,10000);
Console.WriteLine($"Выбрано число {numberRandom}");

int sum = 0;
while (numberRandom != 0)
{
    sum = sum + (numberRandom % 10); 

     numberRandom = numberRandom/10;
     
}   

Console.WriteLine ($"Сумма цифр в числе равна {sum}");