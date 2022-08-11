// See https://aka.ms/new-console-template for more information
public class ShellSort
{
    // private int i;
    
    int i, j, k, gap=0;
    

    public void shellSort(int[] A)
    {
        int n = A.Length;
        //int gap = n / 2;
        //n = l;
        while (gap < n / 3)
        {
            gap = gap * 3 + 1;
        }
        while (gap > 0)
        {
            for(i=gap; i < n; i++)
            {

                    k = A[i];
                    j = i;
                    while (j > gap - 1 && A[j - gap] >= k)
                    {
                        A[j] = A[j - gap];
                        j = j - gap;
                    }
                    A[j] = k;
                    //Console.Write(A[i]+" ");
                
                
            }
            gap = (gap - 1) / 3;
            
        }
        for (i = 0; i < n; i++)
        {
            Console.Write(A[i]+" ");
        }
        Console.WriteLine();


    }
    public static void Main()
    {
        ShellSort shellSort = new ShellSort();
        int[] A = { 15, 17, 13, 12, 10, 11, 14 };

        int n = 0;
        shellSort.shellSort(A);
        
    }
}
