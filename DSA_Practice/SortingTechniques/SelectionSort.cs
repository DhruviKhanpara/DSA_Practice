using DSA_Practice.Utility;

namespace DSA_Practice.SortingTechniques;

public static class SelectionSort
{
    // After each iteration, the array becomes sorted up to the first index of the array
    // Time Complexity: O(N^2)
    // Space Complexity: O(1)

    public static void Sort(int[] a)
    {
        for (int i = 0; i < a.Length - 1; i++)
        {
            int minAt = i;
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[j] < a[minAt])
                    minAt = j;
            }

            int temp = a[i];
            a[i] = a[minAt];
            a[minAt] = temp;
        }

        PrintArray.Print(a);
    }
}
