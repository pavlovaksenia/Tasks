// Задать номер четверти, показать диапазоны для возможных координат
int numberRandom = new Random().Next(1,5);
Console.WriteLine($"Выбрана {numberRandom} четверть");
if (numberRandom == 1)
Console.WriteLine("Диапозон возможных координат Х (0;+), Y(0;+)");
if (numberRandom == 2)
Console.WriteLine("Диапозон возможных координат Х (-;0), Y(0;+)");
if (numberRandom == 3)
Console.WriteLine("Диапозон возможных координат Х (-;0), Y(-;0)");
if (numberRandom == 4)
Console.WriteLine("Диапозон возможных координат Х (0;+), Y(-;0)");