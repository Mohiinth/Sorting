class MergeSort
{
    void mergeSort(int[] arr, int beg, int mid, int end)
    {
        int left = mid - beg + 1;
        int right = end - mid;

        int[] Left_arr = new int[left];
        int[] Right_arr = new int[right];

        for (int i = 0; i < left; ++i)
            Left_arr[i] = arr[beg + i];

        for (int j = 0; j < right; ++j)
            Right_arr[j] = arr[mid + 1 + j];

        int i1 = 0, j1 = 0;
        int k = beg;
        while (i1 < left && j1 < right)
        {
            if (Left_arr[i1] <= Right_arr[j1])
            {
                arr[k] = Left_arr[i1];
                i1++;
            }
            else
            {
                arr[k] = Right_arr[j1];
                j1++;
            }
            k++;
        }
        while (i1 < left)
        {
            arr[k] = Left_arr[i1];
            i1++; k++;
        }
        while (j1 < right)
        {
            arr[k] = Right_arr[j1];
            j1++; k++;
        }
    }

    public void mergesorting(int[] arr, int beg, int end)
    {
        if (beg < end)
        {
            int mid = (beg + end) / 2;
            mergesorting(arr, beg, mid);
            mergesorting(arr, mid + 1, end);
            mergeSort(arr, beg, mid, end);
        }
    }
}
class main
{
    public static void Main()
    {
        int[] arr = { 76, 40, 12, 56, 73, 35, 14, 44, 100, 98 };
        Console.WriteLine("\nInput Array");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i] + " ");
        }
        MergeSort obj = new MergeSort();
        obj.mergesorting(arr, 0, arr.Length - 1);

        Console.WriteLine("\nArray sorted using merge sort");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i] + " ");
        }
    }
}