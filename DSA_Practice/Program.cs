using DSA_Practice.Basics;
using DSA_Practice.SortingTechniques;
using DSA_Practice.Utility;

namespace DSA_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("How many test case you have? ");
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                Console.Write("Give a number input: ");
                int n = Convert.ToInt32(Console.ReadLine());

                int[] a = new int[n];
                for (int j = 0; j < n; j++)
                {
                    a[j] = Convert.ToInt32(Console.ReadLine());
                }

                //Console.Write("Give a number query: ");
                //int m = Convert.ToInt32(Console.ReadLine());

                //int[] q = new int[m];
                //for (int j = 0; j < m; j++)
                //{
                //    q[j] = Convert.ToInt32(Console.ReadLine());
                //}

                QuickSort.Sort(a, 0, a.Length - 1);
                PrintArray.Print(a);
            }
        }
    }
}
