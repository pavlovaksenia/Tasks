// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Введите три координаты первой точки");

double x1 = Convert.ToDouble (Console.ReadLine());
double y1 = Convert.ToDouble (Console.ReadLine());
double z1 = Convert.ToDouble (Console.ReadLine());

Console.WriteLine("Введите три координаты второй точки");

double x2 = Convert.ToDouble (Console.ReadLine());
double y2 = Convert.ToDouble (Console.ReadLine());
double z2 = Convert.ToDouble (Console.ReadLine());

double Distance (double x1)
{
    double dis = Math.Sqrt(Math.Pow(x2 - x1,2)+ Math.Pow(y2 - y1,2));
    return dis;
}
Console.Write("Расстояние между точками в пространстве 2D равняется ");
Console.WriteLine(Distance(x1));

double Distance2 (double x1)
{
    double dis = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
    return dis;
}
Console.Write("Расстояние между точками в пространстве 3D равняется ");
Console.WriteLine(Distance2(x1));