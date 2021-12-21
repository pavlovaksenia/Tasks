// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/
//отрицательных элементов массива
void FillArray(int[] collection) 
{
    int length = collection.Length; 
    int index = 0;
    while (index<length)// for(int index=0; index<length; index++)
    {
        collection[index] = new Random().Next(0,10); 
        index++;
    } 
}

void PrintArray(int[] col) 
{
    int count = col.Length;
    int position = 0; 
    while(position<count)
    {
        Console.WriteLine(col[position]);
        position++;  
    } 
}

int[] array = new int[12]; 

FillArray(array); 
PrintArray(array); 
int collection;
int length = collection.Length; 
int index = 0;
for(index=0; index<length; index++)
{
    if (collection[index]>0) 
    {
    int sum;
    sum=sum+collection[index];
    Console.WriteLine($"Сумма положительных чисел массива равна {sum}");
    }
    else
    {
    int sum1;
    sum1=sum1+collection[index];
    Console.WriteLine($"Сумма отрицательных чисел массива равна {sum1}");   
    }
}

