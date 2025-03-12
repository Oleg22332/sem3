int[] arr = new int [10];
Random rand = new Random();
for (int i = 0; i < 10; i++)
    arr[i] = rand.Next(-10, 11);
foreach (int i in arr)
    Console.Write($"{i}\t");
Console.WriteLine();
for (int i = 0; i < 10; i++)
{
    arr[i] *= -1;
    Console.Write($"{arr[i]}\t");
}