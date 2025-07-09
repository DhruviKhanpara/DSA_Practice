using DSA_Practice.Utility;

namespace DSA_Practice.SortingTechniques;

public static class BubbleSort
{
    // After each iteration, the array becomes sorted up to the last index of the array
    // Time Complexity: O(N^2)
    // Space Complexity: O(1)

    public static void Sort(int[] a)
    {
        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i] > a[j])
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }

        PrintArray.Print(a);
    }

    // Recursive Bubble Sort
    // Call method: RecursiveSort(a, a.Length);
    // Time Complexity: O(N^2)
    // Space Complexity: O(N) auxiliary stack space.

    public static void RecursiveSort(int[] a , int n)
    {
        if (n == 1)
            return;

        for (int i = 0; i < n - 1; i++)
        {
            if (a[i] > a[i + 1])
            {
                var temp = a[i];
                a[i] = a[i + 1];
                a[i + 1] = temp;
            }
        }

        RecursiveSort(a, n - 1);
    }

    // Optimized time complexity
    // Time Complexity: O(N^2) for worst and average case but for best case it's O(N)
    // Space Complexity: O(N) auxiliary stack space.

    public static void RecursiveOptimizedSort(int[] a, int n)
    {
        if (n == 1)
            return;

        bool isSwaped = false;
        for (int i = 0; i < n - 1; i++)
        {
            if (a[i] > a[i + 1])
            {
                var temp = a[i];
                a[i] = a[i + 1];
                a[i + 1] = temp;
                isSwaped = true;
            }
        }

        if (!isSwaped) 
            return;

        RecursiveOptimizedSort(a, n - 1);
    }
}
