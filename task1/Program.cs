//На вход: размер массива и искомое число. Генерирует массив с случайными числами от 1 до 10.
//Если искомое цисло есть в массиве выводит "Да", если нет, то "Нет".
Console.Write("Размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int [size];
Console.Write("Искомое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Random rand = new Random();
for (int i = 0; i < size; i++)
    arr[i] = rand.Next(1, 11);
Console.Write("Сгенерированный массив: ");
foreach (int j in arr)
    Console.Write($"{j} ");
Console.WriteLine();
Console.Write("Итог: ");
foreach (int h in arr)
    if (h == n)
    {
        Console.Write("Да");
        return;
    }
Console.Write("Нет");