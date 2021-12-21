// Определить, присутствует ли в заданном массиве, некоторое число
int[] array = {1,2, 3, 4, 5, 6, 7, 8, 9};
int b = 10;
int c = b;

for (int i=0; i<array.Length; i++)
{
    if (b==array[i])
    {
        b=array[i];
        break;
    }
    else
    {
        c=b;
    }
}
Console.WriteLine($"{b} в массиве");
Console.WriteLine($"{c} не в массиве");
