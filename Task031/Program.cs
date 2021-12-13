// Задать массив из 8 элементов и вывести их на экран
void FillArray(int[] collection) //Эта функция придумывает массив не с нулями)))
{
    int lenght = collection.Length; //определяет длину массива
    int index = 0;
    while (index<lenght)
    {
        collection[index] = new Random().Next(1, 10); //положить новое случайное число из диапозона 1-10 
        index++; //index = index + 1;
    } 
}

void PrintArray(int[] col) //col=collection Эта функция выводит массив на экран
{
    int count = col.Length;
    int position = 0; //position=index
    while(position<count)
    {
        Console.WriteLine(col[position]);
        position++;  
    } 
}

int[] array = new int[8]; //"создай новый массив в котором будет 8 элементов"

FillArray(array); //заполнил массив
PrintArray(array); //распечатал массив

