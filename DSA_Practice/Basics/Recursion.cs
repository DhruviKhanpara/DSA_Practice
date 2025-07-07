namespace DSA_Practice.Basics;

public static class Recursion
{
    public static void PrintNumber(int i, int n)
    {
        // Print from 1 to N using forward Recursion
        // Call this method: PrintNumber(1, n)

        if (i > n)
            return;

        Console.WriteLine(i);
        PrintNumber(i + 1, n);
    }

    public static void PrintNumberBacktracking(int i, int n)
    {
        // Print from 1 to N using forward Recursion
        // Call this method: PrintNumberBackTracking(n, n)

        if (i < 1)
            return;

        PrintNumberBacktracking(i - 1, n);
        Console.WriteLine(i);
    }

    public static void SumOfNumber(int n)
    {
        // Given a number ‘N’, find out the sum of the first N natural numbers.

        // Method 1: Using loop
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);

        // Method 2: Using formula
        sum = (int)(n * (n + 1) / 2);
        Console.WriteLine(sum);

        // Method 3: Parameterized Way Recursion
        SumOfNumberParameterized(n, 0);

        // Method 4: Functional Way Recursion
        Console.WriteLine(SumOfNumberFunctional(n));
    }

    public static int Factorial(int n)
    {
        // Given a number N,  print its factorial.

        if (n <= 1)
            return 1;

        return n * Factorial(n - 1);
    }

    public static void ReverseArray(int[] a, int n)
    {
        // You are given an array. The task is to reverse the array and print it.

        // Method 1: Using an extra array
        int[] reverse = new int[n];
        for (int i = 0; i < n; i++)
        {
            reverse[i] = a[n - i - 1];
        }
        PrintArray(reverse, n);

        // Method 2: Space-optimized iterative method
        int p1 = 0, p2 = n - 1;
        while (p1 < p2)
        {
            int tmp = a[p1];
            a[p1] = a[p2];
            a[p2] = tmp;
            p1++;
            p2--;
        }
        PrintArray(a, n);

        // Method 3: Recursion
        ReverseArrayRecursion(a, 0, n - 1);
        PrintArray(a, n); // Get original array because from Method 2 original array became reverse

        // Method 4: Using library function
        Array.Reverse(a);
        PrintArray(a, n); // Get reverse array because from Method 3 reverse array became original
    }

    public static void IsPalindrome(string s)
    {
        // Given a string, check if the string is palindrome or not

        // Method 1:
        int left = 0, right = s.Length - 1;
        while (left < right)
        {
            char l = s[left], r = s[right];
            if (!Char.IsLetterOrDigit(l))
                left++;
            else if (!Char.IsLetterOrDigit(r))
                right--;
            else if (Char.ToLower(l) != Char.ToLower(r))
            {
                Console.WriteLine(false);
                return;
            }

            else
            {
                left++;
                right--;
            }
        }
        Console.WriteLine(true);

        // Method 2: Recursion
        string cleaned = new string(s.Where(char.IsLetterOrDigit)
            .Select(char.ToLower)
            .ToArray());

        IsPalindromeStringRecursion(cleaned, 0);
    }

    public static void Febonacci(int n)
    {
        // Given an integer N. Print the Fibonacci series up to the Nth term.
        // Input: 5, Output: 0 1 1 2 3 5

        // Method 1: Naive approach
        int[] nums = new int[n + 1];
        nums[0] = 0;
        if(n >= 1)
        {
            nums[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                nums[i] = nums[i - 1] + nums[i - 2];
            }
        }
        PrintArray(nums, n + 1);

        // Method 2: Space optimized
        if (n == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            int secondLast = 0;
            if (n >= 1)
            {
                int last = 1;
                Console.Write(secondLast + " " + last + " ");
                int cur;
                for (int i = 2; i <= n; i++)
                {
                    cur = last + secondLast;
                    secondLast = last;
                    last = cur;
                    Console.Write(cur + " ");
                }
            }
            else
                Console.Write(secondLast);
            Console.WriteLine();
        }

        // Method 3: Intuition
        for (int i = 0; i <= n; i++)
        {
            Console.Write(FebonacciIntuition(i) + " ");
        }
        Console.WriteLine();
    }

    private static void SumOfNumberParameterized(int i, int sum)
    {
        if (i < 1)
        {
            Console.WriteLine(sum);
            return;
        }

        SumOfNumberParameterized(i - 1, sum + i);
    }

    private static int SumOfNumberFunctional(int n)
    {
        if (n == 0)
            return 0;

        return n + SumOfNumberFunctional(n - 1);
    }

    private static void ReverseArrayRecursion(int[] a, int start, int end)
    {
        if (start < end)
        {
            int temp = a[start];
            a[start] = a[end];
            a[end] = temp;
            ReverseArrayRecursion(a, start + 1, end - 1);
        }
    }

    private static void IsPalindromeStringRecursion(string s, int i)
    {
        if (i >= s.Length / 2)
        {
            Console.WriteLine(true);
            return;
        }

        if (s[i] != s[s.Length - i - 1])
        {
            Console.WriteLine(false);
            return;
        }

        IsPalindromeStringRecursion(s, i + 1);
    }

    private static int FebonacciIntuition(int idx)
    {
        if (idx <= 1)
            return idx;

        int last = FebonacciIntuition(idx - 1);
        int sLast = FebonacciIntuition(idx - 2);

        return last + sLast;
    }

    private static void PrintArray(int[] a, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
    }
}
