﻿// Показать таблицу квадратов чисел от 1 до N
Console.WriteLine("Введите значение N");
int N = Convert.ToInt32 (Console.ReadLine());
for(int i=1; i<=N; i++)
Console.WriteLine($"{i}*{i}={i*i}");

