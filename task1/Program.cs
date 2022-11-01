int[] arr = { 52, 123, 2121 };
int min = arr[0];


for(int i = 1; i < arr.Length; i++)
{
    if (arr[i] < min)
    {
        min = arr[i];
    }
}

Console.WriteLine(min);