// Показать двумерный массив размером m×n заполненный вещественными числами

double m = 10;
double n = 10;


double[,] array = new int[m, n];

void FillArray(double[,] fill)
{
    for (int i = 0; i < fill.GetLength(0); i++)
    {
        for (int j = 0; j < fill.GetLength(1); j++)
        {
            fill [j, i] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(double[,] print)
{
    for (int i = 0; i < print.GetLength(0); i++)
    {
        for (int j = 0; j < print.GetLength(1); j++)
        {
            Console.Write(print[j, i] + " ");
        }
        Console.WriteLine();
    }
}

FillArray(array);
PrintArray(array);