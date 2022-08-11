class Quicksort
{

    public static int partition(int[] array, int low, int high)
    {

        int temp = 0;
        int pivot = array[high];


        int i = (low - 1);

        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
            {
                i++;

                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }

        }


        temp = array[i + 1];
        array[i + 1] = array[high];
        array[high] = temp;

        return (i + 1);
    }

    public static void quickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pi = partition(array, low, high);


            quickSort(array, low, pi - 1);

            quickSort(array, pi + 1, high);
        }
    }
}


class Sorting
{
    public static void Main()
    {

        int[] data = { 45, 78, 9, 31, 99, 29, 5 };
        Console.WriteLine("Unsorted Array");
        foreach (int s in data)
        {
            Console.WriteLine(s);
        }

        int size = data.Length;

        // call quicksort() on array data
        Quicksort.quickSort(data, 0, size - 1);

        Console.WriteLine("Sorted array: ");
        foreach (int j in data)
        {
            Console.WriteLine(j);
        }
    }
}