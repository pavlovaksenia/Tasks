﻿// Определить количество цифр в числе

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
int count = 0;
while (number != 0)
{
     number = number/10;
     count++;
}
Console.WriteLine(count);