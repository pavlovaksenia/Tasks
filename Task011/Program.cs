// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int[] mas = Console.ReadLine().Split(' ').Select(m => Convert.ToInt32(m)).ToArray();
            int max = int.MinValue;
            for (int i = 0; i < mas.Length; i++)
            { 
            if(mas[i]>max)
                max=mas[i];
            }
                Console.WriteLine(max);
            Console.ReadLine();
