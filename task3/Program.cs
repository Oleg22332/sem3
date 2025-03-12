Console.Write("Размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int [size];
Random rand = new Random();
for (int i = 0; i < size; i++)
    arr[i] = rand.Next(1, 11);
Console.Write("Сгенерированный массив: ");
foreach (int j in arr)
    Console.Write($"{j} ");
Console.WriteLine();
int[] newArray = new int [arr.Length / 2];
for (int i = 0; i < newArray.Length; i++)
    newArray[i] = arr[i] * arr[arr.Length - 1 - i];
for (int i = 0; i < newArray.Length; i++)
    Console.Write($"{newArray[i]} ");