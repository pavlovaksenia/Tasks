// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Введите координаты X");
int X = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите координаты Y");
int Y = Convert.ToInt32 (Console.ReadLine());
if (X>0 && Y>0)
Console.WriteLine("Точка находится в первой четверти");
if (X<0 && Y>0)
Console.WriteLine("Точка находится во второй четверти");
if (X<0 && Y<0)
Console.WriteLine("Точка находится в третей четверти");
if (X>0 && Y<0)
Console.WriteLine("Точка находится в четвертой четверти");