﻿// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double[] array={1.7, 3.6, 2.7, 8.9};
double[] Res(double[] diff)
{
    double max = diff[0];
    double min = diff[0];
    for (int i=0; i<diff.Length; i++)
    {
        if (diff[i]>max)
        {
            max=diff[i];
        }
        else (diff[i]<min)
        {
            min=diff[i];
        }
    }
    Console.WriteLine($"{max}  {min}");
    return new double [] {max, min};
}
double[] newAr = Res(array);
Console.WriteLine($"{newAr[0]} - {newAr[1]} = {newAr[0] - newAr[1]}");