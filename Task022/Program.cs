// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Введите координаты точки А1");
double A1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите координаты точки А2");
double A2 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите координаты точки А3");
double A3 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите координаты точки B1");
double B1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите координаты точки B2");
double B2 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите координаты точки B3");
double B3 = Convert.ToInt32 (Console.ReadLine());
double Distance (double A1)
{
    double dis = Math.Sqrt((B1*B1-2*B1*A1+A1*A1)+(B2*B2-2*B2*A2+A2*A2));
    return dis;
}
Console.Write("Расстояние между точками в пространстве 2D равняется ");
Console.WriteLine(Distance(A1));

double Distance2 (double A1)
{
    double dis = Math.Sqrt((B1*B1-2*B1*A1+A1*A1)+(B2*B2-2*B2*A2+A2*A2)+(B3*B3-2*B3*A3+A3*A3));
    return dis;
}
Console.Write("Расстояние между точками в пространстве 3D равняется ");
Console.WriteLine(Distance2(A1));