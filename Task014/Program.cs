// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите любое число больше 100");
int[] array = {};

int n = array.Length; //определяет длину массива
int find = 8;

int index = 0;

while(index<n)
{
if (array[index]==find)
{
    Console.WriteLine (index);
    break;
}
    index++; //index = index+1;
