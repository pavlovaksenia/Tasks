// Удалить вторую цифру трехзначного числа
int numberRandom = new Random().Next(99,1000);
Console.WriteLine($"Выбрано трехзначное число {numberRandom}");
/*int numberRandom = Convert.ToInt32 (Console.ReadLine());
Console. = numberRandom % 100/10;

string MyString = $"{numberRandom}";
Console.WriteLine(MyString.Remove(2));
*/
int mod = numberRandom % 100/10;
Console.WriteLine ($"{numberRandom} remove")