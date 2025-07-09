namespace DSA_Practice.SortingTechniques;

public static class MergeSort
{
    // Merge Sort is a divide and conquers algorithm
    // First divide array in halfs, so at last you get all individual element, now start meargin it level by level by sorting it

    // Time complexity: O(nlogn) 
    // Space complexity: O(n)
    // Auxiliary Space Complexity: O(n)

    public static void Sort(int[] a, int low, int high)
    {
        if (low >= high) 
            return;

        int mid = (low + high) / 2;

        Sort(a, low, mid);
        Sort(a, mid + 1, high);

        merge(a, low, mid, high);
    }

    private static void merge(int[] a, int low, int mid, int high)
    {
        List<int> temp = new List<int>();
        int left = low;
        int right = mid + 1;

        while (left <= mid && right <= high)
        {
            if (a[left] <= a[right])
            {
                temp.Add(a[left]);
                left++;
            }
            else
            {
                temp.Add(a[right]);
                right++;
            }
        }

        while (left <= mid)
        {
            temp.Add(a[left]);
            left++;
        }

        while (right <= high)
        {
            temp.Add(a[right]);
            right++;
        }

        for (int i = low; i <= high; i++)
        {
            a[i] = temp[i - low];
        }
    }
}
