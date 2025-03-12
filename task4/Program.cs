int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int [3];
for(int i = 0; i < arr.Length; i++)
{
    arr[i]= n % 10;
    n /= 10;
}
foreach (int i in arr)
    Console.Write(i);