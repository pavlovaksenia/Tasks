// Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
int numberRandom = new Random().Next(1,7);
Console.WriteLine($"Выбран день недели под номером {numberRandom}");
if (numberRandom == 6||numberRandom == 7)
Console.WriteLine("Это выходной день");
else
Console.WriteLine("Это будний день");