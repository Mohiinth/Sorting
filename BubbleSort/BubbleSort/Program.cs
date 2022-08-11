// See https://aka.ms/new-console-template for more information
int[] arr = { 5, 18, 17, 3, 1 };
int swap = 0;
for (int i = 0; i < arr.Length; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] > arr[j])
        {
            swap = arr[j];
            arr[j] = arr[i];
            arr[i] = swap;
        }
    }
    Console.WriteLine(arr[i]);

}
