// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] startAr = {1,2,3,4,5,6};
int[] resAr = new int [3];
void MultArray(int[]array, int[]res)
{
int first =0;
int last = array.Length - 1;
while (last>first)
{
    int index=0;
    res[index]=array[first]*array[last];
    first++;
    last--;
    Console.WriteLine(res[index]);
    index++;
}
}