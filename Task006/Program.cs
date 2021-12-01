// Выяснить является ли число чётным
Console.WriteLine("Введите число");
double num = Convert.ToDouble (Console.ReadLine());
/*bool parity(double num) {//bool показывает истина/ложь
    return num % 2 == 0; //== сравнение, != не равно
Console.WriteLine(parity(num));}
*/
if (num % 2 == 0)
Console.WriteLine("Число четное");
else
Console.WriteLine("Число нечетное");

