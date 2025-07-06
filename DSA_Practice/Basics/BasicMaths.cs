namespace DSA_Practice.Basics;

public static class BasicMaths
{
    public static void CountNumbers(int n)
    {
        // Given an integer N, return the number of digits in N.
        // Input: 3, Output: 1
        // Input: 32, Output: 2

        // Brute Force Approach
        int count = 0, num = n;
        while (num > 0)
        {
            count++;
            num /= 10;
        }
        Console.WriteLine(count);

        // Optimal Approach
        Console.WriteLine((int)(Math.Log10(n) + 1));
    }

    public static void ReverseNumber(int n)
    {
        // Given an integer N return the reverse of the given number.
        // Input: 32, Output: 23
        // Input: 20, Output: 2

        int reverseNum = GetReverseNumber(n);
        Console.WriteLine(reverseNum);
    }

    public static void IsPalindrome(int n)
    {
        // Given an integer N, return true if it is a palindrome else return false.
        // A palindrome is a number that reads the same backward as forward. For example, 121, 1331, and 4554 are palindromes because they remain the same when their digits are reversed.

        int reverse = GetReverseNumber(n);
        Console.WriteLine(n == reverse);
    }

    public static void GCD(int n1, int n2)
    {
        // Given two integers N1 and N2, find their greatest common divisor.
        // The Greatest Common Divisor of any two integers is the largest number that divides both integers.

        // Brute Force Approach
        int gcd = 1;
        for (int i = 2; i < Math.Min(n1, n2); i++)
        {
            if (n1 % i == 0 && n2 % i == 0)
                gcd = i;
        }
        Console.WriteLine(gcd);

        // Better Approach
        for (int i = Math.Min(n1, n2); i < 1; i++)
        {
            if (n1 % i == 0 && n2 % i == 0)
            {
                Console.WriteLine(i);
                break;
            }
        }

        // Optimal Approach

        // Eg, n1 = 20, n2 = 15:
        // gcd(20, 15) = gcd(20 - 15, 15) = gcd(5, 15)
        // gcd(5, 15) = gcd(15 - 5, 5) = gcd(10, 5)
        // gcd(10, 5) = gcd(10 - 5, 5) = gcd(5, 5)
        // gcd(5, 5) = gcd(5 - 5, 5) = gcd(0, 5)
        // Hence, return 5 as the gcd.

        while (n1 > 0 && n2 > 0)
        {
            if (n1 > n2)
            {
                n1 = n1 % n2;
            }
            else
            {
                n2 = n2 % n1;
            }

            if (n1 == 0)
                Console.WriteLine(n2);
            else
                Console.WriteLine(n1);
        }
    }

    public static void IsArmstrong(int n)
    {
        // Given an integer N, return true it is an Armstrong number otherwise return false.
        // An Amrstrong number is a number that is equal to the sum of its own digits each raised to the power of the number of digits.
        // 153 = 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153

        int count = n.ToString().Length;
        int sum = 0, num = n;
        while (num > 0)
        {
            int last = num % 10;
            sum += (int)Math.Pow(last, count);

            num /= 10;
        }
        Console.WriteLine(n == sum);
    }

    public static void GetAllDivisor(int n)
    {
        // Given an integer N, return all divisors of N.
        // A divisor of an integer N is a positive integer that divides N without leaving a remainder.

        // Brute Force Approach
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
               Console.Write(i + " ");
        }
        Console.WriteLine();

        // Optimal Approach
        for (int i = 1; i <= (int)Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                Console.Write(i + " ");
                if ((n / i) != i && n % (n / i) == 0)
                    Console.Write(n / i + " ");
            }
        }
        Console.WriteLine();
    }

    public static void IsPrime(int n)
    {
        // Given an integer N, check whether it is prime or not.
        // A prime number is a number that is only divisible by 1 and itself and the total number of divisors is 2.

        // Brute Force Approach
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                count++;
        }
        Console.WriteLine(count == 2);

        // Optimal Approach
        count = 0;
        for (int i = 1; i <= (int)Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                count++;
                if ((n / i) != i && n % (n / i) == 0)
                    count++;
            }
        }
        Console.WriteLine(count == 2);
    }

    private static int GetReverseNumber(int n)
    {
        int reverseNum = 0;
        while (n > 0)
        {
            int last = n % 10;
            reverseNum = 10 * reverseNum + last;
            n /= 10;
        }
        return reverseNum;
    }
}
