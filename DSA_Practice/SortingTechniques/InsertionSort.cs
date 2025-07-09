using DSA_Practice.Utility;

namespace DSA_Practice.SortingTechniques;

public static class InsertionSort
{
    // Steps:
        // Select an element in each iteration from the unsorted array(using a loop).
        // Place it in its corresponding position in the sorted part and shift the remaining elements accordingly(using an inner loop and swapping).
        // The “inner while loop” basically shifts the elements using swapping.

    // Time Complexity: O(N^2)
    // Space Complexity: O(1)

    public static void Sort(int[] a)
    {
        for (int i = 1; i < a.Length; i++)
        {
            int j = i;
            while(j > 0 && a[j] < a[j - 1])
            {
                int temp = a[j];
                a[j] = a[j - 1];
                a[j - 1] = temp;
                j--;
            }
        }

        PrintArray.Print(a);
    }

    // Recursive Insertion Sort
    // Call method: RecursiveSort(a, 1);
    // Time Complexity: O(N^2)
    // Space Complexity: O(1)

    public static void RecursiveSort(int[] a, int i)
    {
        if (i == a.Length)
            return;

        int j = i;
        while(j > 0 && a[j] < a[j - 1])
        {
            int temp = a[j];
            a[j] = a[j - 1];
            a[j - 1] = temp;
            j--;
        }

        RecursiveSort(a, i + 1);
    }
}
