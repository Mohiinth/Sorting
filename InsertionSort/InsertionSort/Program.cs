// See https://aka.ms/new-console-template for more information
using System;
class InsertionSort
{
    void insertionSort(int[] A)
    {

        int B = A.Length;
        int i, k;
        for (i = 1; i < B; i++)
        {
            k = A[i];

            while (i > 0 && A[i-1] > k)
            {
                A[i] = A[i-1];
                i = i - 1;
            }
            A[i] = k;

        }
        for (i = 0; i < B; i++)
        {
            Console.WriteLine(A[i]);
        }
    }

    public static void Main()
    {
        int[] A = { 19, 18, 15, 17, 16, };
        InsertionSort obj = new InsertionSort();
        obj.insertionSort(A);
    }
}
