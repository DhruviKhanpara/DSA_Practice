namespace DSA_Practice.Utility;

public static class PrintArray
{
    public static void Print(int[] a, int? n = null)
    {
        for (int i = 0; i < (n ?? a.Length); i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
    }
}
