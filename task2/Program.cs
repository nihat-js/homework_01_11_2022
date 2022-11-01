int[] arr = { 5, 215, 215, 32 };
int counter = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] >=0 && arr[i] < 10)
    {
        counter++;
    }
}


Console.WriteLine(counter);