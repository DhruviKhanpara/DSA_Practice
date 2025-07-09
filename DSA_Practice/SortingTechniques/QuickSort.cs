namespace DSA_Practice.SortingTechniques;

public class QuickSort
{
    // Quick Sort is a divide-and-conquer algorithm
    // Steps:
        // Pick a pivot(first, last, mid, random element of array) and place it in its correct place in the sorted array.
        // Shift smaller elements(i.e.Smaller than the pivot) on the left of the pivot and larger ones to the right.

    // Time Complexity: O(N*logN)
    // Space Complexity: O(N) auxiliary stack space.

    public static void Sort(int[] a, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(a, low, high);

            Sort(a, low, pivotIndex - 1);
            Sort(a, pivotIndex + 1, high);
        }
    }

    public static int Partition(int[] a, int low, int high)
    {
        int pivot = a[high];
        int swapIndex = low;

        for (int current = low; current < high; current++)
        {
            if (a[current] <= pivot)
            {
                Swap(a, current, swapIndex);
                swapIndex++;
            }
        }

        Swap(a, swapIndex, high);
        return swapIndex;
    }

    private static void Swap(int[] a, int i, int j)
    {
        int temp = a[i];
        a[i] = a[j];
        a[j] = temp;
    }
}
